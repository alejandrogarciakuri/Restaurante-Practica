using System;
namespace Project.Interfaces
{
	public interface IElementoCuenta
	{
		IPlatillo platillo { get; set; }
		int Cantidad { get; set; }
		int PrecioTotal { get; }
	}
}