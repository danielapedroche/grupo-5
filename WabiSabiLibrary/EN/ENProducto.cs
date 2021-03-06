using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{
    public class ENProducto
    {
        private int codigo;
        private string nombre;
        private string descripcion;
        private float precio;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public ENProducto()
        {
            codigo = 0;
            nombre = "";
            descripcion = "";
            precio = 0;
        }
        public ENProducto(int codigo, string nombre, string descripcion, float precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
        }
        public ENProducto(ENProducto producto)
        {
            this.codigo = producto.codigo;
            this.nombre = producto.nombre;
            this.descripcion = producto.descripcion;
            this.precio = producto.precio;
        }
        public bool create()
        {
            CADProducto cad = new CADProducto();
            return cad.create(this);
        }
        public bool update()
        {
            CADProducto cad = new CADProducto();
            return cad.update(this);
        }
        public bool delete()
        {
            CADProducto cad = new CADProducto();
            return cad.delete(this);
        }
        public bool read()
        {
            CADProducto cad = new CADProducto();
            return cad.read(this);
        }
    }
}
