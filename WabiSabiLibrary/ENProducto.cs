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
        public string crear()
        {
            
        }
}
