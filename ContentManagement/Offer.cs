using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewRadar.Media;
namespace ReviewRadar.ContentManagement
{
    public static class Offer
    {
        public static void AddMedia(IMedia media)
        {
            if (media == null) throw new ArgumentNullException();
            if (media is Book)
            {
                //ListName.Add((book)media));
            }
            else if (media is Game)
            {

            }
            else if(media is Song)
            {

            }
            else if(media is TVSeries) 
            {

            }
            else
            {
                
            }
        }

        public static void RevomeMedia(IMedia media)
        {
            if (media == null) throw new ArgumentNullException();
            if (media is Book)
            {
                //ListName.Remove((book)media));
            }
            else if (media is Game)
            {

            }
            else if (media is Song)
            {

            }
            else if (media is TVSeries)
            {

            }
            else
            {

            }
        }

        public static void GetOffer()
        {
            //Zwraca wszystko lub po okreslonych filtrach
        }

        public static List<IMedia> FindWithTitle()
        {
            
            return new List<IMedia>();
        }

        public static IMedia FindWithMedia()
        {
            return new Book();
        }
    }
}
