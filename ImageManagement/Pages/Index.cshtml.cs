using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entity;
using Microsoft.Extensions.Options;
using ImageManagement.Models;

namespace ImageManagement.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppSettings _appSettings;
        public IList<ImageViewModel> ImageList { get; set; }
        public int Count { get; set; }
        public string SiteUrl { get; set; }
        public IndexModel(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public void OnGet()
        {
            using (Context context=new Context())
            {
                ImageList = new List<ImageViewModel>();
                foreach (var item in context.Image.OrderBy(t=>t.Deleted).ToList())
                {
                    ImageList.Add(new ImageViewModel
                    {
                        Id = item.Id,
                        ImgName = item.ImgName,
                        Description=item.Description,
                        ImgPath = item.ImgPath,
                        Deleted = item.Deleted,
                        PA = context.UserInfo.Where(t => t.Image.Id == item.Id).ToList().Count(),
                        UA = context.UserInfo.Where(t => t.Image.Id == item.Id).
                        AsEnumerable().GroupBy(p => new { p.Ip, p.UserAgent }).
                        Select(g => g.First()).ToList().Count()
                    }); ;
                  
                }
                Count = context.UserInfo.Count();
                SiteUrl = _appSettings.SiteUrl;
            }
        }
    }
}
