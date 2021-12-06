
namespace ServiPlusApp.View.Factura
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.pnlContenedor = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlBarraSuperior = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pnlBarraControl = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnEliminar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnCerrar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlBarraControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContenedor.BackgroundImage")));
            this.pnlContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContenedor.BorderColor = System.Drawing.Color.Transparent;
            this.pnlContenedor.BorderRadius = 3;
            this.pnlContenedor.BorderThickness = 1;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.ShowBorders = true;
            this.pnlContenedor.Size = new System.Drawing.Size(1220, 793);
            this.pnlContenedor.TabIndex = 1;
            this.pnlContenedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraSuperior_MouseDown);
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.BackColor = System.Drawing.Color.Transparent;
            this.pnlBarraSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBarraSuperior.BackgroundImage")));
            this.pnlBarraSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBarraSuperior.BorderRadius = 1;
            this.pnlBarraSuperior.Controls.Add(this.btnMinimizar);
            this.pnlBarraSuperior.Controls.Add(this.btnClose);
            this.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSuperior.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.pnlBarraSuperior.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlBarraSuperior.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlBarraSuperior.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(84)))), ((int)(((byte)(30)))));
            this.pnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Quality = 10;
            this.pnlBarraSuperior.Size = new System.Drawing.Size(1220, 47);
            this.pnlBarraSuperior.TabIndex = 3;
            this.pnlBarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraSuperior_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1132, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1173, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlBarraControl
            // 
            this.pnlBarraControl.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlBarraControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBarraControl.BackgroundImage")));
            this.pnlBarraControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBarraControl.BorderColor = System.Drawing.Color.Transparent;
            this.pnlBarraControl.BorderRadius = 3;
            this.pnlBarraControl.BorderThickness = 1;
            this.pnlBarraControl.Controls.Add(this.btnCerrar);
            this.pnlBarraControl.Controls.Add(this.btnEliminar);
            this.pnlBarraControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBarraControl.Location = new System.Drawing.Point(0, 693);
            this.pnlBarraControl.Name = "pnlBarraControl";
            this.pnlBarraControl.ShowBorders = true;
            this.pnlBarraControl.Size = new System.Drawing.Size(1220, 100);
            this.pnlBarraControl.TabIndex = 4;
            this.pnlBarraControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraSuperior_MouseDown);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AllowAnimations = true;
            this.btnEliminar.AllowMouseEffects = true;
            this.btnEliminar.AllowToggling = false;
            this.btnEliminar.AnimationSpeed = 200;
            this.btnEliminar.AutoGenerateColors = false;
            this.btnEliminar.AutoRoundBorders = false;
            this.btnEliminar.AutoSizeLeftIcon = true;
            this.btnEliminar.AutoSizeRightIcon = true;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.ButtonTextMarginLeft = 0;
            this.btnEliminar.ColorContrastOnClick = 45;
            this.btnEliminar.ColorContrastOnHover = 45;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnEliminar.CustomizableEdges = borderEdges2;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEliminar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEliminar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEliminar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnEliminar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEliminar.IconMarginLeft = 11;
            this.btnEliminar.IconPadding = 10;
            this.btnEliminar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnEliminar.IdleBorderRadius = 3;
            this.btnEliminar.IdleBorderThickness = 2;
            this.btnEliminar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEliminar.IdleIconLeftImage = null;
            this.btnEliminar.IdleIconRightImage = null;
            this.btnEliminar.IndicateFocus = false;
            this.btnEliminar.Location = new System.Drawing.Point(1058, 1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEliminar.OnDisabledState.BorderRadius = 3;
            this.btnEliminar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEliminar.OnDisabledState.BorderThickness = 2;
            this.btnEliminar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEliminar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEliminar.OnDisabledState.IconLeftImage = null;
            this.btnEliminar.OnDisabledState.IconRightImage = null;
            this.btnEliminar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.onHoverState.BorderRadius = 3;
            this.btnEliminar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEliminar.onHoverState.BorderThickness = 2;
            this.btnEliminar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.onHoverState.IconLeftImage = null;
            this.btnEliminar.onHoverState.IconRightImage = null;
            this.btnEliminar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnEliminar.OnIdleState.BorderRadius = 3;
            this.btnEliminar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEliminar.OnIdleState.BorderThickness = 2;
            this.btnEliminar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEliminar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnIdleState.IconLeftImage = null;
            this.btnEliminar.OnIdleState.IconRightImage = null;
            this.btnEliminar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEliminar.OnPressedState.BorderRadius = 3;
            this.btnEliminar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEliminar.OnPressedState.BorderThickness = 2;
            this.btnEliminar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEliminar.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.OnPressedState.IconLeftImage = null;
            this.btnEliminar.OnPressedState.IconRightImage = null;
            this.btnEliminar.Size = new System.Drawing.Size(150, 50);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.TextMarginLeft = 0;
            this.btnEliminar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEliminar.UseDefaultRadiusAndThickness = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.AllowAnimations = true;
            this.btnCerrar.AllowMouseEffects = true;
            this.btnCerrar.AllowToggling = false;
            this.btnCerrar.AnimationSpeed = 200;
            this.btnCerrar.AutoGenerateColors = false;
            this.btnCerrar.AutoRoundBorders = false;
            this.btnCerrar.AutoSizeLeftIcon = true;
            this.btnCerrar.AutoSizeRightIcon = true;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCerrar.ButtonText = "Cerrar";
            this.btnCerrar.ButtonTextMarginLeft = 0;
            this.btnCerrar.ColorContrastOnClick = 45;
            this.btnCerrar.ColorContrastOnHover = 45;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCerrar.CustomizableEdges = borderEdges1;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCerrar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCerrar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCerrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnCerrar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCerrar.IconMarginLeft = 11;
            this.btnCerrar.IconPadding = 10;
            this.btnCerrar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnCerrar.IdleBorderRadius = 3;
            this.btnCerrar.IdleBorderThickness = 2;
            this.btnCerrar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCerrar.IdleIconLeftImage = null;
            this.btnCerrar.IdleIconRightImage = null;
            this.btnCerrar.IndicateFocus = false;
            this.btnCerrar.Location = new System.Drawing.Point(1058, 51);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCerrar.OnDisabledState.BorderRadius = 3;
            this.btnCerrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCerrar.OnDisabledState.BorderThickness = 2;
            this.btnCerrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCerrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCerrar.OnDisabledState.IconLeftImage = null;
            this.btnCerrar.OnDisabledState.IconRightImage = null;
            this.btnCerrar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.onHoverState.BorderRadius = 3;
            this.btnCerrar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCerrar.onHoverState.BorderThickness = 2;
            this.btnCerrar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.onHoverState.IconLeftImage = null;
            this.btnCerrar.onHoverState.IconRightImage = null;
            this.btnCerrar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnCerrar.OnIdleState.BorderRadius = 3;
            this.btnCerrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCerrar.OnIdleState.BorderThickness = 2;
            this.btnCerrar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCerrar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnIdleState.IconLeftImage = null;
            this.btnCerrar.OnIdleState.IconRightImage = null;
            this.btnCerrar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCerrar.OnPressedState.BorderRadius = 3;
            this.btnCerrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCerrar.OnPressedState.BorderThickness = 2;
            this.btnCerrar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCerrar.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.OnPressedState.IconLeftImage = null;
            this.btnCerrar.OnPressedState.IconRightImage = null;
            this.btnCerrar.Size = new System.Drawing.Size(150, 50);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerrar.TextMarginLeft = 0;
            this.btnCerrar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCerrar.UseDefaultRadiusAndThickness = true;
            // 
            // Factura
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1220, 793);
            this.Controls.Add(this.pnlBarraControl);
            this.Controls.Add(this.pnlBarraSuperior);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura";
            this.Text = "Factura";
            this.pnlBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlBarraControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlContenedor;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnlBarraSuperior;
        private Bunifu.UI.WinForms.BunifuPanel pnlBarraControl;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnCerrar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnEliminar;
    }
}