using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppCliente
{
    public class Cliente:Conexion
    {
        public int IdCliente { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }

        public Cliente() : base() { }


        public void Guardar()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                cnx.Open();
                comando.Connection = cnx;
                comando.CommandText = "Sp_Insertar_Cliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue ("@Apellidos",Apellidos);
                comando.Parameters.AddWithValue("@Nombres", Nombres);
                comando.Parameters.AddWithValue("@DNI", DNI);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@Celular", Celular);
                comando.ExecuteNonQuery(); //este codigo le ordena a ejecutarse
                cnx.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public DataTable Listar ()
        {
            
                try
                {
                    DataSet ds = new DataSet();
                    SqlCommand comando = new SqlCommand();
                    cnx.Open();
                    comando.Connection = cnx;
                    comando.CommandText = "Sp_Listar_Cliente";
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    adapter.Fill(ds);
                    cnx.Close();
                    return ds.Tables[0];
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

        public void Actualizar()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                cnx.Open();
                comando.Connection = cnx;
                comando.CommandText = "Sp_Actualizar_Cliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdCliente", IdCliente);
                comando.Parameters.AddWithValue("@Apellidos", Apellidos);
                comando.Parameters.AddWithValue("@Nombres", Nombres);
                comando.Parameters.AddWithValue("@DNI", DNI);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@Celular", Celular);
                comando.ExecuteNonQuery(); //este codigo le ordena a ejecutarse
                cnx.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void Eliminar()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                cnx.Open();
                comando.Connection = cnx;
                comando.CommandText = "Sp_Eliminar_Cliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdCliente", IdCliente);
             
                comando.ExecuteNonQuery(); //este codigo le ordena a ejecutarse
                cnx.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
