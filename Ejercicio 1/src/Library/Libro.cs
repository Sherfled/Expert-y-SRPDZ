using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        //public string LibrarySector { get ; set; }
        //public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        /*
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        */
    }


    /*public class shelve 
    {
        private ArrayList Estantes = new ArrayList;

        public void AddBook(Book Libros) // Agrego los libros a la lista "Estantes"
        {
            Estantes.Add(Libros.LibraryShelve);
        }
    }

    public class sector
    {
        public List<string> Sector = new List<string>();
            
        public void AddShelve(Book shelves) // Agrego los estantes a la lista "Sector"
        {
            this.Sector.Add(shelves.LibrarySector);
        }

    }
    */
}
