using Damean_Andrei_Stefan_Lab2.Models;
namespace Damean_Andrei_Stefan_Lab2.Models.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
