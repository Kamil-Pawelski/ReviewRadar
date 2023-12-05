using ReviewRadar.MediaContent;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewRadar.ContentManagement
{
    public class Review
    {
        public Media MediaReview { get; set; }
        private int _rating;
        public int Rating
        {
            get => _rating;
            set => _rating = (value >= 1 && value <= 10) ? value : throw new ArgumentOutOfRangeException();
        }
        public string Comment { get; set; }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {

            if (obj == null) throw new ArgumentNullException();

            if (obj is Review otherReview)
            {
                return otherReview.MediaReview.Equals(this.MediaReview);
            }
            Console.WriteLine("Wrong parameter.");
            return false;
        }

        public override int GetHashCode()
        {
            return (MediaReview != null) ? MediaReview.GetHashCode() : 0;
        }
    }
}
