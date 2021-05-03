using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{
    class ENReseña
    {
        private int id;
        private string contenido; 

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Contenido
        {
            get { return contenido; }
            set { contenido = value; }
        }
        public ENReseña()
        {
            id = 0;
            contenido = "";
        }
        public ENReseña(int id, string contenido)
        {
            this.id = id;
            this.contenido = contenido;
        }
        public ENReseña(ENReseña reseña)
        {
            this.id = reseña.id;
            this.contenido = reseña.contenido;
        }
        public bool create()
        {
            CADReseña cad = new CADReseña();
            return cad.create(this);
        }
        public bool update()
        {
            CADReseña cad = new CADReseña();
            return cad.update(this);
        }
        public bool delete()
        {
            CADReseña cad = new CADReseña();
            return cad.delete(this);
        }
        public bool read()
        {
            CADReseña cad = new CADReseña();
            return cad.read(this);
        }
    }
}
