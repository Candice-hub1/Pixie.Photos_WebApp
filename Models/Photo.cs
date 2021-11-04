using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PixiePhotos_WebApp.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime uploadDate { get; set; }
        public int View { get; set; }
        public string ImagePath { get; set; }

        public Photo()
        {

        }
    }
}
