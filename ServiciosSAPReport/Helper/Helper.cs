using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Net;
using ServiciosSAPReport.Models;
using System.Data;

namespace ServiciosSAPReport
{
    public class Helper
    {

        #region Maestros
        /// <summary>
        /// 
        /// </summary>
        /// <param name="I_CHOFERES"></param>
        /// <returns></returns>
     
        public static List<Recibo1> GetCabecerasGathering(DataTable dtTRNARRP)
        {

            List<Recibo1> cabeceras = new List<Recibo1>();

            foreach (DataRow row in dtTRNARRP.Rows)
            {
                Recibo1 cabecera = new Recibo1();
                cabecera._AdvancedTags_KEP_XFER_ST1_TEMP_VALUE = row["_AdvancedTags_KEP_XFER_ST1_TEMP_VALUE"]?.ToString();
                cabecera.Suiza_Fill_Receiving_01_Xfer_ST1_Date_VALUE = row["Suiza_Fill_Receiving_01_Xfer_ST1_Date_VALUE"]?.ToString();
                cabecera.Suiza_Fill_Receiving_02_Xfer_ST1_Oper_ID_VALUE = row["Suiza_Fill_Receiving_02_Xfer_ST1_Oper_ID_VALUE"]?.ToString();
                cabecera.Suiza_Fill_Receiving_03_Xfer_ST1_Route_VALUE = row["Suiza_Fill_Receiving_03_Xfer_ST1_Route_VALUE"]?.ToString();
                cabecera.Suiza_Fill_Receiving_04_Xfer_ST1_Unit_VALUE = row["Suiza_Fill_Receiving_04_Xfer_ST1_Unit_VALUE"]?.ToString();
                cabecera.Suiza_Fill_Receiving_05_Xfer_ST1_Start_Time_VALUE = row["Suiza_Fill_Receiving_05_Xfer_ST1_Start_Time_VALUE"]?.ToString();
                cabecera.Suiza_Fill_Receiving_06_Xfer_ST1_Stop_Time_VALUE = row["Suiza_Fill_Receiving_06_Xfer_ST1_Stop_Time_VALUE"]?.ToString();
                cabecera.Suiza_Fill_Receiving_08_Xfer_ST1_Lb_VALUE = row["Suiza_Fill_Receiving_08_Xfer_ST1_Lb_VALUE"]?.ToString();

                cabecera.Suiza_Fill_Receiving_09_Xfer_ST1_Qt_VALUE = row["Suiza_Fill_Receiving_09_Xfer_ST1_Qt_VALUE"]?.ToString();
                cabecera.Suiza_Fill_Receiving_10_Xfer_ST1_Gal_VALUE = row["Suiza_Fill_Receiving_10_Xfer_ST1_Gal_VALUE"]?.ToString();
                cabecera.Suiza_Fill_Receiving_11_Xfer_ST1_Silo_VALUE = row["Suiza_Fill_Receiving_11_Xfer_ST1_Silo_VALUE"]?.ToString();
                cabeceras.Add(cabecera);
            }

            return cabeceras;

        }

        public static List<Recibo2> GetDetallesGathering(DataTable dtTRNPROP)
        {

            List<Recibo2> detalles = new List<Recibo2>();

            foreach (DataRow row in dtTRNPROP.Rows)
            {
                Recibo2 detalle = new Recibo2();
                detalle._AdvancedTags_KEP_XFER_ST2_TEMP_VALUE = row["_AdvancedTags_KEP_XFER_ST2_TEMP_VALUE"]?.ToString();
                detalle.Suiza_Fill_Receiving_15_Xfer_ST2_Date_VALUE = row["Suiza_Fill_Receiving_15_Xfer_ST2_Date_VALUE"]?.ToString();
                detalle.Suiza_Fill_Receiving_16_Xfer_ST2_Oper_ID_VALUE = row["Suiza_Fill_Receiving_16_Xfer_ST2_Oper_ID_VALUE"]?.ToString();
                detalle.Suiza_Fill_Receiving_17_Xfer_ST2_Route_VALUE = row["Suiza_Fill_Receiving_17_Xfer_ST2_Route_VALUE"]?.ToString();
                detalle.Suiza_Fill_Receiving_18_Xfer_ST2_Unit_VALUE = row["Suiza_Fill_Receiving_18_Xfer_ST2_Unit_VALUE"]?.ToString();
                detalle.Suiza_Fill_Receiving_19_Xfer_ST2_Start_Time_VALUE = row["Suiza_Fill_Receiving_19_Xfer_ST2_Start_Time_VALUE"]?.ToString();
                detalle.Suiza_Fill_Receiving_20_Xfer_ST2_Stop_Time_VALUE = row["Suiza_Fill_Receiving_20_Xfer_ST2_Stop_Time_VALUE"]?.ToString();
                detalle.Suiza_Fill_Receiving_22_Xfer_ST2_Lb_VALUE = row["Suiza_Fill_Receiving_22_Xfer_ST2_Lb_VALUE"]?.ToString();

                detalle.Suiza_Fill_Receiving_23_Xfer_ST2_Qt_VALUE = row["Suiza_Fill_Receiving_23_Xfer_ST2_Qt_VALUE"]?.ToString();
                detalle.Suiza_Fill_Receiving_24_Xfer_ST2_Gal_VALUE = row["Suiza_Fill_Receiving_24_Xfer_ST2_Gal_VALUE"]?.ToString();
                detalle.Suiza_Fill_Receiving_25_Xfer_ST2_Silo_VALUE = row["Suiza_Fill_Receiving_25_Xfer_ST2_Silo_VALUE"]?.ToString();
                detalles.Add(detalle);
            }

            return detalles;

        }

       
        #endregion
    }
}