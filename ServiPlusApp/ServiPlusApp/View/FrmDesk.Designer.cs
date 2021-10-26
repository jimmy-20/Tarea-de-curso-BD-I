
namespace ServiPlusApp.View
{
    partial class FrmDesk
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDesk));
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsSign = new System.Windows.Forms.ToolStrip();
            this.tsbtnSignIn = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSignUp = new System.Windows.Forms.ToolStripButton();
            this.tlsSign.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tlsSign
            // 
            this.tlsSign.AllowMerge = false;
            this.tlsSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tlsSign.Font = new System.Drawing.Font("Lucida Fax", 10.2F);
            this.tlsSign.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsSign.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSignIn,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.tsbtnSignUp});
            this.tlsSign.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tlsSign.Location = new System.Drawing.Point(0, 0);
            this.tlsSign.Name = "tlsSign";
            this.tlsSign.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tlsSign.Size = new System.Drawing.Size(962, 27);
            this.tlsSign.TabIndex = 1;
            this.tlsSign.Text = "toolStrip1";
            // 
            // tsbtnSignIn
            // 
            this.tsbtnSignIn.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnSignIn.ForeColor = System.Drawing.SystemColors.Control;
            this.tsbtnSignIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSignIn.Image")));
            this.tsbtnSignIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSignIn.Name = "tsbtnSignIn";
            this.tsbtnSignIn.Size = new System.Drawing.Size(96, 24);
            this.tsbtnSignIn.Text = "Sign in";
            this.tsbtnSignIn.Click += new System.EventHandler(this.tsbtnSignIn_Click);
            // 
            // tsbtnSignUp
            // 
            this.tsbtnSignUp.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnSignUp.ForeColor = System.Drawing.Color.White;
            this.tsbtnSignUp.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSignUp.Image")));
            this.tsbtnSignUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSignUp.Name = "tsbtnSignUp";
            this.tsbtnSignUp.Size = new System.Drawing.Size(102, 24);
            this.tsbtnSignUp.Text = "Sign up";
            this.tsbtnSignUp.Click += new System.EventHandler(this.tsbtnSignUp_Click);
            // 
            // FrmDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 496);
            this.Controls.Add(this.tlsSign);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FrmDesk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SERVI PLUS, S.A.";
            this.tlsSign.ResumeLayout(false);
            this.tlsSign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnSignIn;
        private System.Windows.Forms.ToolStripButton tsbtnSignUp;
        private System.Windows.Forms.ToolStrip tlsSign;
    }
}

