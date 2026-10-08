namespace hoccsharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpNhapLieu = new System.Windows.Forms.GroupBox() { Text = "Thông tin vật tư", Location = new System.Drawing.Point(12, 12), Size = new System.Drawing.Size(260, 290) };
            this.txtMaVT = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(90, 30), Size = new System.Drawing.Size(150, 23) };
            this.txtTenVT = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(90, 70), Size = new System.Drawing.Size(150, 23) };
            this.cboDVT = new System.Windows.Forms.ComboBox() { Location = new System.Drawing.Point(90, 110), Size = new System.Drawing.Size(150, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            this.cboDVT.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            this.txtDonGia = new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(90, 150), Size = new System.Drawing.Size(150, 23) };

            this.btnThemMoi = new System.Windows.Forms.Button() { Text = "Thêm mới", Location = new System.Drawing.Point(15, 195), Size = new System.Drawing.Size(105, 32) };
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);

            this.btnCapNhat = new System.Windows.Forms.Button() { Text = "Cập nhật", Location = new System.Drawing.Point(135, 195), Size = new System.Drawing.Size(105, 32) };
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            this.btnXoaDong = new System.Windows.Forms.Button() { Text = "Xóa dòng", Location = new System.Drawing.Point(15, 238), Size = new System.Drawing.Size(105, 32) };
            this.btnXoaDong.Click += new System.EventHandler(this.btnXoaDong_Click);

            this.btnXoaToanBo = new System.Windows.Forms.Button() { Text = "Xóa toàn bộ", Location = new System.Drawing.Point(135, 238), Size = new System.Drawing.Size(105, 32) };
            this.btnXoaToanBo.Click += new System.EventHandler(this.btnXoaToanBo_Click);

            this.grpNhapLieu.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { Text = "Mã VT:", Location = new System.Drawing.Point(15, 33), AutoSize = true }, this.txtMaVT,
                new System.Windows.Forms.Label { Text = "Tên VT:", Location = new System.Drawing.Point(15, 73), AutoSize = true }, this.txtTenVT,
                new System.Windows.Forms.Label { Text = "Đơn vị tính:", Location = new System.Drawing.Point(15, 113), AutoSize = true }, this.cboDVT,
                new System.Windows.Forms.Label { Text = "Đơn giá:", Location = new System.Drawing.Point(15, 153), AutoSize = true }, this.txtDonGia,
                this.btnThemMoi, this.btnCapNhat, this.btnXoaDong, this.btnXoaToanBo
            });

            this.grpDanhSach = new System.Windows.Forms.GroupBox() { Text = "Danh sách vật tư", Location = new System.Drawing.Point(282, 12), Size = new System.Drawing.Size(430, 290) };
            this.lsvVatTu = new System.Windows.Forms.ListView() { Location = new System.Drawing.Point(10, 25), Size = new System.Drawing.Size(410, 255), View = System.Windows.Forms.View.Details, FullRowSelect = true, GridLines = true };
            this.lsvVatTu.Columns.Add("Mã VT", 75);
            this.lsvVatTu.Columns.Add("Tên VT", 140);
            this.lsvVatTu.Columns.Add("Đơn vị tính", 80);
            this.lsvVatTu.Columns.Add("Đơn giá", 100);
            this.lsvVatTu.SelectedIndexChanged += new System.EventHandler(this.lsvVatTu_SelectedIndexChanged);
            this.grpDanhSach.Controls.Add(this.lsvVatTu);

            this.ClientSize = new System.Drawing.Size(724, 315);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.grpNhapLieu, this.grpDanhSach });
            this.Text = "Item List Manager";
        }

        private System.Windows.Forms.GroupBox grpNhapLieu, grpDanhSach;
        private System.Windows.Forms.TextBox txtMaVT, txtTenVT, txtDonGia;
        private System.Windows.Forms.ComboBox cboDVT;
        private System.Windows.Forms.Button btnThemMoi, btnCapNhat, btnXoaDong, btnXoaToanBo;
        private System.Windows.Forms.ListView lsvVatTu;
    }
}