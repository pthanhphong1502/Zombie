using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_băn_Zombie
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string tentk;
        public static int quyen;
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            tentk = textBox1.Text;
            string mk = textBox2.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
            }
            else
                if (mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên mật khẩu!");
            }
            else
            {
                string query = "Select *from DangNhap where TENTK ='" + tentk + "' and MK = '" + mk + "'";
                if (modify.tK(query).Count > 0)
                {
                    if (tentk == "admin")
                    {
                        quyen = 1;
                        MessageBox.Show("Đăng nhập "+tentk+" thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form1 fm = new Form1();
                        fm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        quyen = 0;
                        MessageBox.Show("Đăng nhập user thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form1 fm = new Form1();
                        fm.ShowDialog();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnDk_Click(object sender, EventArgs e)
        {
           
        }
    }
}
