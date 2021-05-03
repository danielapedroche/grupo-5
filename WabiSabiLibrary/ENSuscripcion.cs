using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{
    class ENSuscripcion
    {
        private int id;
        private string tipo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public ENSuscripcion()
        {
            id = 0;
            tipo = "";
        }
        public ENSuscripcion(int id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
        }
        public bool create()
        {
            CADSuscripcion cad = new CADSuscripcion();
            return cad.create(this);
        }
        public bool update()
        {
            CADSuscripcion cad = new CADSuscripcion();
            return cad.update(this);
        }
        public bool delete()
        {
            CADSuscripcion cad = new CADSuscripcion();
            return cad.delete(this);
        }
        public bool read()
        {
            CADSuscripcion cad = new CADSuscripcion();
            return cad.read(this);
        }
    }
}
