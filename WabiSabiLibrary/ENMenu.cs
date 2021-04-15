using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WabiSabiLibrary
{
	public class ENMenu
	{
		public class ENMenu()
			{
				private int id;
		private float precio;
		private string nombre;

		public int id
		{
			get { return id; }
			set { id = value; }
		}


		public float precio
		{
			get { return precio; }
			set { precio = value; }
		}

		public string nombre
		{
			get { return estado; }
			set { nombre = value; }
		}

		public ENMenu()
		{
			id = 0;
			precio = 0.0;
			nombre = "";
		}

		public ENMenu(int id, float precio, string nombre)
		{
			this.id = id;
			this.precio = precio;
			this.direccion = nombre;
		}

		public void create()
		{
			CADMenu cad = new CADMenu();
			cad.create(this);
		}

		public void delete()
		{
			CADMenu cad = new CADMenu();
			cad.delete(this);
		}

		public void update()
		{
			CADMenu cad = new CADMenu();
			cad.update(this);
		}
	}
}
