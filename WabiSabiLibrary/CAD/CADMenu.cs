using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{

        class CADMenu

        {

            private string constring;

            public CADMenu()

            {

                constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();

            }

            public bool create(ENMenu en)

            {

                SqlConnection conn = new SqlConnection(constring);

                string comando = "Insert Into [dbo].[Menu] (id, nombre, precio) " + "VALUES ('" + en.Id + "', '" + en.Nombre + "', " + en.Precio + ")";

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

            public bool read(ENMenu en)

            {

                SqlConnection conn = new SqlConnection(constring);

                String comando = "select * from [dbo].[Menu] where id='" + en.Id + "'";

                try

                {

                    conn.Open();

                    SqlCommand cmd = new SqlCommand(comando, conn);

                    SqlDataReader dr = cmd.ExecuteReader();

                    dr.Read();

                    if (int.Parse(dr["id"].ToString()) == en.Id)

                    {

                        en.Id = int.Parse(dr["id"].ToString());

                        en.Nombre = dr["nombre"].ToString();

                        en.Precio = float.Parse(dr["precio"].ToString());

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

            public bool update(ENMenu en)

            {

                SqlConnection conn = new SqlConnection(constring);

                string comando = "UPDATE [dbo].[Menu] " + "SET nombre = '" + en.Nombre + "',  precio = " + en.Precio + "where id ='" + en.Id + "'";

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

            public bool delete(ENMenu en)

            {

                SqlConnection conn = new SqlConnection(constring); ;

                string comando = "Delete from [dbo].[Menu] where id = '" + en.Id + "'";

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

