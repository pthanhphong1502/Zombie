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
    public partial class FormQuanly : Form
    {
        public FormQuanly()
        {
            InitializeComponent();
        }
        Modify modify;
        TaiKhoan taikhoan;

        private void FormQuanly_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getAllTaiKhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tk = this.textBox1.Text;
            string mk = this.textBox2.Text;
            taikhoan = new TaiKhoan(tk, mk);
            if (modify.insert(taikhoan))
            {
                dataGridView1.DataSource = modify.getAllTaiKhoan();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tk = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(tk))
            {
                dataGridView1.DataSource = modify.getAllTaiKhoan();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
