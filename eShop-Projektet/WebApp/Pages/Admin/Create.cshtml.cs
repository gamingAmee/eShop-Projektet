using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Datalayer;
using Datalayer.Entities;

namespace WebApp.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private readonly Datalayer.EshopContext _context;

        public CreateModel(Datalayer.EshopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["KategoriId"] = new SelectList(_context.kategorier, "kategoriId", "Navn");
        ViewData["ProducentId"] = new SelectList(_context.Producenter, "ProducentId", "Navn");
            return Page();
        }

        [BindProperty]
        public Produkt Produkt { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produkter.Add(Produkt);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
