using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace WabiSabiLibrary
{
    class CADOferta
    {
        private string constring;
        public CADOferta()
        {
            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        }
        public bool create(ENOferta en) { 
     
            SqlConnection conn = new SqlConnection(constring);
            string comando = "Insert Into [dbo].[Ofertas] (codigo,tipo, descripcion) " + "VALUES ('" + en.Codigo + en.Tipo + "', '" + en.Descripcion + ")";
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
        public bool read(ENOferta en)
        {
            SqlConnection conn = new SqlConnection(constring);
            String comando = "select * from [dbo].[Ofertas] where codigo='" + en.Codigo + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (int.Parse(dr["codigo"].ToString()) == en.Codigo)
                {
     
                    en.Tipo = int.Parse(dr["tipo"].ToString());
                    en.Descripcion = dr["descripcion"].ToString();
                    dr.Close();
                    conn.Close();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }
        public bool update(ENOferta en)
        {
            SqlConnection conn = new SqlConnection(constring);
            string comando = "UPDATE [dbo].[Ofertas] " + "SET codigo = '" + en.Codigo + "',  tipo = " + en.Tipo + "', descripcion" + en.Descripcion +  "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        public bool delete(ENOferta en)
        {
            SqlConnection conn = new SqlConnection(constring); ;
            string comando = "Delete from [dbo].[Ofertas] where codigo = '" + en.Codigo + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

    }
}
