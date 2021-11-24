
namespace ServiPlusApp.View.SubViews
{
    partial class MainDesk
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlDateTime = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pbServiplus = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlContenedor.SuspendLayout();
            this.pnlDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbServiplus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.pnlContenedor.Controls.Add(this.pnlDateTime);
            this.pnlContenedor.Controls.Add(this.pbServiplus);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1070, 750);
            this.pnlContenedor.TabIndex = 5;
            this.pnlContenedor.Tag = "";
            // 
            // pnlDateTime
            // 
            this.pnlDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(49)))), ((int)(((byte)(99)))));
            this.pnlDateTime.Controls.Add(this.lblFecha);
            this.pnlDateTime.Controls.Add(this.lblHora);
            this.pnlDateTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDateTime.Location = new System.Drawing.Point(0, 639);
            this.pnlDateTime.Name = "pnlDateTime";
            this.pnlDateTime.Size = new System.Drawing.Size(1070, 111);
            this.pnlDateTime.TabIndex = 5;
            this.pnlDateTime.Tag = "1; 36; 67";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFecha.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(644, 73);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(414, 28);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Miercoles, 15 de Diciembre de 2021";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Cascadia Code SemiLight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(722, 5);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(314, 74);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "00:00:00";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbServiplus
            // 
            this.pbServiplus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbServiplus.Image = global::ServiPlusApp.Properties.Resources.Fondo3;
            this.pbServiplus.Location = new System.Drawing.Point(229, 113);
            this.pbServiplus.Name = "pbServiplus";
            this.pbServiplus.Size = new System.Drawing.Size(620, 408);
            this.pbServiplus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbServiplus.TabIndex = 0;
            this.pbServiplus.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainDesk
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.pnlContenedor);
            this.Name = "MainDesk";
            this.Size = new System.Drawing.Size(1070, 750);
            this.Load += new System.EventHandler(this.MainDesk_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlDateTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbServiplus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlDateTime;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pbServiplus;
        private System.Windows.Forms.Timer timer1;
    }
}
