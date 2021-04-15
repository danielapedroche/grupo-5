using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{
    public class ENAlergenos
    {
        private int codigo;
        private string nombre;
        private string descripcion;
        public int Codigo
        {
            get { return codigo;  }
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
       public ENAlergenos()
        {
            codigo = 0;
            nombre = "";
            descripcion = "";
        }
        public ENAlergenos(int codigo, string nombre, string descripcion )
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        public ENAlergenos(ENAlergenos alergenos)
        {
            this.codigo = alergenos.codigo;
            this.nombre = alergenos.nombre;
            this.descripcion = alergenos.descripcion;
        }
        public bool create()
        {
            CADAlergenos cad = new CADAlergenos();
            return cad.create(this);
        }
        public bool update()
        {
            CADAlergenos cad = new CADAlergenos();
            return cad.update(this);
        }
        public bool delete()
        {
            CADAlergenos cad = new CADAlergenos();
            return cad.delete(this);
        }
        public bool read()
        {
            CADAlergenos cad = new CADAlergenos();
            return cad.read(this);
        }
    }
}
