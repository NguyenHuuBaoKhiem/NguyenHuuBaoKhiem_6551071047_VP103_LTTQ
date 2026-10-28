namespace NguyenHuuBaoKhiem_6551071047_VP103_LTTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpThongTinSach = new GroupBox();
            txtGiaTien = new TextBox();
            txtTenSach = new TextBox();
            txtMaSach = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpDanhSach = new GroupBox();
            dgvDuLieu = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            grpThongTinSach.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDuLieu).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinSach
            // 
            grpThongTinSach.Controls.Add(txtGiaTien);
            grpThongTinSach.Controls.Add(txtTenSach);
            grpThongTinSach.Controls.Add(txtMaSach);
            grpThongTinSach.Controls.Add(label3);
            grpThongTinSach.Controls.Add(label2);
            grpThongTinSach.Controls.Add(label1);
            grpThongTinSach.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpThongTinSach.Location = new Point(5, 8);
            grpThongTinSach.Name = "grpThongTinSach";
            grpThongTinSach.Size = new Size(272, 428);
            grpThongTinSach.TabIndex = 0;
            grpThongTinSach.TabStop = false;
            grpThongTinSach.Text = "Thông tin sách";
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(21, 348);
            txtGiaTien.MaxLength = 12;
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(194, 38);
            txtGiaTien.TabIndex = 5;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(21, 219);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(194, 38);
            txtTenSach.TabIndex = 4;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(21, 85);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(194, 38);
            txtMaSach.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(21, 307);
            label3.Name = "label3";
            label3.Size = new Size(93, 31);
            label3.TabIndex = 2;
            label3.Text = "Giá tiền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(21, 175);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
            label2.TabIndex = 1;
            label2.Text = "Tên sách:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(21, 40);
            label1.Name = "label1";
            label1.Size = new Size(104, 31);
            label1.TabIndex = 0;
            label1.Text = "Mã sách:";
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(dgvDuLieu);
            grpDanhSach.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDanhSach.ForeColor = Color.Black;
            grpDanhSach.Location = new Point(283, 129);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(821, 307);
            grpDanhSach.TabIndex = 1;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách sách";
            // 
            // dgvDuLieu
            // 
            dgvDuLieu.AllowUserToAddRows = false;
            dgvDuLieu.AllowUserToDeleteRows = false;
            dgvDuLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDuLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDuLieu.Location = new Point(15, 33);
            dgvDuLieu.MultiSelect = false;
            dgvDuLieu.Name = "dgvDuLieu";
            dgvDuLieu.ReadOnly = true;
            dgvDuLieu.RowHeadersWidth = 51;
            dgvDuLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDuLieu.Size = new Size(800, 267);
            dgvDuLieu.TabIndex = 0;
            dgvDuLieu.CellClick += dgvDuLieu_CellClick;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 13.8F);
            btnThem.Location = new Point(298, 32);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(177, 79);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 13.8F);
            btnSua.Location = new Point(508, 32);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(177, 79);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 13.8F);
            btnXoa.Location = new Point(718, 32);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(177, 79);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 13.8F);
            btnThoat.Location = new Point(927, 32);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(177, 79);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grpDanhSach);
            Controls.Add(grpThongTinSach);
            Name = "Form1";
            Text = "Form1";
            grpThongTinSach.ResumeLayout(false);
            grpThongTinSach.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDuLieu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTinSach;
        private GroupBox grpDanhSach;
        private DataGridView dgvDuLieu;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private TextBox txtGiaTien;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
