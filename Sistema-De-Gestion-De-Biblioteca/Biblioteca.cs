using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  La funcion de esta clase es de gestionar la biblioteca con los siguientes metodos:
 *  
 *  -Alamcenar libros
 *  -Acceder a los libros
 *  -Eliminar libros
 *  -Modificar un libro
 *  
 */
namespace Sistema_De_Gestion_De_Biblioteca
{
    internal class Biblioteca
    {
        private List<Libro> ListaDeLibros;
        public Biblioteca()
        {
            ListaDeLibros = new List<Libro>();
        }

        public void AlmacenarLibro(Libro libro)
        {
            if (string.IsNullOrWhiteSpace(libro.Titulo) || string.IsNullOrWhiteSpace(libro.Isbn) || string.IsNullOrWhiteSpace(libro.Autor))
            {

                Console.WriteLine("No dejes en blanco los datos");
                return;
            }
                ListaDeLibros.Add(libro);
          
        }

        public void MostrarLibros()
        {
            int index = 1;
            foreach (var libro in ListaDeLibros)
            {
                Console.WriteLine($"{index}.- Título: {libro.Titulo}\nAutor: {libro.Autor}\nISBN: {libro.Isbn}\nPrestado: {(libro.EstaPrestado ? "Prestado" : "Disponible")}");
                index++;
            }
        }

        public void EliminarLibro(Libro libro)
        {
            ListaDeLibros.Remove(libro);
        }

        public int ContarLibros()
        {
            return ListaDeLibros.Count();
        }
        public void PrestarLibro(int index)
        {
            if(index < 0 || index >= ListaDeLibros.Count)
            {
                Console.WriteLine("Índice de libro inválido.");
                return;
            }
            if(ListaDeLibros[index].EstaPrestado)
            {
                Console.WriteLine("El libro ya está prestado.");
                return;
            }
            ListaDeLibros[index].EstaPrestado = true;
        }
    }
}
