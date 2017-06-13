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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.ResetText();
            this.textBox2.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin") && (textBox2.Text == "admin"))
            {
                this.Hide();
                frmChinh f = new frmChinh();
                f.Show();
            }
            else
            {
                MessageBox.Show("Tên người dùng/Mật khẩu không đúng!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn THOÁT ? ? ?", "TRẢ LỜI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes) Application.Exit();
        }

        private void frmlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }
    }
}
