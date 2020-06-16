using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=/backendPublish/mydb.db");    //创建文件夹的位置       
        }
        public DbSet<Image> Image { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
    }
}
