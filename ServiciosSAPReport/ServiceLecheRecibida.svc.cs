using ServiciosSAPReport.Models.Requests;
using ServiciosSAPReport.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ServiciosSAPReport.Manager;

namespace ServiciosSAPReport
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IServiceLecheRecibida
    {
        public Response GetReporteLecheObtenida(Request requestreporte)
        {
            //Save route data
            WebOperationContext webOperationContext = WebOperationContext.Current;
            Response response = DataManager.GetDataReporte(requestreporte);
            webOperationContext.OutgoingResponse.StatusCode = response.StatusCode;
            return response;
        }
    }
}
