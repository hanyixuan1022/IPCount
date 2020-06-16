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
using Microsoft.EntityFrameworkCore;

namespace ImageManagement.Pages
{
    public class ImgDeleteModel : PageModel
    {
        [BindProperty]
        public Image Image { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            using (Context context = new Context())
            {
                Image = await context.Image.FirstOrDefaultAsync(m => m.Id == id);
            }

            if (Image == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            using (Context context = new Context())
            {
                context.Attach(Image).State = EntityState.Modified;

                try
                {
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImageExists(Image.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return RedirectToPage("./Index");
        }
        private bool ImageExists(int id)
        {
            using (Context context = new Context())
            {
                return context.Image.Any(e => e.Id == id);
            }
        }
    }
}
