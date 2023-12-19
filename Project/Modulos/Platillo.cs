using System;
using Project.Interfaces;

namespace Project.Modulos
{
    public class Platillo : IPlatillo
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El nombre del platillo no puede estar vacío o ser puros espacios en blanco.");
                }

                _nombre = value;
            }
        }

        private int _precio;
        public int Precio
        {
            get { return _precio; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("El precio del platillo siempre debe ser positivo y mayor a 0.");
                }

                _precio = value;
            }
        }

        private int _id;
        public int ID
        {
            get { return _id; }
            private set
            {
                _id = ID;
            }
        }

        public static int LastIDAdded = 0;

        public Platillo(string nombre, int precio, int id)
        {
            Nombre = nombre;
            Precio = precio;
            ID = LastIDAdded + 1;
            LastIDAdded++;
        }
    }
}