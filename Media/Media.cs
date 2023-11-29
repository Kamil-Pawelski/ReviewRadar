using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewRadar.ContentManagement;
using ReviewRadar.Users;

namespace ReviewRadar.MediaContent
{
    public class Media
    {
        private string firstName;
        private string secondName;

        public string Title { get; set; }
        public Person Author { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float Rating { get; set; }
        public List<Review> Reviews { get; set; } 
        public Media(string title, string firstName, string secondName, string description, string genre, DateTime releaseDate) 
        {
            Title = title;
            Author = new(firstName ?? string.Empty, secondName ?? string.Empty);
            Description = description;
            Genre = genre;
            ReleaseDate = releaseDate;
            Rating = 0;
            Reviews = new();
        }

        public Media(string title, string firstName, string secondName, string genre, DateTime releaseDate, int rating)
        {
            Title = title;
            this.firstName = firstName;
            this.secondName = secondName;
            Genre = genre;
            ReleaseDate = releaseDate;
            Rating = rating;
        }

        public void AverageRating()
        {
            Rating = Reviews.Sum(Review => Review.Rating) / Reviews.Count();

        }
        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }
    }
}
