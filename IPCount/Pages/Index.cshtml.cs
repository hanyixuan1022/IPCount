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
using Microsoft.Net.Http.Headers;
using Entity;
using System.Collections;

namespace IPCount.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public string  ImagePath{ get; set; }
        public string Description { get; set; }
        public IndexModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void OnGet()
        {
            var ip = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
            var userAgent=_httpContextAccessor.HttpContext.Request.Headers[HeaderNames.UserAgent].ToString();
            using (Context context=new Context())
            {
                var image = context.Image.Where(t=>t.Deleted==false).AsEnumerable().OrderBy(t => Guid.NewGuid()).FirstOrDefault();
                var userInfo = new UserInfo
                {
                    Ip = ip,
                    UserAgent = userAgent,
                    Image = image,
                    CreateDate = DateTime.Now

                };
                context.UserInfo.Add(userInfo);
                context.SaveChanges();
                ImagePath = "/UploadingFiles/" + image.ImgName;
                Description = image.Description;
            }
        }
    }
}
