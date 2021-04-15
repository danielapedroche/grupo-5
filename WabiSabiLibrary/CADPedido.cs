using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{
    class CADPedido
    {
        private string constring { get; set; }

        public CADPedido()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        public bool createPedido(ENPedido en)
        {
            SqlConnection conn = null;
            String comando = "Insert into Pedido(Id,Fecha,Precio,Direccion,Estado) VALUES ('" + en.Id + "','" +
                en.Fecha + "','" + en.Precio + "','" + en.Direccion + "','" + en.Estado + "')";

            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión.
            }

            return true;
        }
        public bool updateUsuario(ENPedido en)
        {
            SqlConnection conn = null;
            String comando = "Update Pedido set fecha = '" + en.Fecha + "', precio = '" + en.Precio + "', Direccion = '" + en.Direccion + "', Estado = '" + en.Estado
                + "' where id = '" + en.Id + "'";

            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión.
            }

            return true;
        }

        public void readPedido(ENPedido en)
        {
            SqlConnection conn = null;
            String comando = "Select * from Pedido where Id = '" + en.Id + "'";

            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    en.Fecha = dr.GetDateTime(1);
                    en.Precio = dr.GetFloat(2);
                    en.Direccion = dr.GetString(3);
                    en.Estado = dr.GetString(4);
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                dr.Close();
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión.
            }
        }
        public void confirmPedido(ENPedido en)
        {
            SqlConnection conn = null;
            String comando = "Select * from Pedido where Id = '" + en.Id + "'";

            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    en.Fecha = dr.GetDateTime(1);
                    en.Precio = dr.GetFloat(2);
                    en.Direccion = dr.GetString(3);
                    en.Estado = dr.GetString(4);
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                dr.Close();
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión.
            }
        }
        public bool deletePedido(ENPedido en)
        {
            SqlConnection conn = null;
            String comando = "Delete from Pedido where Id = '" + en.Id + "'";

            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión.
            }

            return true;
        }
    }

}
