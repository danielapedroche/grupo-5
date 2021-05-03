using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{
    class ENMenu
    {
        private int id;
        private string nombre;
        private float precio;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public ENMenu()
        {
            id = 0;
            nombre = "";
            precio = 0;
        }
        public ENMenu(int id, string nombre, float precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
        }
        public ENMenu(ENMenu producto)
        {
            this.id = producto.id;
            this.nombre = producto.nombre;
            this.precio = producto.precio;
        }
        public bool create()
        {
            CADMenu cad = new CADMenu();
            return cad.create(this);
        }
        public bool update()
        {
            CADMenu cad = new CADMenu();
            return cad.update(this);
        }
        public bool delete()
        {
            CADMenu cad = new CADMenu();
            return cad.delete(this);
        }
        public bool read()
        {
            CADMenu cad = new CADMenu();
            return cad.read(this);
        }
    }
}

