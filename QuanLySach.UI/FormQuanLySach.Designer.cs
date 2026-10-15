#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace QuanLySach.UI
{
    partial class FormQuanLySach
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.lblLoc = new System.Windows.Forms.Label();
            this.nudTu = new System.Windows.Forms.NumericUpDown();
            this.lblDen = new System.Windows.Forms.Label();
            this.nudDen = new System.Windows.Forms.NumericUpDown();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.lblThongKe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(0, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(860, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ SÁCH - KIẾN TRÚC 3 TẦNG (3 PROJECT)";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(20, 63);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.TabIndex = 1;
            this.lblTenSach.Text = "Tên sách:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(85, 60);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(250, 23);
            this.txtTitle.TabIndex = 2;
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(360, 63);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.TabIndex = 3;
            this.lblTacGia.Text = "Tác giả:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(420, 60);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(230, 23);
            this.txtAuthor.TabIndex = 4;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(670, 63);
            this.lblGia.Name = "lblGia";
            this.lblGia.TabIndex = 5;
            this.lblGia.Text = "Giá:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(705, 60);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(135, 23);
            this.txtPrice.TabIndex = 6;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(20, 103);
            this.lblNam.Name = "lblNam";
            this.lblNam.TabIndex = 7;
            this.lblNam.Text = "Năm XB:";
            // 
            // nudNam
            // 
            this.nudNam.Location = new System.Drawing.Point(85, 100);
            this.nudNam.Maximum = new decimal(new int[] {9999, 0, 0, 0});
            this.nudNam.Minimum = new decimal(new int[] {1000, 0, 0, 0});
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(70, 23);
            this.nudNam.TabIndex = 8;
            this.nudNam.Value = new decimal(new int[] {2024, 0, 0, 0});
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(175, 98);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 28);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "+ Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(270, 98);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 28);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(365, 98);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 28);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(460, 98);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(85, 28);
            this.btnTaiLai.TabIndex = 12;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(20, 148);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.TabIndex = 13;
            this.lblLoc.Text = "Lọc năm:";
            // 
            // nudTu
            // 
            this.nudTu.Location = new System.Drawing.Point(85, 145);
            this.nudTu.Maximum = new decimal(new int[] {9999, 0, 0, 0});
            this.nudTu.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudTu.Name = "nudTu";
            this.nudTu.Size = new System.Drawing.Size(70, 23);
            this.nudTu.TabIndex = 14;
            this.nudTu.Value = new decimal(new int[] {1900, 0, 0, 0});
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(170, 148);
            this.lblDen.Name = "lblDen";
            this.lblDen.TabIndex = 15;
            this.lblDen.Text = "đến";
            // 
            // nudDen
            // 
            this.nudDen.Location = new System.Drawing.Point(200, 145);
            this.nudDen.Maximum = new decimal(new int[] {9999, 0, 0, 0});
            this.nudDen.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudDen.Name = "nudDen";
            this.nudDen.Size = new System.Drawing.Size(70, 23);
            this.nudDen.TabIndex = 16;
            this.nudDen.Value = new decimal(new int[] {2026, 0, 0, 0});
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(290, 143);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(85, 28);
            this.btnLoc.TabIndex = 17;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.Location = new System.Drawing.Point(20, 190);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(820, 275);
            this.dgvSach.TabIndex = 18;
            this.dgvSach.SelectionChanged += new System.EventHandler(this.dgvSach_SelectionChanged);
            // 
            // lblThongKe
            // 
            this.lblThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblThongKe.ForeColor = System.Drawing.Color.FromArgb(0, 51, 153);
            this.lblThongKe.Location = new System.Drawing.Point(20, 478);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.TabIndex = 19;
            this.lblThongKe.Text = "Tổng: 0 cuốn | Giá TB: 0đ | Đắt nhất: — (đ) | Rẻ nhất: — (đ)";
            // 
            // FormQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 510);
            this.Controls.Add(this.lblThongKe);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.nudDen);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.nudTu);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.nudNam);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(760, 450);
            this.Name = "FormQuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Sách - 3 Project Architecture";
            this.Load += new System.EventHandler(this.FormQuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.NumericUpDown nudTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.NumericUpDown nudDen;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Label lblThongKe;
    }
}
