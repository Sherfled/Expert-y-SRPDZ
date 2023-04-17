using System;

namespace SRP
{
    public class ShelveBook
    {
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public List<Book> Estantes = new List<Book>();
        
        public ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }


        public void AddBook(Book Libro) // Agrego los libros a la lista "Estantes"
        {
            Estantes.Add(Libro);
        }
    }
}        