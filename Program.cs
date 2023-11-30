using ReviewRadar.ContentManagement;
using ReviewRadar.MediaContent;
using ReviewRadar.Users;

namespace ReviewRadar
{
    class Program
    {
        static void Main()
        {
            Data data = new();
            Customer customer = new(new Person("Kamil", "Kowal"),"Kaczka123","haselko123", "kulaunogi@wp.pl", "500-532-213");
            Book book = new("Harry potta", "Alfred", "Haws", "film o kihy", "Dramat", new DateTime(2001, 5, 23));
            Review review = new Review() { MediaReview = book, Rating = 7, Comment = "Cudo" };
            customer.addReview(review);
        }
    }
}