using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageManagement.Models
{
    public class ImageViewModel
    {
        public int Id { get; set; }
        public string ImgName { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; }
        public int PA { get; set; }
        public int UA { get; set; }
        public bool Deleted { get; set; }

    }
}
