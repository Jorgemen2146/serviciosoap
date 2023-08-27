using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;

namespace ServiciosSAPReport.Models.Responses
{
    public class Response
    {

        public HttpStatusCode StatusCode;
        public bool Error;
        public ResponseDataOril Data;
        public string Message;
        public string MessageProgrammer;

    }
}