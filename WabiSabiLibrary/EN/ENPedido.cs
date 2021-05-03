using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{
    public class ENPedido
    {
        public float Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private DateTime _fecha;
        private string _direccion;
        private string _estado;
        private int _id;
        private float _precio;

        public ENPedido()
        {
            this._fecha = new DateTime();
            this._direccion = "";
            this._estado = "";
            this._id = -1;
            this._precio = 0.0F;

        }

        public ENPedido(int id, DateTime fecha, int precio, string direccion, string estado)
        {
            this._fecha = fecha;
            this._direccion = direccion;
            this._estado = estado;
            this._id = id;
            this._precio = precio;
        }

        public bool createPedido()
        {
            CADPedido cad = new CADPedido();
            return cad.createPedido(this);
        }
        public void readPedido()
        {
            CADPedido cad = new CADPedido();
            cad.readPedido(this);
        }
        public bool updatePedido()
        {
            CADPedido cad = new CADPedido();
            return cad.updatePedido(this);

        }
        public void confirmPedido()
        {
            CADPedido cad = new CADPedido();
            cad.confirmPedido(this);
        }
        public void deletePedido()
        {
            CADPedido cad = new CADPedido();
            cad.deletePedido(this);
        }
    }
}
