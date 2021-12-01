
namespace ServiPlusApp.View
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zeroitMacOSXOptimized1 = new Zeroit.Framework.Progress.ZeroitMacOSXOptimized();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SERVIPLUS  V 2.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "CARGANDO EL SISTEMA AL 0%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // zeroitMacOSXOptimized1
            // 
            this.zeroitMacOSXOptimized1.AutoAnimate = true;
            this.zeroitMacOSXOptimized1.Automatic = Zeroit.Framework.Progress.ZeroitMacOSXOptimized.AutoStartMode.Start;
            this.zeroitMacOSXOptimized1.BackColor = System.Drawing.Color.Transparent;
            this.zeroitMacOSXOptimized1.Interval = 60;
            this.zeroitMacOSXOptimized1.Location = new System.Drawing.Point(185, 260);
            this.zeroitMacOSXOptimized1.MinimumSize = new System.Drawing.Size(28, 28);
            this.zeroitMacOSXOptimized1.Name = "zeroitMacOSXOptimized1";
            this.zeroitMacOSXOptimized1.Rotation = Zeroit.Framework.Progress.ZeroitMacOSXOptimized.Direction.CLOCKWISE;
            this.zeroitMacOSXOptimized1.Size = new System.Drawing.Size(150, 150);
            this.zeroitMacOSXOptimized1.StartAngle = 240F;
            this.zeroitMacOSXOptimized1.TabIndex = 9;
            this.zeroitMacOSXOptimized1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(898, 452);
            this.Controls.Add(this.zeroitMacOSXOptimized1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSplashScreen_FormClosing);
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSplashScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmSplashScreen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmSplashScreen_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Zeroit.Framework.Progress.ZeroitMacOSXOptimized zeroitMacOSXOptimized1;
    }
}