using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string UserAgent { get; set; }
        public Image Image { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
