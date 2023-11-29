using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewRadar.ContentManagement
{
    public struct Review
    {
        private int _rating;
        public int Rating
        { 
            readonly get => _rating;
            set => _rating = (value >= 1 && value <= 10) ? value : throw new ArgumentOutOfRangeException();
        }
        public string Comment { get; set; }
    }
}
