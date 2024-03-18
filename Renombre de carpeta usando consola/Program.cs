using System;
using System.IO;

namespace Programa_Fausto
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Crear carpeta");
                Console.WriteLine("2. Renombrar carpeta");
                Console.WriteLine("3. Borrar carpeta");
                Console.WriteLine("4. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CrearCarpeta();
                        break;
                    case "2":
                        RenombrarCarpeta();
                        break;
                    case "3":
                        BorrarCarpeta();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }

        static void CrearCarpeta()
        {
            Console.WriteLine("Ingrese la ruta donde desea crear la carpeta:");
            string ruta = Console.ReadLine();
            string nuevaCarpeta = Path.Combine(ruta, "Nueva carpeta creada por VS");

            try
            {
                Directory.CreateDirectory(nuevaCarpeta);
                Console.WriteLine("Carpeta creada exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear la carpeta: {ex.Message}");
            }
        }

        static void RenombrarCarpeta()
        {
            Console.WriteLine("Ingrese la ruta completa de la carpeta que desea renombrar:");
            string rutaActual = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo nombre de la carpeta:");
            string nuevoNombre = Console.ReadLine();

            try
            {
                string directorioPadre = Directory.GetParent(rutaActual).FullName;
                string nuevaRuta = Path.Combine(directorioPadre, nuevoNombre);
                Directory.Move(rutaActual, nuevaRuta);
                Console.WriteLine("Carpeta renombrada exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al renombrar la carpeta: {ex.Message}");
            }
        }

        static void BorrarCarpeta()
        {
            Console.WriteLine("Ingrese la ruta completa de la carpeta que desea borrar:");
            string ruta = Console.ReadLine();

            try
            {
                Directory.Delete(ruta, true);
                Console.WriteLine("Carpeta borrada exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al borrar la carpeta: {ex.Message}");
            }
        }
    }
}
