using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            //book1.ShelveBook("A","7");
            //book2.ShelveBook("B","3");

            ShelveBook Estanteria = new ShelveBook("A", "7");
            Estanteria.AddBook(Book1); // Creo que me da error, porque no me deja crear la Lista de libros
            
            ShelveBook Estanteria2 = new ShelveBook("B", "3");
            Estanteria.AddBook(book2); // Creo que me da error, porque no me deja crear la Lista de libros
            
            Sector sector = new Sector();
            sector.AddShelve(Estanteria); // Tampoco me deja crear la Lista        

            Sector sector2 = new Sector();
            sector2.AddShelve(Estanteria2); // Tampoco me deja crear la Lista        
        
        }
    }
}