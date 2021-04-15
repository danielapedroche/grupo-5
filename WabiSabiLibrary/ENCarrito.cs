using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{
    public class ENCarrito
    {
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _id;

        public ENCarrito()
        {
            this._id = -1;
        }

        public ENCarrito(int id)
        {
            this._id = id;
        }

        public bool createCarrito()
        {
            CADCarrito cad = new CADCarrito();
            return cad.createCarrito(this);
        }
        public bool readCarrito()
        {
            CADCarrito cad = new CADCarrito();
            cad.readCarrito(this);
        }
        public bool updateCarrito()
        {
            CADCarrito cad = new CADCarrito();
            return cad.updateCarrito(this);

        }
        public bool deleteCarrito()
        {
            CADCarrito cad = new CADCarrito();
            cad.deleteCarrito(this);
        }
    }
}
