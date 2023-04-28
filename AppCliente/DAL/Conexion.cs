using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppCliente
{
    public class Conexion
    {
        protected SqlConnection cnx = null;
        string cadena ="Data Source=.\\SQLEXPRESS; Initial Catalog = BD_SEMANA2; User Id = Sa; password=123456";
        public Conexion()
        {
            cnx = new SqlConnection(cadena);
        }
    }
}
