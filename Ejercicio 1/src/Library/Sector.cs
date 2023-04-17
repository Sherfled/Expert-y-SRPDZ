using System;

namespace SRP
{
    public class Sector
    {
        public List<ShelveBook> Sector = new List<ShelveBook>();
            
        public void AddShelve(Book shelves) // Agrego los estantes a la lista "Sector"
        {
            Sector.Add(shelves);
        }
    }
}