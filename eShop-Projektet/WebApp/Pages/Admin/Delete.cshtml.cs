using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Datalayer;
using Datalayer.Entities;

namespace WebApp.Pages.Admin
{
    public class DeleteModel : PageModel
    {
        private readonly Datalayer.EshopContext _context;

        public DeleteModel(Datalayer.EshopContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Produkt Produkt { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produkt = await _context.Produkter
                .Include(p => p.Kategori)
                .Include(p => p.Producent).FirstOrDefaultAsync(m => m.ProduktId == id);

            if (Produkt == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produkt = await _context.Produkter.FindAsync(id);

            if (Produkt != null)
            {
                _context.Produkter.Remove(Produkt);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
