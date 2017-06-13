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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }
        
        private void frmChinh_Load(object sender, EventArgs e)
        {
           
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmqlthuoc f = new frmqlthuoc();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmqlthuoc f = new frmqlthuoc();
            f.Show();
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmqlNCC f = new frmqlNCC();
            f.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void vềChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmgioithieu f = new frmgioithieu();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmqlDVT f = new frmqlDVT();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtkKH f = new frmtkKH();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn THOÁT ? ? ?", "TRẢ LỜI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes) Application.Exit();
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtkNCC f = new frmtkNCC();
            f.Show();
        }

        private void thuốcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtkthuoc f = new frmtkthuoc();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmqlXX f = new frmqlXX();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmqlKH f = new frmqlKH();
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmqlNCC f = new frmqlNCC();
            f.Show();
        }

        private void loạiThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmqlloaithuoc f = new frmqlloaithuoc();
            f.Show();
        }

        private void thuốcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmqlthuoc f = new frmqlthuoc();
            f.Show();
        }

        private void xuấtXứToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmqlXX f = new frmqlXX();
            f.Show();
        }

        private void đơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmqlDVT f = new frmqlDVT();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            this.Hide();
            frmqlKH f = new frmqlKH();
            f.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void hóaĐơnXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void lậpHĐNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHDNhap f = new frmHDNhap();
            f.Show();
        }

        private void cTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDonBan f = new frmHoaDonBan();
            f.Show();
        }

        private void cTHĐNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCT_HDN f = new frmCT_HDN();
            f.Show();
        }

        private void cTHĐBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCT_HDB f = new frmCT_HDB();
            f.Show();
        }
        
    }
}
