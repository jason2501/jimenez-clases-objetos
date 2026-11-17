
using System;

namespace TecnoPunto
{
    public class Producto
    {
        public string Codigo { get; set; }

        private string nombre = string.Empty;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(
                        "El nombre no puede estar vacío.");

                nombre = value.Trim();
            }
        }

        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException(
                        "El precio debe ser mayor que 0.");

                precio = value;
            }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0)
                    throw new ArgumentException(
                        "La cantidad no puede ser negativa.");

                cantidad = value;
            }
        }

        public decimal ValorTotal
        {
            get { return Precio * Cantidad; }
        }

        public Producto(string codigo, string nombre,
                        decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: " + Precio.ToString("C2"));
            Console.WriteLine("Cantidad: " + Cantidad);
            Console.WriteLine("Valor total: " + ValorTotal.ToString("C2"));
            Console.WriteLine("----------------------------------------");
        }
    }
}

