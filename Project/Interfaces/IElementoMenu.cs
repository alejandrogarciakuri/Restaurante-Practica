using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Interfaces
{
    public interface IElementoMenu
    {
      string Nombre { get; set; }
    int Precio { get; set; }

        void MostrarElemento();
    }
}
