﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Damean_Andrei_Stefan_Lab2.Models;

namespace Damean_Andrei_Stefan_Lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Damean_Andrei_Stefan_Lab2.Data.Damean_Andrei_Stefan_Lab2Context _context;

        public DetailsModel(Damean_Andrei_Stefan_Lab2.Data.Damean_Andrei_Stefan_Lab2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book
                .Include(b => b.Author)  // Include Author
                .Include(b => b.BookCategories)  // Include BookCategories
                    .ThenInclude(bc => bc.Category)  // Include related Categories
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
