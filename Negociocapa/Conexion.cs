using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace Negociocapa
{
    public class ConexionDB
    {
        public static string stringConnection = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
    }
}
