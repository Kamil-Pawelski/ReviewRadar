using ReviewRadar.MediaContent;
using ReviewRadar.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReviewRadar.ContentManagement
{
    public class DataManagement
    {
        public List<Book> Books { get; set; } = new ();
        public List<Song> Songs { get; set; } = new ();
        public List<TVSeries> TVSeries { get; set; } = new ();
        public List<Movie> Movies { get; set; } = new ();
        public List<Game> Games { get; set; } = new ();
        public List<Customer> customers { get; set; } = new();
        public string DirectoryName { get; set; }
        
        public DataManagement()
        {
   

        }
        public void WriteToFile()
        {
            var jsonSerializer = JsonSerializer.Serialize(Books);
            //using StreamWriter writer = new StreamWriter() { };
        }

        public void ReadFromFile()
        {

        }

    }
}
