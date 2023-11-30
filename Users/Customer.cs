using ReviewRadar.ContentManagement;
using ReviewRadar.MediaContent;

namespace ReviewRadar.Users
{
    public class Customer : User
    {
        int Id { get; set; }
        private static int _idCounter = 0;
        List<Review> UserReviews { get; set; } = new();
        public Customer(Person person, string login, string password, string email, string phoneNumber) 
            : base(person, login, password, email, phoneNumber) 
        {
            Id = ++_idCounter;
        }

        public void addReview (Review review)
        {
            var media = UserReviews.Select(m => m.MediaReview);
            var currentMedia = review.MediaReview;
            if(media)
            UserReviews.Add(review);
        }

        public void removeReview (Review review)
        {
            //exist
            UserReviews.Remove(review);
        }
    }
}
