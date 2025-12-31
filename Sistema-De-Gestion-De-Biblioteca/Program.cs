/* Este es el punto de entrada de la aplicacion. Aqui estara un menu con las siguientes opciones:
*  1.- El menu debe ejecutarse en un bucle indefinidamente hasta que el usuario quiera salir.
*  2.- Las opciones deben ser: Ver libros, Agragar libros y Prestamo de libros.
*  3.- Condicion: Usar solamete Arreglos simples o variables para almacenar por lo menos 3 libros.
*  Importante: Validar que el usuiario no ingrese textos vacios.
*/
using Sistema_De_Gestion_De_Biblioteca.Itmes;

namespace Sistema_De_Gestion_De_Biblioteca
{
    class Program
    {
        static string ObtenerInputValido(string solicitud)
        {
            string? input = solicitud;
            while (true)
            {
                Console.WriteLine(input);
                string? respuesta = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(respuesta))
                {
                    return respuesta;
                }
                else
                {
                    Console.WriteLine("No dejes espacios en blanco");
                }
            }
        }
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

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
                        case "1": //Ver libros que hay en la 
                            Console.WriteLine("Esta es la lista de tareas");
                            if (biblioteca.ContarLibros() >= 1)
                            {
                                biblioteca.MostrarLibros();
                            }
                            else
                            {
                                Console.WriteLine("No hay libros registrados \nPresiona cualquier tecla para continuar ....");
                                Console.ReadKey();
                            }
                            Console.WriteLine("Presiona cualquier tecla para continuar ....");
                            Console.ReadKey();
                            break;

                        case "2":// Agregar libros a la biblioteca

                            if (biblioteca.ContarLibros() >= 10)
                            {
                                Console.WriteLine("No se pueden agregar mas libros, limite alcanzado. Presiona cualquier tecla para continuar...");
                                Console.ReadKey();
                                break;
                            }

                            var TituloLibro = ObtenerInputValido("Ingresa el nombre de un libro");
                            var AutorLibro = ObtenerInputValido("Ingresa el Nombre del autor");
                            var IsbnLibro = ObtenerInputValido("Ingresa el ISBN del Libro");


                            bool EstaPrestado = false;
                            Libro libro = new(TituloLibro, AutorLibro, IsbnLibro, EstaPrestado);
                            biblioteca.AlmacenarLibro(libro);
                            Console.WriteLine("Presiona cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;

                        case "3"://Prestamo de libros
                            biblioteca.MostrarLibros();
                            Console.WriteLine("Ingresa el numero del libro que deseas presatar");
                            int NumLibro = int.Parse(Console.ReadLine());
                            if (NumLibro <= biblioteca.ContarLibros())
                            {
                                biblioteca.PrestarLibro(NumLibro - 1);
                            }
                            break;

                        case "4": // salir del programa
                            running = true;
                            break;

                        default:
                            {
                                Console.WriteLine("Opcion invalida- presiona cualquier tecla para continuar");
                                Console.ReadLine();
                                break;
                            }
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