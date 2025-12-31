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
        private List<ItemBiblioteca> ItemBiblioteca;
        public Biblioteca()
        {
            ItemBiblioteca = new List<ItemBiblioteca>();
        }

        public void AgregarItem(ItemBiblioteca item)
        {
            ItemBiblioteca.Add(item);
        }
        public void EliminarItem(string codigoIsbn)
        {
            var item = ItemBiblioteca.FirstOrDefault(i => i.CodigoIsbn == codigoIsbn);
            if (item != null)
            {
                ItemBiblioteca.Remove(item);
            }
        }

    }
}
