using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewRadar.ContentManagement;
using ReviewRadar.Users;
namespace ReviewRadar.Media
{
    public interface IMedia
    {
        string Title { get; set; }
        Person Author { get; set; }
        string Description { get; set; }
        string Genre { get; set; }
        DateTime ReleaseDate { get; set; }
        byte Rating { get; set; }
        List<Review> Reviews { get; set; }
    }
}
