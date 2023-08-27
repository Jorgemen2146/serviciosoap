using Microsoft.SqlServer.Server;
using ServiciosSAPReport.Models.Responses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using ServiciosSAPReport.Models;
using ServiciosSAPReport.Models.Requests;
using System.Reflection;
using System.Globalization;

namespace ServiciosSAPReport.Manager
{
    public class DataManager
    {

     
      
        public static Response GetDataReporte(Request requestGathering)
        {

            //Logger.LogInfo("Iniciando la obtención de la data de acopio.", MethodBase.GetCurrentMethod().Name, Constants.APP_NAME, true);

            Response response = new Response();
            string message = "";

            //Save Data
            try
            {
                //Validamos que haya información a consultar
                //if (requestGathering == null) throw new Exception(Constants.MSG_GATHERING_EMPTY);

                string cs = Keys.GetSqlConexion();
                ResponseDataOril responseDataOril = new ResponseDataOril();
                List<Recibo1> Recibos1 = new List<Recibo1>();
                List<Recibo2> Recibos2 = new List<Recibo2>();
           
                //RECIBO1
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("spReceiving1_Email", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(GetGatheringParametersList(requestGathering));                    

                    con.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    //Recibo1spReceiving1_Email
                    DataTable dtTRNARRP = ds.Tables[0];
                    Recibos1 = Helper.GetCabecerasGathering(dtTRNARRP);

                    

                  

                    con.Close();
                }

                //RECIBO2
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("spReceiving2_Email", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(GetGatheringParametersList(requestGathering));

                    con.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    

                    //Recibo2
                    DataTable dtTRNPROP = ds.Tables[0];
                    Recibos2 = Helper.GetDetallesGathering(dtTRNPROP);



                    con.Close();
                }

                responseDataOril.EstacionRecibo1 = Recibos1;
                responseDataOril.EstacionRecibo2 = Recibos2;
       

                message = "Data Reporte";
                response.StatusCode = HttpStatusCode.OK;
                response.Data = responseDataOril;
                response.Error = false;
                response.Message = message;
                response.MessageProgrammer = string.Empty;
              
            }
            catch (Exception error)
            {
                message = "Ha ocurrido un error al obtener la data";
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Error = true;
                response.Message = message;
                response.MessageProgrammer = error.Message;
               
            }

            return response;


        }

        private static SqlParameter[] GetGatheringParametersList(Request requestGathering)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();

             DateTime i_date =  DateTime.ParseExact(requestGathering.CIP, "MM/dd/yyyy", CultureInfo.InvariantCulture); 

            
            SqlParameter parameterFecha = new SqlParameter("@CurrentCIP", i_date);
            parameters.Add(parameterFecha);

            return parameters.ToArray();
        }

        private static SqlParameter CreateSQLParameter(string parameterName, SqlDbType parameterType, List<SqlDataRecord> data)
        {

            SqlParameter parameter = new SqlParameter(string.Format("@{0}", parameterName), parameterType);
            parameter.TypeName = string.Format("dbo.{0}", parameterName);
            parameter.Value = data == null || data.Count == 0 ? null : data;
            return parameter;

        }

    }
}