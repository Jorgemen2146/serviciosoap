using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ServiciosSAPReport
{
    public class Keys
    {

        public static string GetSqlConexion()
        {
            return ConfigurationManager.ConnectionStrings["SqlCnn"].ConnectionString;
        }

    }
}