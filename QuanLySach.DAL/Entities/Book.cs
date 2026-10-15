using System.ComponentModel.DataAnnotations;

namespace QuanLySach.DAL.Entities
{
    public class Book
    {
        public int Id { get; set; }                         // khóa chính, tự tăng

        [Required]
        public string Title { get; set; } = "";             // tên sách (bắt buộc)

        [Required]
        public string Author { get; set; } = "";            // tác giả (bắt buộc)

        public double Price { get; set; }                   // giá bán

        public int Year { get; set; }                       // năm xuất bản
    }
}
