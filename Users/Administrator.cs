using ReviewRadar.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewRadar.Users
{
    public class Administrator : IUser
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Person Person { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Login { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PhoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Review> UserReviews { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
