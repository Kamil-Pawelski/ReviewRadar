using ReviewRadar.ContentManagement;

namespace ReviewRadar.Users
{
    public class Customer : IUser
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
