using ReviewRadar.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewRadar.Users
{
    public interface IUser
    {
        int Id { get; set; }
        Person Person { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        List<Review> UserReviews { get; set; }
    }
}
