using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{
    public class ENUsuario
    {
        private string nif;
        private string email;
        private string contrasenya;
        private string nombre;
        private string apellidos;
        private string telefono;
        private string direccion;
        private DateTime fechaNac;


        public int Nif
        {
            get { return nif; }
            set { nif = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Contrasenya
        {
            get { return contrasenya; }
            set { contrasenya = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set {apellidos = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public DateTime Fechanac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }
        public ENUsuario()
        {
             nif = "";
            email = "";
            contrasenya = "";
            nombre = "";
            apellidos = "";
            telefono = "";
            direccion = "";
            fechaNac = "";
        }
        public ENUsuario(string nif, string email, string contrasenya, string nombre, string apellidos, string telefono, string direccion, DateTime fechaNac)
        {
            this.nif = nif;
            this.email = email;
            this.contrasenya = contrasenya;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
            this.fechaNac = fechaNac;
    }
        public ENUsuario(ENUsuario usuario)
        {
            this.nif = usuario.nif;
            this.email = usuario.email;
            this.contrasenya = usuario.contrasenya;
            this.nombre = usuario.nombre;
            this.apellidos = usuario.apellidos;
            this.telefono = usuario.telefono;
            this.direccion = usuario.direccion;
            this.fechaNac = usuario.fechaNac;
        }
        public bool create()
        {
            CADUsuariocad = new CADUsuario();
            return cad.create(this);
        }
        public bool update()
        {
            CADUsuario cad = new CADUsuario();
            return cad.update(this);
        }
        public bool delete()
        {
            CADUsuario cad = new CADUsuario();
            return cad.delete(this);
        }
        public bool read()
        {
            CADUsuario cad = new CADUsuario();
            return cad.read(this);
        }
    }
}
