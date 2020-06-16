using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Entity;
using Microsoft.Extensions.Options;
using ImageManagement.Models;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace ImageManagement.Pages
{
    public class IPDetailsModel : PageModel
    {
        public IPagedList<UserInfo> UserInfos { get; set; }
        public IList<IPViewModel> IPList { get; set; }
        public int PageSize { get; set; }
        public int TotalItemCount { get; set; }
        public int PageCount { get; set; }
        public int PageNumber { get; set; }
        public int Count { get; set; }
        public void OnGet(int? id, int? pageIndex, int pageSize = 5)
        {
            using (Context context=new Context())
            {
                var userInfo = context.UserInfo.Include(x => x.Image).Where(t => t.Image.Id == id);
                var page = pageIndex ?? 1;
                PageSize = pageSize;
                TotalItemCount = userInfo.Count();
                PageCount = TotalItemCount % PageSize==0? TotalItemCount / PageSize: TotalItemCount / PageSize+1;
                Count= userInfo.ToPagedList(page, pageSize).Count();
                PageNumber = page;
                UserInfos = userInfo.OrderByDescending(t=>t.CreateDate).ToPagedList(page, pageSize);
               IPList= userInfo.GroupBy(p=>p.Ip).Select(g=>new  IPViewModel{IP=g.Key,Count=g.Count() }).OrderByDescending(t=>t.Count).ToList();
            }
        }
    }
}
