using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServiciosSAPReport.Models.Requests
{
    [DataContract]
    public class Request
    {

        
        private string fecha;

      

        [DataMember]
        public string CIP
        {
            get { return fecha; }
            set { fecha = value; }
        }

    }
}