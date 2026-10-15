using QuanLySach.DAL;
using QuanLySach.DAL.Entities;

namespace QuanLySach.BLL
{
    public class BookService
    {
        private readonly BookRepository _repo;

        public BookService() : this(new BookRepository()) { }

        public BookService(BookRepository repo)
        {
            _repo = repo;
        }

        // ===== Validate nghiệp vụ =====
        private static void Validate(Book b)
        {
            if (b == null)
                throw new ArgumentNullException(nameof(b));
            if (string.IsNullOrWhiteSpace(b.Title))
                throw new ArgumentException("Tên sách (Title) không được để trống.");
            if (string.IsNullOrWhiteSpace(b.Author))
                throw new ArgumentException("Tác giả (Author) không được để trống.");
            if (double.IsNaN(b.Price) || double.IsInfinity(b.Price) || b.Price <= 0)
                throw new ArgumentException("Giá (Price) phải lớn hơn 0.");

            int namHienTai = DateTime.Now.Year;
            if (b.Year < 1000 || b.Year > namHienTai)
                throw new ArgumentException($"Năm xuất bản (Year) phải từ 1000 đến {namHienTai}.");

            b.Title = b.Title.Trim();
            b.Author = b.Author.Trim();
        }

        // ===== CRUD (qua Repository) =====
        public Task KhoiTaoDatabaseAsync() => _repo.KhoiTaoDatabaseAsync();

        public Task<List<Book>> LayDanhSachAsync() => _repo.LayDanhSachAsync();

        public Task<Book?> TimTheoIdAsync(int id) => _repo.TimTheoIdAsync(id);

        public async Task<Book> ThemAsync(Book book)
        {
            Validate(book);
            return await _repo.ThemAsync(book);
        }

        public async Task SuaAsync(Book book)
        {
            Validate(book);
            if (!await _repo.SuaAsync(book))
                throw new InvalidOperationException("Không tìm thấy sách cần sửa.");
        }

        public async Task XoaAsync(int id)
        {
            if (!await _repo.XoaAsync(id))
                throw new InvalidOperationException("Không tìm thấy sách cần xóa.");
        }

        // ===== Thống kê =====
        public double TinhGiaTrungBinh(List<Book> ds)
        {
            if (ds == null || ds.Count == 0) return 0;
            return ds.Average(b => b.Price);
        }

        public async Task<List<Book>> LocSachTheoNam(int namBatDau, int namKetThuc)
        {
            if (namBatDau > namKetThuc)
                throw new ArgumentException("Năm bắt đầu không được lớn hơn năm kết thúc.");

            var ds = await _repo.LayDanhSachAsync();
            return ds.Where(b => b.Year >= namBatDau && b.Year <= namKetThuc).ToList();
        }

        public Book? TimSachDatNhat(List<Book> ds)
        {
            if (ds == null || ds.Count == 0) return null;
            return ds.OrderByDescending(b => b.Price).First();
        }

        public Book? TimSachReNhat(List<Book> ds)
        {
            if (ds == null || ds.Count == 0) return null;
            return ds.OrderBy(b => b.Price).First();
        }
    }
}
