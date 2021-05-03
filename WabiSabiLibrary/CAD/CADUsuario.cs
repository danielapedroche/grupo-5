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
    class CADUsuario
    {
        private string constring;
        public CADUsuario()
        {
            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        }
        public bool create(ENUsuario en)
        {
            SqlConnection conn = new SqlConnection(constring);
            string comando = "Insert Into [dbo].[Usuarios] (nif, email, contrasenya, nombre, apellidos,telefono, direccion, fechaNac) " + "VALUES ('" + en.Nif + "', '" + en.Email+ "', " + en.Contrasenya + en.Nombre + "', " + en.Apellidos + "', " + en.Telefono + "', " + en.Direccion + "', " + en.FechaNac.ToString() + ")";
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
        public bool read(ENUsuario en)
        {
            SqlConnection conn = new SqlConnection(constring);
            String comando = "select * from [dbo].[Usuarios] where nif='" + en.Nif + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (int.Parse(dr["nif"].ToString()) == en.Nif)
                {
                    en.Email = dr["email"].ToString();
                    en.Nombre = dr["nombre"].ToString();
                    en.Contrasenya= dr["contrasenya"].ToString();
                    en.Direccion= dr["direccion"].ToString();
                    en.Apellidos = dr["apellidos"].ToString();
                    en.Telefono = dr["telefono"].ToString();
                    en.FechaNac= dr["fechanac"].ToString();
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
        public bool update(ENUsuario en)
        {
            SqlConnection conn = new SqlConnection(constring);
            string comando = "UPDATE [dbo].[Usuarios] " + "SET nombre = '" + en.Nombre + "',  email = " + en.Email + "', contrasenya= " + en.contrasenya + "', direccion = " + en.Direccion + "', apellidos = " + en.Apellidos + "', telefono = " + en.Telefono + "', fechanac = " + en.FechaNac + "where nif ='" + en.Nif + "'";
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
        public bool delete(ENUsuario en)
        {
            SqlConnection conn = new SqlConnection(constring); ;
            string comando = "Delete from [dbo].[Usuarios] where nif = '" + en.Nif + "'";
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
