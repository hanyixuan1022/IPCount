using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity
{
    public class Image
    {
        public int Id { get; set; }
        public string ImgName { get; set; }
        [Display(Name = "任务描述")]
        public string Description { get; set; }
        public string ImgPath { get; set; }
        [Display(Name = "禁用")]
        public bool Deleted { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
