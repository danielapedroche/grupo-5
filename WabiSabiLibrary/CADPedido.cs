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
    }
}
