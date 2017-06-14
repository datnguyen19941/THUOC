using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuoc
{
    public partial class frmqlNCC : Form
    {
        public frmqlNCC()
        {
            InitializeComponent();
        }

        ClassQuanLyThuoc kn = new ClassQuanLyThuoc();

        public void LoadDuLieu()
        {
            string sql = "select * from NhaCungCap";
            dgvNCC.DataSource = kn.taobang(sql);
        }

        private void frmqlNCC_Load(object sender, EventArgs e)
        {
            kn.myconnect();
            LoadDuLieu();

        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgvNCC.DataSource;
            chiso = dgvNCC.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[chiso];
            txtMa.Text = hang["MSNhaCungCap"].ToString();
            txtTen.Text = hang["TenNhaCungCap"].ToString();
            txtDiaChi.Text = hang["DiaChi"].ToString();
           
            txtDT.Text = hang["SDT"].ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string s = "select * from NhaCungCap where MSNhaCungCap='" + txtMa + "'";
            DataTable dt = new DataTable();
            dt = kn.taobang(s);
            if (dt.Rows.Count == 0)
            {
                kn.themNCC(txtMa.Text, txtTen.Text, txtDiaChi.Text, txtDT.Text);
                txtMa.ResetText();
                txtTen.ResetText();
                txtDiaChi.ResetText();
                txtDT.ResetText();
                txtMa.Focus();
                LoadDuLieu();
            }
            else
            {
                MessageBox.Show("Mã Thuốc Đã Có, vui lòng nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadDuLieu();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string s = "select * from NhaCungCap where MSNhaCungCap='" + txtMa + "'";
            DataTable dt = new DataTable();
            dt = kn.taobang(s);
            if (dt.Rows.Count == 0)
            {
                kn.xoaNCC(txtMa.Text, txtTen.Text, txtDiaChi.Text, txtDT.Text);
                txtMa.ResetText();
                txtTen.ResetText();
                txtDiaChi.ResetText();
                txtDT.ResetText();
                txtMa.Focus();
                LoadDuLieu();
            }
            else
            {
                MessageBox.Show("Chưa Chọn Nhà Cung Cấp Muốn Xóa, vui lòng chọn lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadDuLieu();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string s = "select * from NhaCungCap where MSNhaCungCap='" + txtMa + "'";
            DataTable dt = new DataTable();
            dt = kn.taobang(s);
            if (dt.Rows.Count == 0)
            {
                kn.suaNCC(txtMa.Text, txtTen.Text, txtDiaChi.Text, txtDT.Text);
                txtMa.ResetText();
                txtTen.ResetText();
                txtDiaChi.ResetText();
                txtDT.ResetText();
                txtMa.Focus();
                LoadDuLieu();
            }
            else
            {
                MessageBox.Show("Chưa Chọn Thuốc Để Sửa, vui lòng chọn lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadDuLieu();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtMa.ResetText();
            txtTen.ResetText();
            txtDiaChi.ResetText();
            txtDT.ResetText();
            txtMa.Focus();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmChinh f = new frmChinh();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn Có Chắc Muốn Thoát Hay Không?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }








    }
}
