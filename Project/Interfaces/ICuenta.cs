﻿using System;
using Project.Modulos;
namespace Project.Interfaces
{
	public interface ICuenta
	{
		List<ElementoCuenta> Elementos { get; set; }

		int Total { get; }

		void AregarElemento(Platillo platillo, int cantidad);

		void MostrarCuenta();
	}
}

