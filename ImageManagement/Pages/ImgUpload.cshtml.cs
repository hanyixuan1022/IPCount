using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace ImageManagement.Pages
{
    public class ImgUploadModel : PageModel
    {
        private readonly AppSettings _appSettings;
        public ImgUploadModel(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync(List<IFormFile> files)
        {
            long size = 0;
            foreach (var file in files)
            {
                var filename = ContentDispositionHeaderValue
                        .Parse(file.ContentDisposition)
                        .FileName
                        .Trim('"');
                //将图片放在wwwroot下
               var filepath = _appSettings.ImgPath+ $@"\{filename}";
                size += file.Length;
                using (FileStream fs = System.IO.File.Create(filepath))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
                using (Context context=new Context())
                {
                    var model = context.Image.Where(t=>t.Deleted==false).Where(t => t.ImgPath == filepath).FirstOrDefault();
                    if(model==null)
                    {
                        var image = new Image
                        {
                            ImgName = filename,
                            ImgPath = filepath,
                            CreateDate=DateTime.Now
                        };
                        context.Image.Add(image);
                        context.SaveChanges();
                    }
                }
            }
            return Page();
        }
    }
}