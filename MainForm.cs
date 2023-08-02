using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace Game_băn_Zombie
{
    public partial class Form1 : Form
    {
        Image image;
        
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\phong\Documents\LTTQ\Đồ án\Đồ án CKLTTQ\Game băn Zombie\Resources\musicop.wav");
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;

        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTittle.BackColor = color;
                    btnCloseChildForm.Visible = true;

                }

            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTittle.Text = childForm.Text;
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Game(), sender);
            Game game = new Game();
            game.ShowDialog();
        }

        private void btnHd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHuongDan(), sender);
        }

        private void btnHis_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            sp.Stop();
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                FormDangNhap dn = new FormDangNhap();
                dn.ShowDialog();
            }
            
        }

        private void btnQl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanly(), sender);
        }

        private void picoff_Click(object sender, EventArgs e)
        {
            picoff.Hide();
            picon.Show();
            sp.Stop();
        }

        private void picon_Click(object sender, EventArgs e)
        {
            picon.Hide();
            picoff.Show();
            sp.PlayLooping();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = FormDangNhap.tentk;
            if (FormDangNhap.quyen == 1)
            {
                btnQl.Visible = true;
            }
            else
            {
                btnQl.Visible = false;
            }
            sp.PlayLooping();
            LoadImage(Application.StartupPath + @"\dino1.png");
        }
        //Change Avatar
        private void LoadImage(string filename)
        {
            image = Image.FromFile(filename);
            pictureAvatar.Image = image;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadImage(dlg.FileName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
            
        }
        private void Reset()
        {
            DisableButton();
            labelTittle.Text = "HOME";
            panelTittle.BackColor = Color.FromArgb(0, 150, 136);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
    }
}
