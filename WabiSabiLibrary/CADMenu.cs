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
        public class CADMenu
        {
	        public CADMenu()
	        {
                private string constring;

                public CADMenu()
                {
                    constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
                }

                public bool createMenu(ENMenu en)
                {
                    SqlConnection conexion = new SqlConnection(constring);
                    string comando = "Insert Into Menu (id, precio, nombre) " + "VALUES ('" + en.id + "', '" + en.precio + "', '" + en.nombre + "')";
                    try
                    {
                        conexion.Open();
                        SqlCommand cmd = new SqlCommand(comando, conexion);
                        cmd.ExecuteNonQuery();
                        conexion.Close();
                    }
                    catch (Exception e)
                    {
                        conexion.Close();
                        Console.WriteLine("Error: " + e);
                        return false;
                    }
                    return true;
                }
        }
}