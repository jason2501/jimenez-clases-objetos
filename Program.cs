
using System;

namespace TecnoPunto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("     CONTROL DE INVENTARIO - TECNOPUNTO");
            Console.WriteLine("========================================");
            Console.WriteLine();

            // Creamos tres objetos de la clase Producto.
            Producto producto1 = LeerProducto(1);
            Producto producto2 = LeerProducto(2);
            Producto producto3 = LeerProducto(3);

            // Mostramos los productos registrados.
            Console.WriteLine();
            Console.WriteLine("========== INVENTARIO REGISTRADO ==========");

            producto1.MostrarInfo();
            producto2.MostrarInfo();
            producto3.MostrarInfo();

            Console.WriteLine("Proceso terminado.");
            Console.ReadKey();
        }

        static Producto LeerProducto(int numero)
        {
            while (true)
            {
                Console.WriteLine("Registro del producto #" + numero);

                Console.Write("Código: ");
                string codigo = Console.ReadLine() ?? "";

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine() ?? "";

                decimal precio = LeerDecimal("Precio: ");
                int cantidad = LeerEntero("Cantidad: ");

                try
                {
                    Producto nuevoProducto = new Producto(
                        codigo, nombre, precio, cantidad);

                    Console.WriteLine(
                        "Producto registrado correctamente.");
                    Console.WriteLine();

                    return nuevoProducto;
                }
                catch (ArgumentException error)
                {
                    Console.WriteLine(
                        "Dato inválido: " + error.Message);

                    Console.WriteLine(
                        "Vuelva a introducir los datos.");
                    Console.WriteLine();
                }
            }
        }

        static decimal LeerDecimal(string mensaje)
        {
            decimal valor;

            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine() ?? "";

                if (decimal.TryParse(entrada, out valor))
                {
                    return valor;
                }

                Console.WriteLine(
                    "Entrada incorrecta. Escriba un número válido.");
            }
        }

        static int LeerEntero(string mensaje)
        {
            int valor;

            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine() ?? "";

                if (int.TryParse(entrada, out valor))
                {
                    return valor;
                }

                Console.WriteLine(
                    "Entrada incorrecta. Escriba un número entero.");
            }
        }
    }
}
