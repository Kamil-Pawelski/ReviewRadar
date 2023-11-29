using ReviewRadar.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewRadar.Users
{
    public class Administrator : User
    {

        public Administrator(Person person, string login, string password, string email, string phoneNumber) : base(person, login, password, email, phoneNumber)
        {
   
        }
    }
}
