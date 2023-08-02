
namespace Game_băn_Zombie
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Player1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTittle = new System.Windows.Forms.Panel();
            this.labelTittle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.picoff = new System.Windows.Forms.PictureBox();
            this.picon = new System.Windows.Forms.PictureBox();
            this.btnQl = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnHd = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.panelTittle.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.picoff);
            this.panelMenu.Controls.Add(this.picon);
            this.panelMenu.Controls.Add(this.Player1);
            this.panelMenu.Controls.Add(this.btnQl);
            this.panelMenu.Controls.Add(this.btnSign);
            this.panelMenu.Controls.Add(this.btnHd);
            this.panelMenu.Controls.Add(this.btnPlay);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 767);
            this.panelMenu.TabIndex = 0;
            // 
            // Player1
            // 
            this.Player1.Enabled = true;
            this.Player1.Location = new System.Drawing.Point(3, 754);
            this.Player1.Name = "Player1";
            this.Player1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player1.OcxState")));
            this.Player1.Size = new System.Drawing.Size(10, 10);
            this.Player1.TabIndex = 5;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.button1);
            this.panelLogo.Controls.Add(this.pictureAvatar);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(116, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(116, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTittle
            // 
            this.panelTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTittle.Controls.Add(this.btnCloseChildForm);
            this.panelTittle.Controls.Add(this.labelTittle);
            this.panelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittle.Location = new System.Drawing.Point(240, 0);
            this.panelTittle.Name = "panelTittle";
            this.panelTittle.Size = new System.Drawing.Size(1173, 120);
            this.panelTittle.TabIndex = 1;
            // 
            // labelTittle
            // 
            this.labelTittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.ForeColor = System.Drawing.Color.White;
            this.labelTittle.Location = new System.Drawing.Point(525, 38);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(141, 45);
            this.labelTittle.TabIndex = 2;
            this.labelTittle.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(240, 120);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1173, 647);
            this.panelDesktop.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Game_băn_Zombie.Properties.Resources.halloween_g956f855ed_1280;
            this.pictureBox2.Location = new System.Drawing.Point(0, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1173, 573);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Game_băn_Zombie.Properties.Resources.Tit;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1173, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::Game_băn_Zombie.Properties.Resources.house;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(137, 120);
            this.btnCloseChildForm.TabIndex = 8;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // picoff
            // 
            this.picoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picoff.Image = global::Game_băn_Zombie.Properties.Resources.volume;
            this.picoff.Location = new System.Drawing.Point(3, 681);
            this.picoff.Name = "picoff";
            this.picoff.Size = new System.Drawing.Size(100, 86);
            this.picoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picoff.TabIndex = 7;
            this.picoff.TabStop = false;
            this.picoff.Click += new System.EventHandler(this.picoff_Click);
            // 
            // picon
            // 
            this.picon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picon.Image = global::Game_băn_Zombie.Properties.Resources.mute;
            this.picon.Location = new System.Drawing.Point(3, 681);
            this.picon.Name = "picon";
            this.picon.Size = new System.Drawing.Size(100, 86);
            this.picon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picon.TabIndex = 6;
            this.picon.TabStop = false;
            this.picon.Click += new System.EventHandler(this.picon_Click);
            // 
            // btnQl
            // 
            this.btnQl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQl.FlatAppearance.BorderSize = 0;
            this.btnQl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQl.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQl.Image = global::Game_băn_Zombie.Properties.Resources.setting;
            this.btnQl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQl.Location = new System.Drawing.Point(0, 360);
            this.btnQl.Name = "btnQl";
            this.btnQl.Size = new System.Drawing.Size(240, 80);
            this.btnQl.TabIndex = 4;
            this.btnQl.Text = "  Quản Lý";
            this.btnQl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQl.UseVisualStyleBackColor = true;
            this.btnQl.Click += new System.EventHandler(this.btnQl_Click);
            // 
            // btnSign
            // 
            this.btnSign.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSign.FlatAppearance.BorderSize = 0;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSign.Image = global::Game_băn_Zombie.Properties.Resources.logout;
            this.btnSign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSign.Location = new System.Drawing.Point(0, 280);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(240, 80);
            this.btnSign.TabIndex = 3;
            this.btnSign.Text = "  Đăng Xuất ";
            this.btnSign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSign.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnHd
            // 
            this.btnHd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHd.FlatAppearance.BorderSize = 0;
            this.btnHd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHd.Image = global::Game_băn_Zombie.Properties.Resources.question;
            this.btnHd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHd.Location = new System.Drawing.Point(0, 200);
            this.btnHd.Name = "btnHd";
            this.btnHd.Size = new System.Drawing.Size(240, 80);
            this.btnHd.TabIndex = 1;
            this.btnHd.Text = "  Hướng Dẫn";
            this.btnHd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHd.UseVisualStyleBackColor = true;
            this.btnHd.Click += new System.EventHandler(this.btnHd_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlay.Image = global::Game_băn_Zombie.Properties.Resources.rifle;
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.Location = new System.Drawing.Point(0, 120);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(240, 80);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "  Bắt Đầu ";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureAvatar.Location = new System.Drawing.Point(0, 0);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(116, 120);
            this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAvatar.TabIndex = 3;
            this.pictureAvatar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 767);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTittle);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelTittle.ResumeLayout(false);
            this.panelTittle.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnQl;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnHd;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTittle;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer Player1;
        private System.Windows.Forms.PictureBox picon;
        private System.Windows.Forms.PictureBox picoff;
        private System.Windows.Forms.Button btnCloseChildForm;
    }
}

