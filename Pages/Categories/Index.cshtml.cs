using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Damean_Andrei_Stefan_Lab2.Data;
using Damean_Andrei_Stefan_Lab2.Models;
using Damean_Andrei_Stefan_Lab2.Models.ViewModels;

namespace Damean_Andrei_Stefan_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Damean_Andrei_Stefan_Lab2Context _context;

        public IndexModel(Damean_Andrei_Stefan_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get; set; } = default!;
        public CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }
        public int BookID { get; set; }

        public async Task OnGetAsync(int? id, int? bookID)
        {
            CategoryData = new CategoryIndexData();

            // Load categories, including books and their authors through the BookCategory join entity
            CategoryData.Categories = await _context.Category
                .Include(c => c.BookCategories)
                    .ThenInclude(bc => bc.Book)
                        .ThenInclude(b => b.Author)
                .OrderBy(c => c.CategoryName)
                .ToListAsync();

            if (id != null)
            {
                CategoryID = id.Value;

                // Retrieve the selected category along with its books
                Category selectedCategory = CategoryData.Categories
                    .Where(c => c.ID == id.Value)
                    .Single();

                // Assign the books of the selected category to the ViewModel
                CategoryData.Books = selectedCategory.BookCategories
                    .Select(bc => bc.Book)
                    .ToList();
            }
        }
    }
}
