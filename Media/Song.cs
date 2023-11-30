using ReviewRadar.ContentManagement;
using ReviewRadar.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewRadar.MediaContent
{
    public class Song : Media
    {
        public Song(string title, string firstName, string secondName, string description, string genre, DateTime releaseDate)
            : base(title, firstName, secondName, description, genre, releaseDate)
        {
        }
    }
}
