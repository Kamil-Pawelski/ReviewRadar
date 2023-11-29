using ReviewRadar.ContentManagement;
using ReviewRadar.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewRadar.MediaContent
{
    public class Book : Media
    {
        public Book(string title, string firstName, string secondName, string genre, DateTime releaseDate, int rating) 
            : base(title, firstName, secondName, genre, releaseDate, rating)
        {
        }
    }
}
