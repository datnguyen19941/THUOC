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
    public partial class frmHoaDonBan : Form
    {
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        ClassQuanLyThuoc kn = new ClassQuanLyThuoc();

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            kn.myconnect();
            string sql = " select * from KhachHang";
            cbbMaKH.DataSource = kn.taobang(sql);
            cbbMaKH.DisplayMember = "MSKH";
        }

        private void cbbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = " select * from KhachHang where MSKH ='" + cbbMaKH.Text + "'";

            DataTable d = kn.taobang(s);
            foreach (DataRow hang in d.Rows)
                txtTenKH.Text = hang["TenKH"].ToString();
            foreach (DataRow hang in d.Rows)
                txtSDT.Text = hang["SDT"].ToString();
            string s1 = " select * " + " from HoaDonBan " +
                   "where (MSKH = '" + cbbMaKH.Text + "')";
            dgvHD.DataSource = kn.taobang(s1);
        }
        public void LoadDuLieu()
        {
            string sql =
           " select *  from HoaDonBan WHERE MSKH = ('" + cbbMaKH.Text + "') ";
            dgvHD.DataSource = kn.taobang(sql);
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgvHD.DataSource;
            chiso = dgvHD.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[chiso];
            txtMaHD.Text = hang["MSHoaDonBan"].ToString();
            dtNgay.Value = Convert.ToDateTime(hang["NgayBan"].ToString());
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            string s = "select * from HoaDonBan where MSHoaDonBan='" + txtMaHD + "'";
            DataTable dt = new DataTable();
            dt = kn.taobang(s);
            if (dt.Rows.Count == 0)
            {
                kn.themHDB(txtMaHD.Text, cbbMaKH.Text, dtNgay.Value);
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
            string s = "select * from HoaDonBan where MSHoaDonBan='" + txtMaHD + "'";
            DataTable dt = new DataTable();
            dt = kn.taobang(s);
            if (dt.Rows.Count == 0)
            {
                kn.xoaHDB(txtMaHD.Text, cbbMaKH.Text, dtNgay.Value);
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
            string s = "select * from HoaDonBan where MSHoaDonBan='" + txtMaHD + "'";
            DataTable dt = new DataTable();
            dt = kn.taobang(s);
            if (dt.Rows.Count == 0)
            {
                kn.suaHDB(txtMaHD.Text, cbbMaKH.Text, dtNgay.Value);
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
