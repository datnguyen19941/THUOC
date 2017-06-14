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
    public partial class frmHDNhap : Form
    {
        public frmHDNhap()
        {
            InitializeComponent();
        }
        ClassQuanLyThuoc kn = new ClassQuanLyThuoc();

        private void frmHDNhap_Load(object sender, EventArgs e)
        {
            kn.myconnect();
            string sql = " select * from NhaCungCap";
            cbbMaNCC.DataSource = kn.taobang(sql);
            cbbMaNCC.DisplayMember = "MSNhaCungCap";

        }

        private void cbbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = " select * from NhaCungCap where MSNhaCungCap ='" + cbbMaNCC.Text + "'";

            DataTable d = kn.taobang(s);
            foreach (DataRow hang in d.Rows)
                txtTenNCC.Text = hang["TenNhaCungCap"].ToString();
            foreach (DataRow hang in d.Rows)
                txtSDT.Text = hang["SDT"].ToString();
            string s1 = " select * " + " from HoaDonNhapHang " +
                   "where (MSNhaCungCap = '" + cbbMaNCC.Text + "')";
            dgvHD.DataSource = kn.taobang(s1);
        }
        public void LoadDuLieu()
        {
            string sql =
           " select *  from HoaDonNhapHang WHERE MSNhaCungCap = ('" + cbbMaNCC.Text + "') ";
            dgvHD.DataSource = kn.taobang(sql);
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgvHD.DataSource;
            chiso = dgvHD.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[chiso];
            txtMaHD.Text = hang["MSHDNhap"].ToString();
            dtNgay.Value = Convert.ToDateTime(hang["NgayNhap"].ToString());
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string s = "select * from HoaDonNhapHang where MSHDNhap='" + txtMaHD + "'";
            DataTable dt = new DataTable();
            dt = kn.taobang(s);
            if (dt.Rows.Count == 0)
            {
                kn.themHDN(txtMaHD.Text, cbbMaNCC.Text, dtNgay.Value);
                txtMaHD.ResetText();

                dtNgay.ResetText();

                txtMaHD.Focus();



            }

            else
            {
                MessageBox.Show("Mã Hóa Đơn Đã Có, vui lòng nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadDuLieu();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string s = "select * from HoaDonNhapHang where MSHDNhap='" + txtMaHD + "'";
            DataTable dt = new DataTable();
            dt = kn.taobang(s);
            if (dt.Rows.Count == 0)
            {
                kn.xoaHDN(txtMaHD.Text, cbbMaNCC.Text, dtNgay.Value);
                txtMaHD.ResetText();

                dtNgay.ResetText();

                txtMaHD.Focus();



            }

            else
            {
                MessageBox.Show("Chưa CHọn Hóa Đơn để xóa, vui lòng chọn lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadDuLieu();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string s = "select * from HoaDonNhapHang where MSHDNhap='" + txtMaHD + "'";
            DataTable dt = new DataTable();
            dt = kn.taobang(s);
            if (dt.Rows.Count == 0)
            {
                kn.suaHDN(txtMaHD.Text, cbbMaNCC.Text, dtNgay.Value);
                txtMaHD.ResetText();

                dtNgay.ResetText();

                txtMaHD.Focus();



            

            }

            else
            {
                MessageBox.Show("Chưa Chọn Hóa Đơn Để Sửa, vui lòng chọn lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LoadDuLieu();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtMaHD.ResetText();

            dtNgay.ResetText();

            txtMaHD.Focus();
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
