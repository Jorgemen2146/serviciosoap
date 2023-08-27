using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosSAPReport.Models.Responses
{
    public class ResponseDataOril
    {

        public List<Recibo1> EstacionRecibo1 { get; set; }

        public List<Recibo2> EstacionRecibo2 { get; set; }
        //public List<TRNPROP> detalles { get; set; }
        //public List<TRNTCKT> detalles_tickets { get; set; }

    }
}