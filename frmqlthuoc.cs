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
    public partial class frmqlthuoc : Form
    {
        public frmqlthuoc()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void LoadDuLieu()
        {
            string sql = "select * from Thuoc";
            dgvThuoc.DataSource = kn.taobang(sql);
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

  

        private void txtTim_Click(object sender, EventArgs e)
        {
            string sql = "select * from Thuoc where TenThuoc like '%" + textBox9.Text.Trim() + "%'";
            dgvThuoc.DataSource = kn.taobang(sql);
        }

        private void dgvThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgvThuoc.DataSource;
            chiso = dgvThuoc.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[chiso];
            txtMa.Text = hang["MSThuoc"].ToString();
            txtTen.Text = hang["TenThuoc"].ToString();
            txtCongDung.Text = hang["CongDung"].ToString();
            dtNgay.Value = Convert.ToDateTime(hang["HanSuDung"].ToString());
            cbbMSLoai.Text = hang["MSLoaiThuoc"].ToString();
            cbbMaXuatXu.Text = hang["MSXuatXu"].ToString();
            cbbMSDonVi.Text = hang["MSDonViTinh"].ToString();
            txtGia.Text = hang["GiaBan"].ToString();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtMa.ResetText();
            txtTen.ResetText();
            cbbMaXuatXu.ResetText();
            cbbMSDonVi.ResetText();
            cbbMSLoai.ResetText();
            txtCongDung.ResetText();
            dtNgay.ResetText();
            txtGia.ResetText();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChinh f = new frmChinh();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn THOÁT ? ? ?", "TRẢ LỜI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes) Application.Exit();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Length != 0 && txtTen.Text.Length != 0)
            {
                try
                {
                    string s = "select * from Thuoc where MSThuoc='" + txtMa + "'";
                    DataTable dt = new DataTable();
                    dt = kn.taobang(s);
                    if (dt.Rows.Count == 0)
                    {
                        kn.them(txtMa.Text, txtTen.Text, cbbMSLoai.Text, cbbMaXuatXu.Text, cbbMSDonVi.Text, txtCongDung.Text, dtNgay.Value, txtGia.Text);
                        txtMa.ResetText();
                        txtTen.ResetText();
                        cbbMaXuatXu.ResetText();
                        cbbMSDonVi.ResetText();
                        cbbMSLoai.ResetText();
                        txtCongDung.ResetText();
                        dtNgay.ResetText();
                        txtGia.ResetText();

                        txtMa.Focus();
                        LoadDuLieu();
                        MessageBox.Show("THUỐC đã được thêm ! ! ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Mã THUỐC đã tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMa.Clear();
                }
                LoadDuLieu();
            }
            else
                MessageBox.Show("Mã THUỐC và tên THUỐC không được để trống !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string s = "select * from Thuoc where MSThuoc='" + txtMa + "'";
            traloi = MessageBox.Show("Bạn có muốn xóa không ?", "Trả Lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.No)
            {
                LoadDuLieu();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                try
                {
                    if (dt.Rows.Count == 0)
                    {
                        kn.xoa(txtMa.Text, txtTen.Text, cbbMSLoai.Text, cbbMaXuatXu.Text, cbbMSDonVi.Text, txtCongDung.Text, dtNgay.Value, txtGia.Text);
                        txtMa.ResetText();
                        txtTen.ResetText();
                        cbbMaXuatXu.ResetText();
                        cbbMSDonVi.ResetText();
                        cbbMSLoai.ResetText();
                        txtCongDung.ResetText();
                        dtNgay.ResetText();
                        txtGia.ResetText();

                        txtMa.Focus();
                        LoadDuLieu();
                        MessageBox.Show("Đã xóa xong ! ! ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("KHÔNG XÓA ĐC MÀ !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMa.Clear();
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Length != 0 && txtTen.Text.Length != 0)
            {
                string s = "select * from Thuoc where MSThuoc='" + txtMa + "'";
                DataTable dt = new DataTable();
                dt = kn.taobang(s);
                if (dt.Rows.Count == 0)
                {
                    kn.sua(txtMa.Text, txtTen.Text, cbbMSLoai.Text, cbbMaXuatXu.Text, cbbMSDonVi.Text, txtCongDung.Text, dtNgay.Value, txtGia.Text);
                    txtMa.ResetText();
                    txtTen.ResetText();
                    cbbMaXuatXu.ResetText();
                    cbbMSDonVi.ResetText();
                    cbbMSLoai.ResetText();
                    txtCongDung.ResetText();
                    dtNgay.ResetText();
                    txtGia.ResetText();

                    txtMa.Focus();
                    LoadDuLieu();
                    MessageBox.Show("Đã sửa xong thông tin của XUẤT XỨ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                LoadDuLieu();
            }
            else
                MessageBox.Show("Chưa điền đầy đủ thông tin cần sửa.Vui lòng nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
     
    
}
