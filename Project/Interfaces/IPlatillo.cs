using System;
namespace Project.Interfaces
{
	public interface IPlatillo
    {
		string Nombre { get; set; }
        int Precio { get; set; }
        int ID { get; }
    }
}