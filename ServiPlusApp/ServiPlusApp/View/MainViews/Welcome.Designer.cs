
namespace ServiPlusApp.View
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.zeroitProgressBarCircular1 = new Zeroit.Framework.Progress.ZeroitProgressBarCircular();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 1;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(650, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 392);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 5);
            this.panel2.TabIndex = 9;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 392);
            this.panel4.TabIndex = 9;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseUp);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(645, 5);
            this.panel5.TabIndex = 9;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseMove);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblFullname);
            this.panel3.Controls.Add(this.zeroitProgressBarCircular1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 382);
            this.panel3.TabIndex = 10;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServiPlusApp.Properties.Resources.Welcome4;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(303, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 60);
            this.label2.TabIndex = 12;
            this.label2.Text = "WELCOME...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SYSTEM DATABASE";
            // 
            // lblFullname
            // 
            this.lblFullname.BackColor = System.Drawing.Color.Transparent;
            this.lblFullname.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblFullname.Location = new System.Drawing.Point(299, 213);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(330, 35);
            this.lblFullname.TabIndex = 11;
            this.lblFullname.Text = "Fullname";
            this.lblFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zeroitProgressBarCircular1
            // 
            this.zeroitProgressBarCircular1.AutoAnimate = true;
            this.zeroitProgressBarCircular1.BackColor = System.Drawing.Color.Transparent;
            this.zeroitProgressBarCircular1.Cursor = System.Windows.Forms.Cursors.Default;
            this.zeroitProgressBarCircular1.FillEllipse1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.zeroitProgressBarCircular1.FillEllipse2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.zeroitProgressBarCircular1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.zeroitProgressBarCircular1.Location = new System.Drawing.Point(409, 251);
            this.zeroitProgressBarCircular1.Maximum = ((long)(100));
            this.zeroitProgressBarCircular1.Name = "zeroitProgressBarCircular1";
            this.zeroitProgressBarCircular1.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(130)))));
            this.zeroitProgressBarCircular1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(162)))), ((int)(((byte)(219)))));
            this.zeroitProgressBarCircular1.ProgressInnerBorderColor = System.Drawing.Color.Black;
            this.zeroitProgressBarCircular1.ProgressInnerBorderWidth = 1F;
            this.zeroitProgressBarCircular1.ProgressWidth = 5D;
            this.zeroitProgressBarCircular1.ProgressWidthEndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            this.zeroitProgressBarCircular1.ProgressWidthStartCap = System.Drawing.Drawing2D.LineCap.Triangle;
            this.zeroitProgressBarCircular1.ShowText = true;
            this.zeroitProgressBarCircular1.Size = new System.Drawing.Size(128, 128);
            this.zeroitProgressBarCircular1.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.zeroitProgressBarCircular1.TabIndex = 10;
            this.zeroitProgressBarCircular1.TextColor = System.Drawing.Color.White;
            this.zeroitProgressBarCircular1.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.zeroitProgressBarCircular1.Transparent = false;
            this.zeroitProgressBarCircular1.Value = ((long)(42));
            // 
            // Welcome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ServiPlusApp.Properties.Resources.WelcomeFondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(655, 392);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "Welcome";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseUp);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFullname;
        private Zeroit.Framework.Progress.ZeroitProgressBarCircular zeroitProgressBarCircular1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}