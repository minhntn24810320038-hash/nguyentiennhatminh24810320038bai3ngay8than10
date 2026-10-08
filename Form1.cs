using System;
using System.Windows.Forms;

namespace hoccsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboDVT.SelectedIndex = 0;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string ma = txtMaVT.Text.Trim();
            string ten = txtTenVT.Text.Trim();
            string dvt = cboDVT.SelectedItem?.ToString() ?? "";
            string giaStr = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(giaStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!decimal.TryParse(giaStr, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số không âm!");
                return;
            }

            foreach (ListViewItem item in lsvVatTu.Items)
            {
                if (item.Text.Equals(ma, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã vật tư đã tồn tại trong danh sách!");
                    return;
                }
            }

            ListViewItem newItem = new ListViewItem(ma);
            newItem.SubItems.Add(ten);
            newItem.SubItems.Add(dvt);
            newItem.SubItems.Add(donGia.ToString("N0"));
            lsvVatTu.Items.Add(newItem);

            ClearInputs();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần cập nhật!");
                return;
            }

            string ma = txtMaVT.Text.Trim();
            string ten = txtTenVT.Text.Trim();
            string dvt = cboDVT.SelectedItem?.ToString() ?? "";
            string giaStr = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(giaStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!decimal.TryParse(giaStr, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số không âm!");
                return;
            }

            ListViewItem selectedItem = lsvVatTu.SelectedItems[0];
            if (!selectedItem.Text.Equals(ma, StringComparison.OrdinalIgnoreCase))
            {
                foreach (ListViewItem item in lsvVatTu.Items)
                {
                    if (item != selectedItem && item.Text.Equals(ma, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Mã vật tư mới bị trùng với vật tư khác!");
                        return;
                    }
                }
            }

            selectedItem.Text = ma;
            selectedItem.SubItems[1].Text = ten;
            selectedItem.SubItems[2].Text = dvt;
            selectedItem.SubItems[3].Text = donGia.ToString("N0");

            ClearInputs();
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lsvVatTu.Items.Remove(lsvVatTu.SelectedItems[0]);
                ClearInputs();
            }
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.Items.Count == 0) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ danh sách?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lsvVatTu.Items.Clear();
                ClearInputs();
            }
        }

        private void lsvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvVatTu.SelectedItems[0];
                txtMaVT.Text = item.Text;
                txtTenVT.Text = item.SubItems[1].Text;
                cboDVT.SelectedItem = item.SubItems[2].Text;
                txtDonGia.Text = item.SubItems[3].Text.Replace(",", "").Replace(".", "");
            }
        }

        private void ClearInputs()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            txtDonGia.Clear();
            if (cboDVT.Items.Count > 0) cboDVT.SelectedIndex = 0;
            txtMaVT.Focus();
        }
    }
}