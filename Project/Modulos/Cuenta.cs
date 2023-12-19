using System;
using Project.Interfaces;
namespace Project.Modulos
{
	public class Cuenta : ICuenta
	{
		private List<ElementoCuenta> Elementos;

		public int Total
		{
			get
			{
				int total = 0;

				foreach (ElementoCuenta elemento in Elementos)
				{
					total += elemento.PrecioTotal;
				}

				return total;
			}
		}

        List<ElementoCuenta> ICuenta.Elementos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AregarElemento(Platillo platillo, int cantidad)
		{
			foreach (var elemento in Elementos)
			{
				if (elemento.platillo.ID == platillo.ID)
				{
					elemento.Cantidad += cantidad;
					return;
				}

				Elementos.Add(new ElementoCuenta(platillo, cantidad));
			}
		}

		public void MostrarCuenta()
		{
			foreach (var elemento in Elementos)
			{
				Console.WriteLine($"{elemento.platillo.Nombre}. Cant: {elemento.Cantidad}. Total: ${elemento.PrecioTotal}");
			}
        }

		public Cuenta()
		{
			Elementos = new List<ElementoCuenta>();
		}
	}
}