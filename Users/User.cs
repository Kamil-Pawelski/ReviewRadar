using ReviewRadar.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewRadar.Users
{
    public class User
    {
        
        Person Person { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        List<Review> UserReviews { get; set; } = new();

        public User(Person person, string login, string password, string email, string phoneNumber) 
        {
            Person = person;
            Login = login;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
