using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewRadar.ContentManagement;
using ReviewRadar.Excepions;
using ReviewRadar.Users;

namespace ReviewRadar.MediaContent
{
    public class Media
    {

        public string Title { get; set; }
        public Person Author { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Rating { get; set; }
        public List<Review> Reviews { get; set; }
        public Media(string title, string firstName, string secondName, string description, string genre, DateTime releaseDate)
        {
            Title = title;
            Author = new(firstName ?? string.Empty, secondName ?? string.Empty);
            Description = description;
            Genre = genre;
            ReleaseDate = releaseDate;
            Rating = 0.0;
            Reviews = new();
        }


        public void AverageRating()
        {
            if (Reviews == null || Reviews.Count == 0)
            {
                throw new MediaException("No reviews for current media");
            }
            Rating = Reviews.Average(Review => Review.Rating);
        }
        public void AddReview(Review review)
        {
            if(Reviews.Any(item => item.MediaReview.Equals(review)))
            {
                Console.WriteLine("Review for this media already exists.");
                return;
            }
            Console.WriteLine("Review added.");
            Reviews.Add(review);
        }
        public void RemoveReview(Review review)
        {
            Review? reviewToDelete = Reviews.SingleOrDefault(item => item.MediaReview.Equals(review));

            if (reviewToDelete != null)
            {
                Console.WriteLine("Review removed");
                Reviews.Remove(reviewToDelete);
            }
            Console.WriteLine("Review for this media not exists.");
        }

        public void ChangeReview(string title)
        {
            try
            {
                var reviewToChange = Reviews.FirstOrDefault(item => item.MediaReview.Title.Equals(title));
                if (reviewToChange != null)
                {
                    Console.WriteLine("Do you want to change rating (yes/no)?");
                    var choose = Console.ReadLine() ?? string.Empty;
                    if (choose.ToLower() == "yes" || choose.ToLower() == "y") 
                    {
                        Console.WriteLine("Pass new rating");
                        int newRating;
                        if (int.TryParse(Console.ReadLine(), out newRating))
                        {
                            reviewToChange.Rating = newRating;
                        }
                        else
                        {
                            throw new FormatException("Wrong format");
                        }
                    }
                    Console.WriteLine("Do you want to change comment (yes/no)?");
                    choose = Console.ReadLine() ?? string.Empty;
                    if (choose.ToLower() == "yes" || choose.ToLower() == "y")
                    {
                        Console.WriteLine("Enter new comment.");
                        reviewToChange.Comment = Console.ReadLine() ?? string.Empty;
                        
                    }
                    Console.WriteLine("Review changed.");
                }
            }
            catch (MediaException)
            {
                throw;
            }
            catch(Exception)
            {
                throw;
            }
            
        }
    }
}
