using System.ComponentModel.DataAnnotations.Schema;

namespace RelationalEFCore.Models.ViewModels
{
    public class BookCategory
    {
        public int Id { get; set; }
        [ForeignKey("Categor")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book? Book { get; set; }

    }
}
