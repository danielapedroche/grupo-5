using System;
using System.Collections.Generic;
using System.Configuration;
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
    }
}
