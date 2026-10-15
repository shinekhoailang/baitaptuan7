using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySach.BLL;
using QuanLySach.DAL.Entities;   // UI chỉ dùng Entity Book từ DAL, không dùng AppDbContext/BookRepository

namespace QuanLySach.UI
{
    public partial class FormQuanLySach : Form
    {
        private static readonly CultureInfo Vi = new CultureInfo("vi-VN");

        private readonly BookService _service = new BookService();

        private int _selectedId = 0;
        private bool _dangNap = false;

        // Trạng thái bộ lọc năm hiện tại
        private bool _dangLoc = false;
        private int _locTu = 0;
        private int _locDen = 0;

        public FormQuanLySach()
        {
            InitializeComponent();
        }

        private async void FormQuanLySach_Load(object sender, EventArgs e)
        {
            nudNam.Value = DateTime.Now.Year;
            nudDen.Value = DateTime.Now.Year;
            try
            {
                await _service.KhoiTaoDatabaseAsync();
                await TaiDanhSachAsync();
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
        }

        // ================= Hiển thị =================

        private async Task TaiDanhSachAsync()
        {
            List<Book> ds = _dangLoc
                ? await _service.LocSachTheoNam(_locTu, _locDen)
                : await _service.LayDanhSachAsync();
            HienThi(ds);
        }

        private void HienThi(List<Book> ds)
        {
            _dangNap = true;
            dgvSach.DataSource = ds;
            if (dgvSach.Columns.Count > 0)
            {
                dgvSach.Columns["Price"].DefaultCellStyle.Format = "N0";
                dgvSach.Columns["Price"].DefaultCellStyle.FormatProvider = Vi;
            }
            dgvSach.ClearSelection();
            dgvSach.CurrentCell = null;
            _dangNap = false;

            var dat = _service.TimSachDatNhat(ds);
            var re = _service.TimSachReNhat(ds);
            lblThongKe.Text =
                "Tổng: " + ds.Count + " cuốn | Giá TB: " + Tien(_service.TinhGiaTrungBinh(ds)) +
                " | Đắt nhất: " + (dat == null ? "— (đ)" : dat.Title + " (" + Tien(dat.Price) + ")") +
                " | Rẻ nhất: " + (re == null ? "— (đ)" : re.Title + " (" + Tien(re.Price) + ")");
        }

        private static string Tien(double v)
        {
            return v.ToString("N0", Vi) + "đ";
        }

        private void dgvSach_SelectionChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            if (dgvSach.CurrentRow?.DataBoundItem is not Book b) return;

            _selectedId = b.Id;
            txtTitle.Text = b.Title;
            txtAuthor.Text = b.Author;
            txtPrice.Text = b.Price.ToString("0.##", Vi);
            nudNam.Value = Math.Clamp(b.Year, (int)nudNam.Minimum, (int)nudNam.Maximum);
        }

        // ================= Thêm / Sửa / Xóa / Tải lại / Lọc =================

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (!DocForm(out var sach)) return;
            try
            {
                await _service.ThemAsync(sach);
                LamTrongInput();
                await TaiDanhSachAsync();
            }
            catch (ArgumentException ex)
            {
                Canh(ex.Message);
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                Canh("Vui lòng chọn cuốn sách cần sửa trong danh sách.");
                return;
            }
            if (!DocForm(out var sach)) return;
            sach.Id = _selectedId;
            try
            {
                await _service.SuaAsync(sach);
                LamTrongInput();
                await TaiDanhSachAsync();
            }
            catch (ArgumentException ex)
            {
                Canh(ex.Message);
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                Canh("Vui lòng chọn cuốn sách cần xóa trong danh sách.");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa cuốn sách này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                await _service.XoaAsync(_selectedId);
                LamTrongInput();
                await TaiDanhSachAsync();
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
        }

        private async void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                _dangLoc = false;
                nudTu.Value = 1900;
                nudDen.Value = DateTime.Now.Year;
                LamTrongInput();
                await TaiDanhSachAsync();
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
        }

        private async void btnLoc_Click(object sender, EventArgs e)
        {
            int tu = (int)nudTu.Value;
            int den = (int)nudDen.Value;
            try
            {
                var ds = await _service.LocSachTheoNam(tu, den);
                _locTu = tu;
                _locDen = den;
                _dangLoc = true;
                HienThi(ds);
            }
            catch (ArgumentException ex)
            {
                Canh(ex.Message);
            }
            catch (Exception ex)
            {
                HienLoi(ex);
            }
        }

        // ================= Hàm phụ =================

        private bool DocForm(out Book sach)
        {
            sach = new Book();
            var s = txtPrice.Text.Trim().Replace("đ", "").Trim();
            if (!double.TryParse(s, NumberStyles.Number, Vi, out var gia))
            {
                Canh("Giá phải là một số hợp lệ (ví dụ 120000).");
                txtPrice.Focus();
                return false;
            }
            sach.Title = txtTitle.Text;
            sach.Author = txtAuthor.Text;
            sach.Price = gia;
            sach.Year = (int)nudNam.Value;
            return true;
        }

        private void LamTrongInput()
        {
            _selectedId = 0;
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPrice.Clear();
            nudNam.Value = DateTime.Now.Year;
            txtTitle.Focus();
        }

        private void Canh(string msg)
        {
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void HienLoi(Exception ex)
        {
            MessageBox.Show("Lỗi: " + ex.GetBaseException().Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
