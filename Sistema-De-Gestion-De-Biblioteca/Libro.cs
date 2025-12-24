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
        private required string _titulo { get; set; }
        private required string _autor { get; set; }
        private required string _isbn { get; set; }
        private required bool EstaPrestado { get; set; }

        public Libro()
        {
            _titulo = _titulo;
            _autor = _autor;
            _isbn = _isbn;
            EstaPrestado = EstaPrestado;
        }

        public string GetTitulo()
        {
            return _titulo;
        }
        public void SetTitulo(string titulo)
        {
            _titulo = titulo;
        }
        public string GetAutor()
        {
            return _autor;
        }
        public void SetAutor(string autor)
        {
            _autor = autor;
        }
        public string GetIsbn()
        {
            return _isbn;
        }
        public void SetIsbn(string isbn)
        {
            _isbn = isbn;
        }
        public bool GetEstaPrestado()
        {
            return EstaPrestado;
        }
        public void SetEstaPrestado(bool estaPrestado)
        {
            EstaPrestado = estaPrestado;
        }
    }
}