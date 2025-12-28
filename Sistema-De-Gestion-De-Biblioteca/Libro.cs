using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 *  Esta clase libro se creo con el objetivo de crear el objeto libro, con los siguientes metodos:
 *  -Guardar Libro (Este metodo exporta los datos necesarios para almacenar en la clase Biblioteca)
 *  -
 * 
 */
namespace Sistema_De_Gestion_De_Biblioteca
{
    internal class Libro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public string Isbn { get; private set; }
        public bool EstaPrestado { get; set; }

        public Libro(string titulo, string autor, string isbn, bool estaPrestado)
        {
            Titulo = titulo;
            Autor = autor;
            Isbn = isbn;
            EstaPrestado = estaPrestado;
        }

    }
}