using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{
    class CADOrden
    {
        private string constring;
        public CADOrden()
        {
            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        }
        public bool create(ENOrden en)
        {
            SqlConnection conn = new SqlConnection(constring);
            string comando = "Insert Into [dbo].[Orden] (id, descripcion) " + "VALUES ('" + en.Id + "', '" + en.Descripcion + ")";
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
        public bool read(ENOrden en)
        {
            SqlConnection conn = new SqlConnection(constring);
            String comando = "select * from [dbo].[Orden] where id='" + en.Id + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (int.Parse(dr["id"].ToString()) == en.Id)
                {
                    en.Id = int.Parse(dr["id"].ToString());
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
        public bool update(ENOrden en)
        {
            SqlConnection conn = new SqlConnection(constring);
            string comando = "UPDATE [dbo].[Orden] " + "SET descripcion = '" + en.Descripcion + "where id ='" + en.Id + "'";
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
        public bool delete(ENOrden en)
        {
            SqlConnection conn = new SqlConnection(constring); ;
            string comando = "Delete from [dbo].[Orden] where id = '" + en.Id + "'";
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
