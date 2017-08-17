using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Conexion
{
    public static class ConnectionManager
    {
        public static string GetConnectionString()
        {
            try
            {
                return ConfigurationManager.ConnectionStrings["EagleContext"].ConnectionString;
            }
            catch (Exception)
            {

                return "";
            }
        }
    }
}
