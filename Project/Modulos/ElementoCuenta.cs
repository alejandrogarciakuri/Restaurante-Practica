using System;
using Project.Interfaces;
namespace Project.Modulos
{
	public class ElementoCuenta : IElementoCuenta
	{
        public IPlatillo platillo { get; set; }

        public int Cantidad { get; set; }

		public int PrecioTotal
		{
			get { return this.platillo.Precio * Cantidad; }
		}

		public ElementoCuenta(Platillo platillo, int cantidad)
		{
			this.platillo = platillo;
			this.Cantidad = cantidad;
		}
	}
}

