using ReviewRadar.MediaContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ReviewRadar.ContentManagement
{
    public static class Offer
    {
        public static void AddMedia(Media media)
        {
            if (media == null) throw new ArgumentNullException(nameof(media), "Argument 'media' nie może być null.");
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

        public static void RevomeMedia(MediaContent.Media media)
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

        public static List<MediaContent.Media> FindWithTitle()
        {
            
            return new List<MediaContent.Media>();
        }

        public static MediaContent.Media FindWithMedia()
        {
            Book? book = null; //Tylko żeby pozbyć się warningów
            return book!;
        }
    }
}
