
namespace ServiPlusApp.View
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.zeroitKokonsaSpinningCircles1 = new Zeroit.Framework.Progress.ZeroitKokonsaSpinningCircles();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // zeroitKokonsaSpinningCircles1
            // 
            this.zeroitKokonsaSpinningCircles1.BackColor = System.Drawing.Color.Transparent;
            this.zeroitKokonsaSpinningCircles1.CircleBorderColor = System.Drawing.Color.White;
            this.zeroitKokonsaSpinningCircles1.CircleBorderWidth = 2F;
            this.zeroitKokonsaSpinningCircles1.CircleFillColor = System.Drawing.Color.Navy;
            this.zeroitKokonsaSpinningCircles1.FullTransparent = true;
            this.zeroitKokonsaSpinningCircles1.Increment = 0.5F;
            this.zeroitKokonsaSpinningCircles1.Location = new System.Drawing.Point(12, 435);
            this.zeroitKokonsaSpinningCircles1.Name = "zeroitKokonsaSpinningCircles1";
            this.zeroitKokonsaSpinningCircles1.NumberOfCircles = 8;
            this.zeroitKokonsaSpinningCircles1.Radius = 2F;
            this.zeroitKokonsaSpinningCircles1.Size = new System.Drawing.Size(55, 53);
            this.zeroitKokonsaSpinningCircles1.TabIndex = 1;
            this.zeroitKokonsaSpinningCircles1.Text = "zeroitKokonsaSpinningCircles1";
            // 
            // timer3
            // 
            this.timer3.Interval = 30;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.zeroitKokonsaSpinningCircles1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zeroitSeaBlueForm1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SplashScreen_FormClosing);
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SplashScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SplashScreen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SplashScreen_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Zeroit.Framework.Progress.ZeroitKokonsaSpinningCircles zeroitKokonsaSpinningCircles1;
        private System.Windows.Forms.Timer timer3;
    }
}