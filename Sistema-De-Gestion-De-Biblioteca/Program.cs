/* Este es el punto de entrada de la aplicacion. Aqui estara un menu con las siguientes opciones:
*  1.- El menu debe ejecutarse en un bucle indefinidamente hasta que el usuario quiera salir.
*  2.- Las opciones deben ser: Ver libros, Agragar libros y Prestamo de libros.
*  3.- Condicion: Usar solamete Arreglos simples o variables para almacenar por lo menos 3 libros.
*  Importante: Validar que el usuiario no ingrese textos vacios.
*/
namespace SistemaSGB
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] libros = new string[0];
            bool running = false;

            while (!running)
            {
                Console.Clear();
                Console.WriteLine("Bievenidos Al gestor de biblioteca \n");
                Console.WriteLine("1. Ver Libros");
                Console.WriteLine("2. Agregar Libros");
                Console.WriteLine("3. Prestamo de libros");
                Console.WriteLine("4. Salir.");
                Console.Write("Seleccione una opción: ");
                string? option = Console.ReadLine();


                if (option != null)
                {
                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("Esta es la lista de tareas");
                            if (libros.Length > 0)
                            {
                                for (int i = 0; i < libros.Length; i++)
                                {
                                    Console.WriteLine($"{i + 1} {libros[i]}");
                                }
                                Console.WriteLine("Presione cualquier tecla para continuar...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("No hay tareas por listar");
                            }
                            break;
                        case "2":
                            if (libros.Length >= 3)
                            {
                                Console.WriteLine("No se pueden agregar mas libros, limite alcanzado. Presiona cualquier tecla para continuar...");
                                Console.ReadKey();
                                break;
                            }
                            Console.WriteLine("Ingresa el nombre de un libro");
                            string? NuevoLibro = Console.ReadLine();
                            int NuevoEspacio = libros.Length + 1;
                            Array.Resize(ref libros, NuevoEspacio);
                            libros[NuevoEspacio - 1] = NuevoLibro;
                            Console.WriteLine($"Libro añadido {NuevoLibro}. El arreglo ahora tiene {libros.Length} elementos.");
                            break;
                        case "3":
                            for (int i = 0; i < libros.Length; i++)
                            {
                                Console.WriteLine($"{i + 1} {libros[i]}");

                                Console.WriteLine("Ingrea el numero del libro a prestar");
                                string? Numlibro = Console.ReadLine();
                                if (Numlibro != null)
                                {
                                for (int j = 0; j < libros.Length; i++)
                                {

                                    if (libros[j] == libros[int.Parse(Numlibro) - 1])
                                    {
                                        libros[j] += " (Prestado)";
                                        Console.WriteLine($"Has prestado el libro: {libros[j]}. Presiona cualquier tecla para continuar...");
                                        Console.ReadKey();
                                        break;
                                    }

                                }

                                }
                                else
                                {
                                    Console.WriteLine("Respuesta invalida- presiona cualquier tecla para continuar");
                                }
                    }
                    break;

                        case "4":
                        running = true;
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Respuesta invalida- presiona cualquier tecla para continuar");
                    Console.ReadLine();
                }


            }
        }
    }
}