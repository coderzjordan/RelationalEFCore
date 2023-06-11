using Microsoft.EntityFrameworkCore;
using RelationalEFCore.Models;
using RelationalEFCore.Models.ViewModels;

namespace RelationalEFCore.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCategory>().HasKey(bc => new {bc.BookId,bc.CategoryId });
            modelBuilder.Entity<BookCategory>().
                HasOne(bc => bc.Book).WithMany(b => b.BookCategories).HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookCategory>().
             HasOne(bc => bc.Category).WithMany(b => b.BookCategories).HasForeignKey(bc => bc.CategoryId);

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
       public DbSet<BookCategory> BookCategories { get; set; }

    }
}
