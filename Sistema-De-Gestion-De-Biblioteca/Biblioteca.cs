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
        private List<Libro> ListaDeLibros { get; set; }
        public Biblioteca()
        {
            ListaDeLibros = new List<Libro>();
        }

        public void AlmacenarLibro(Libro libro)
        {
            ListaDeLibros.Add(libro);
        }

        public List<Libro> AccederLibros()
        {
            return ListaDeLibros;
        }

    }
}
