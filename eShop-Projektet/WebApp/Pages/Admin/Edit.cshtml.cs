using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Datalayer;
using Datalayer.Entities;

namespace WebApp.Pages.Admin
{
    public class EditModel : PageModel
    {
        private readonly Datalayer.EshopContext _context;

        public EditModel(Datalayer.EshopContext context)
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
           ViewData["KategoriId"] = new SelectList(_context.kategorier, "kategoriId", "Navn");
           ViewData["ProducentId"] = new SelectList(_context.Producenter, "ProducentId", "Navn");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Produkt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProduktExists(Produkt.ProduktId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProduktExists(int id)
        {
            return _context.Produkter.Any(e => e.ProduktId == id);
        }
    }
}
