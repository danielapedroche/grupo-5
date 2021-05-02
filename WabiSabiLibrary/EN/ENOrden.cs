using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{
    class ENOrden
    {
        private int id;
        private string descripcion;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public ENOrden()
        {
            id = 0;
            descripcion = "";
        }
        public ENOrden(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }
        public ENOrden(ENReseña reseña)
        {
            this.id = orden.id;
            this.descripcion = orden.descripcion;
        }
        public bool create()
        {
            CADOrden cad = new CADOrden();
            return cad.create(this);
        }
        public bool update()
        {
            CADOrden cad = new CADOrden();
            return cad.update(this);
        }
        public bool delete()
        {
            CADOrden cad = new CADOrden();
            return cad.delete(this);
        }
        public bool read()
        {
            CADOrden cad = new CADOrden();
            return cad.read(this);
        }
    }
}