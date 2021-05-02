using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{
    class CADSuscripcion
    {
        private string constring;

        public CADSuscripcion()

        {

            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();

        }

        public bool create(ENSuscripcion en)

        {

            SqlConnection conn = new SqlConnection(constring);

            string comando = "Insert Into [dbo].[Suscripcion] (id, tipo) " + "VALUES ('" + en.Id + "', '" + en.Tipo + ")";

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

        public bool read(ENSuscripcion en)

        {

            SqlConnection conn = new SqlConnection(constring);

            String comando = "select * from [dbo].[Suscripcion] where id='" + en.Id + "'";

            try

            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(comando, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                if (int.Parse(dr["id"].ToString()) == en.Id)

                {

                    en.Id = int.Parse(dr["id"].ToString());

                    en.Tipo = dr["tipo"].ToString();

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

        public bool update(ENSuscripcion en)

        {

            SqlConnection conn = new SqlConnection(constring);

            string comando = "UPDATE [dbo].[Suscripcion] " + "SET tipo = '" + en.Tipo + "where id ='" + en.Id + "'";

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

        public bool delete(ENSuscripcion en)

        {

            SqlConnection conn = new SqlConnection(constring); ;

            string comando = "Delete from [dbo].[Suscripcion] where id = '" + en.Id + "'";

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
