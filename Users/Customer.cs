using ReviewRadar.ContentManagement;

namespace ReviewRadar.Users
{
    public class Customer : User
    {
        int Id { get; set; }
        private static int _idCounter;
        public Customer(Person person, string login, string password, string email, string phoneNumber) 
            : base(person, login, password, email, phoneNumber) 
        {
            
        }
    }
}
