using RelationalEFCore.Models.ViewModels;

namespace RelationalEFCore.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string? BookTitle { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
