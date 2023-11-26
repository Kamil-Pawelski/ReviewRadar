using ReviewRadar.ContentManagement;
using ReviewRadar.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewRadar.Media
{
    public class Game : IMedia
    {
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Person Author { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Genre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ReleaseDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte Rating { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Review> Reviews { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
