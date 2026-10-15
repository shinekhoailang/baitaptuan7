using Microsoft.EntityFrameworkCore;
using QuanLySach.DAL.Entities;

namespace QuanLySach.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=LAPTOP-KEH6F2H6\MSSQLSERVER01;Database=QuanLySach;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");
            }
        }
    }
}
