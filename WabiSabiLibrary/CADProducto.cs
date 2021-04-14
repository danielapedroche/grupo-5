using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace WabiSabiLibrary
{
    class CADProducto
    {
        private string constring;
        public CADProducto()
        {
            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        }
        public bool create(ENProducto en)
        {
            SqlConnection conn = new SqlConnection(constring);
            string comando = "Insert Into [dbo].[Productos] (codigo, nombre, descripcion, precio) " + "VALUES ('" + en.Codigo + "', '" + en.Nombre + "', " + en.Descripcion + ")";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Error: " + e);
                return false;
            }
            return true;
        }

    }
}
