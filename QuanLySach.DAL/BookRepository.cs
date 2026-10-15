using Microsoft.EntityFrameworkCore;
using QuanLySach.DAL.Entities;

namespace QuanLySach.DAL
{
    public class BookRepository
    {
        // Tạo database + bảng nếu chưa có
        public async Task KhoiTaoDatabaseAsync()
        {
            using var db = new AppDbContext();
            await db.Database.EnsureCreatedAsync();
        }

        // 1. Lấy toàn bộ danh sách
        public async Task<List<Book>> LayDanhSachAsync()
        {
            using var db = new AppDbContext();
            return await db.Books.AsNoTracking().OrderBy(b => b.Id).ToListAsync();
        }

        // 2. Tìm theo Id
        public async Task<Book?> TimTheoIdAsync(int id)
        {
            using var db = new AppDbContext();
            return await db.Books.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
        }

        // 3. Thêm
        public async Task<Book> ThemAsync(Book book)
        {
            using var db = new AppDbContext();
            db.Books.Add(book);
            await db.SaveChangesAsync();
            return book;
        }

        // 4. Sửa (trả về false nếu không tìm thấy)
        public async Task<bool> SuaAsync(Book book)
        {
            using var db = new AppDbContext();
            var cu = await db.Books.FindAsync(book.Id);
            if (cu == null) return false;

            cu.Title = book.Title;
            cu.Author = book.Author;
            cu.Price = book.Price;
            cu.Year = book.Year;
            await db.SaveChangesAsync();
            return true;
        }

        // 5. Xóa (trả về false nếu không tìm thấy)
        public async Task<bool> XoaAsync(int id)
        {
            using var db = new AppDbContext();
            var cu = await db.Books.FindAsync(id);
            if (cu == null) return false;

            db.Books.Remove(cu);
            await db.SaveChangesAsync();
            return true;
        }
    }
}
