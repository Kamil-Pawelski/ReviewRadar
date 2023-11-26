using ReviewRadar.Media;
using ReviewRadar.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewRadar.ContentManagement
{
    public class Data
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Song> Songs { get; set; } = new List<Song>();
        public List<TVSeries> TVSeries { get; set; } = new List<TVSeries>();
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<Game> Games { get; set; } = new List<Game>();
        public List<Customer> customers { get; set; }

        public void WriteToFile()
        {

        }

        public void ReadFromFile()
        {

        }

    }
}
