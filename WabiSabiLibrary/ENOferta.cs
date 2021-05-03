using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{
    class ENOferta
    {
        static private int siguientecodigo = 1;
        static private int codigo;
        private int tipo;
        private string descripcion;
       
    
        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            private set { }
        }
      
        public ENOferta()
        {
            codigo = siguientecodigo++;   
            Tipo = 0;
            descripcion = "";
        }
        public ENOferta(int tipo, string descripcion) {
            codigo = siguientecodigo++;
            this.Tipo = tipo;
            this.Descripcion = descripcion;
        }
        public ENOferta (ENOferta oferta)
        {
            codigo = siguientecodigo++;
            this.Tipo = oferta.Tipo;
            this.Descripcion = oferta.Descripcion;
        }

        public void delete()
        {
            CADOferta oferta = new CADOferta();
            oferta.delete(this);
        }
        public void create()
        {
            CADOferta oferta = new CADOferta();
            oferta.create(this);
        }

        public void read()
        {
            CADOferta oferta = new CADOferta();
            oferta.read(this);
        }

        public void update()
        {
            this.Tipo = tipo;
            CADOferta oferta = new CADOferta();
            oferta.update(this);
        }
    }
}
