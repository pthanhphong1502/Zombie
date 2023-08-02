
namespace Game_băn_Zombie
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picRes = new System.Windows.Forms.PictureBox();
            this.picStart = new System.Windows.Forms.PictureBox();
            this.picPause = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picRes);
            this.panel1.Controls.Add(this.picStart);
            this.panel1.Controls.Add(this.picPause);
            this.panel1.Controls.Add(this.picPlay);
            this.panel1.Controls.Add(this.healthBar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtScore);
            this.panel1.Controls.Add(this.txtAmmo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 100);
            this.panel1.TabIndex = 4;
            // 
            // picRes
            // 
            this.picRes.Image = global::Game_băn_Zombie.Properties.Resources.undo_arrow;
            this.picRes.Location = new System.Drawing.Point(731, 3);
            this.picRes.Name = "picRes";
            this.picRes.Size = new System.Drawing.Size(100, 94);
            this.picRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRes.TabIndex = 12;
            this.picRes.TabStop = false;
            this.picRes.Click += new System.EventHandler(this.picRes_Click);
            // 
            // picStart
            // 
            this.picStart.Image = global::Game_băn_Zombie.Properties.Resources.submachine_gun__1_;
            this.picStart.Location = new System.Drawing.Point(590, 3);
            this.picStart.Name = "picStart";
            this.picStart.Size = new System.Drawing.Size(100, 94);
            this.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStart.TabIndex = 11;
            this.picStart.TabStop = false;
            this.picStart.Click += new System.EventHandler(this.picStart_Click);
            // 
            // picPause
            // 
            this.picPause.Image = global::Game_băn_Zombie.Properties.Resources.pause;
            this.picPause.Location = new System.Drawing.Point(590, 3);
            this.picPause.Name = "picPause";
            this.picPause.Size = new System.Drawing.Size(100, 94);
            this.picPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPause.TabIndex = 10;
            this.picPause.TabStop = false;
            this.picPause.Click += new System.EventHandler(this.picPause_Click);
            // 
            // picPlay
            // 
            this.picPlay.Image = global::Game_băn_Zombie.Properties.Resources.play_buttton;
            this.picPlay.Location = new System.Drawing.Point(590, 3);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(100, 94);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlay.TabIndex = 9;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(218, 56);
            this.healthBar.Margin = new System.Windows.Forms.Padding(4);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(249, 28);
            this.healthBar.TabIndex = 4;
            this.healthBar.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Health";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(25, 55);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(92, 29);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Kills: 0";
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.Location = new System.Drawing.Point(25, 9);
            this.txtAmmo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(114, 29);
            this.txtAmmo.TabIndex = 1;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // player
            // 
            this.player.Image = global::Game_băn_Zombie.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(581, 580);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1232, 814);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.player);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.PictureBox picRes;
        private System.Windows.Forms.PictureBox picPause;
        private System.Windows.Forms.PictureBox picStart;
        private System.Windows.Forms.Timer GameTimer;
    }
}