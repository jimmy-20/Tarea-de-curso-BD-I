
namespace ServiPlusApp.View.Set_Tables.Usuarios
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txtNombres = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtApellidos = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtTelefono = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtEspecialidad = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDatosUsuario = new System.Windows.Forms.Panel();
            this.cmbEspecialidad = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnContinuar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.cmbRol = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cmbEstado = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnRegresar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnGuardar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new RJCodeAdvance.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContraseña = new RJCodeAdvance.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstado = new RJCodeAdvance.RJControls.RJTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRol = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnModificar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lblMode = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlDatosUsuario.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnClose);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(743, 50);
            this.bunifuPanel1.TabIndex = 1;
            this.bunifuPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(709, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.txtNombres.BorderColor = System.Drawing.Color.White;
            this.txtNombres.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(62)))), ((int)(((byte)(109)))));
            this.txtNombres.BorderRadius = 0;
            this.txtNombres.BorderSize = 5;
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.White;
            this.txtNombres.Location = new System.Drawing.Point(176, 30);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.Multiline = false;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombres.PasswordChar = false;
            this.txtNombres.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombres.PlaceholderText = "Nombres";
            this.txtNombres.Size = new System.Drawing.Size(405, 45);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.Texts = "";
            this.txtNombres.UnderlinedStyle = true;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.txtApellidos.BorderColor = System.Drawing.Color.White;
            this.txtApellidos.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(62)))), ((int)(((byte)(109)))));
            this.txtApellidos.BorderRadius = 0;
            this.txtApellidos.BorderSize = 5;
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.White;
            this.txtApellidos.Location = new System.Drawing.Point(176, 109);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Multiline = false;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellidos.PasswordChar = false;
            this.txtApellidos.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidos.PlaceholderText = "Apellidos";
            this.txtApellidos.Size = new System.Drawing.Size(405, 45);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.Texts = "";
            this.txtApellidos.UnderlinedStyle = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.txtTelefono.BorderColor = System.Drawing.Color.White;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(62)))), ((int)(((byte)(109)))));
            this.txtTelefono.BorderRadius = 0;
            this.txtTelefono.BorderSize = 5;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(176, 239);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.PlaceholderText = "0000-0000";
            this.txtTelefono.Size = new System.Drawing.Size(245, 45);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlinedStyle = true;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.txtEspecialidad.BorderColor = System.Drawing.Color.White;
            this.txtEspecialidad.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(62)))), ((int)(((byte)(109)))));
            this.txtEspecialidad.BorderRadius = 0;
            this.txtEspecialidad.BorderSize = 5;
            this.txtEspecialidad.Enabled = false;
            this.txtEspecialidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEspecialidad.Location = new System.Drawing.Point(176, 173);
            this.txtEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEspecialidad.Multiline = false;
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEspecialidad.PasswordChar = false;
            this.txtEspecialidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEspecialidad.PlaceholderText = "";
            this.txtEspecialidad.Size = new System.Drawing.Size(280, 45);
            this.txtEspecialidad.TabIndex = 3;
            this.txtEspecialidad.Texts = "";
            this.txtEspecialidad.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "NOMBRES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "APELLIDOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "ESPECIALIDAD";
            // 
            // pnlDatosUsuario
            // 
            this.pnlDatosUsuario.Controls.Add(this.cmbEspecialidad);
            this.pnlDatosUsuario.Controls.Add(this.btnContinuar);
            this.pnlDatosUsuario.Controls.Add(this.label1);
            this.pnlDatosUsuario.Controls.Add(this.txtNombres);
            this.pnlDatosUsuario.Controls.Add(this.label4);
            this.pnlDatosUsuario.Controls.Add(this.txtApellidos);
            this.pnlDatosUsuario.Controls.Add(this.label3);
            this.pnlDatosUsuario.Controls.Add(this.txtTelefono);
            this.pnlDatosUsuario.Controls.Add(this.label2);
            this.pnlDatosUsuario.Controls.Add(this.txtEspecialidad);
            this.pnlDatosUsuario.Location = new System.Drawing.Point(67, 122);
            this.pnlDatosUsuario.Name = "pnlDatosUsuario";
            this.pnlDatosUsuario.Size = new System.Drawing.Size(602, 385);
            this.pnlDatosUsuario.TabIndex = 1;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.cmbEspecialidad.BackgroundColor = System.Drawing.Color.Transparent;
            this.cmbEspecialidad.BorderColor = System.Drawing.Color.Transparent;
            this.cmbEspecialidad.BorderRadius = 1;
            this.cmbEspecialidad.Color = System.Drawing.Color.Transparent;
            this.cmbEspecialidad.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbEspecialidad.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbEspecialidad.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbEspecialidad.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbEspecialidad.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbEspecialidad.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbEspecialidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEspecialidad.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbEspecialidad.FillDropDown = true;
            this.cmbEspecialidad.FillIndicator = true;
            this.cmbEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEspecialidad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbEspecialidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Icon = null;
            this.cmbEspecialidad.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbEspecialidad.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.cmbEspecialidad.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbEspecialidad.IndicatorThickness = 2;
            this.cmbEspecialidad.IsDropdownOpened = false;
            this.cmbEspecialidad.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbEspecialidad.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbEspecialidad.ItemForeColor = System.Drawing.Color.White;
            this.cmbEspecialidad.ItemHeight = 29;
            this.cmbEspecialidad.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(62)))), ((int)(((byte)(109)))));
            this.cmbEspecialidad.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbEspecialidad.ItemTopMargin = 3;
            this.cmbEspecialidad.Location = new System.Drawing.Point(176, 171);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(280, 35);
            this.cmbEspecialidad.TabIndex = 22;
            this.cmbEspecialidad.Text = "Rol";
            this.cmbEspecialidad.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbEspecialidad.TextLeftMargin = 5;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            this.cmbEspecialidad.Enter += new System.EventHandler(this.cmbEspecialidad_Enter);
            this.cmbEspecialidad.Leave += new System.EventHandler(this.cmbEspecialidad_Leave);
            // 
            // btnContinuar
            // 
            this.btnContinuar.AllowAnimations = true;
            this.btnContinuar.AllowMouseEffects = true;
            this.btnContinuar.AllowToggling = false;
            this.btnContinuar.AnimationSpeed = 200;
            this.btnContinuar.AutoGenerateColors = false;
            this.btnContinuar.AutoRoundBorders = false;
            this.btnContinuar.AutoSizeLeftIcon = true;
            this.btnContinuar.AutoSizeRightIcon = true;
            this.btnContinuar.BackColor = System.Drawing.Color.Transparent;
            this.btnContinuar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnContinuar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContinuar.BackgroundImage")));
            this.btnContinuar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnContinuar.ButtonText = "Continuar";
            this.btnContinuar.ButtonTextMarginLeft = 0;
            this.btnContinuar.ColorContrastOnClick = 45;
            this.btnContinuar.ColorContrastOnHover = 45;
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnContinuar.CustomizableEdges = borderEdges1;
            this.btnContinuar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnContinuar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnContinuar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnContinuar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnContinuar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnContinuar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinuar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnContinuar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnContinuar.IconMarginLeft = 11;
            this.btnContinuar.IconPadding = 10;
            this.btnContinuar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContinuar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnContinuar.IconSize = 25;
            this.btnContinuar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnContinuar.IdleBorderRadius = 1;
            this.btnContinuar.IdleBorderThickness = 2;
            this.btnContinuar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnContinuar.IdleIconLeftImage = null;
            this.btnContinuar.IdleIconRightImage = ((System.Drawing.Image)(resources.GetObject("btnContinuar.IdleIconRightImage")));
            this.btnContinuar.IndicateFocus = false;
            this.btnContinuar.Location = new System.Drawing.Point(209, 332);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnContinuar.OnDisabledState.BorderRadius = 1;
            this.btnContinuar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnContinuar.OnDisabledState.BorderThickness = 2;
            this.btnContinuar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnContinuar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnContinuar.OnDisabledState.IconLeftImage = null;
            this.btnContinuar.OnDisabledState.IconRightImage = null;
            this.btnContinuar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(133)))), ((int)(((byte)(128)))));
            this.btnContinuar.onHoverState.BorderRadius = 1;
            this.btnContinuar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnContinuar.onHoverState.BorderThickness = 2;
            this.btnContinuar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(133)))), ((int)(((byte)(128)))));
            this.btnContinuar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.onHoverState.IconLeftImage = null;
            this.btnContinuar.onHoverState.IconRightImage = null;
            this.btnContinuar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnContinuar.OnIdleState.BorderRadius = 1;
            this.btnContinuar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnContinuar.OnIdleState.BorderThickness = 2;
            this.btnContinuar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnContinuar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.OnIdleState.IconLeftImage = null;
            this.btnContinuar.OnIdleState.IconRightImage = ((System.Drawing.Image)(resources.GetObject("btnContinuar.OnIdleState.IconRightImage")));
            this.btnContinuar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(133)))), ((int)(((byte)(128)))));
            this.btnContinuar.OnPressedState.BorderRadius = 1;
            this.btnContinuar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnContinuar.OnPressedState.BorderThickness = 2;
            this.btnContinuar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(133)))), ((int)(((byte)(128)))));
            this.btnContinuar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.OnPressedState.IconLeftImage = null;
            this.btnContinuar.OnPressedState.IconRightImage = null;
            this.btnContinuar.Size = new System.Drawing.Size(200, 39);
            this.btnContinuar.TabIndex = 5;
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnContinuar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnContinuar.TextMarginLeft = 0;
            this.btnContinuar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnContinuar.UseDefaultRadiusAndThickness = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsuario.Controls.Add(this.cmbRol);
            this.pnlUsuario.Controls.Add(this.cmbEstado);
            this.pnlUsuario.Controls.Add(this.btnRegresar);
            this.pnlUsuario.Controls.Add(this.btnGuardar);
            this.pnlUsuario.Controls.Add(this.label5);
            this.pnlUsuario.Controls.Add(this.txtUsername);
            this.pnlUsuario.Controls.Add(this.label6);
            this.pnlUsuario.Controls.Add(this.txtContraseña);
            this.pnlUsuario.Controls.Add(this.label7);
            this.pnlUsuario.Controls.Add(this.txtEstado);
            this.pnlUsuario.Controls.Add(this.label8);
            this.pnlUsuario.Controls.Add(this.txtRol);
            this.pnlUsuario.Controls.Add(this.btnModificar);
            this.pnlUsuario.Location = new System.Drawing.Point(66, 129);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(605, 376);
            this.pnlUsuario.TabIndex = 1;
            this.pnlUsuario.Visible = false;
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.Transparent;
            this.cmbRol.BackgroundColor = System.Drawing.Color.Transparent;
            this.cmbRol.BorderColor = System.Drawing.Color.Transparent;
            this.cmbRol.BorderRadius = 1;
            this.cmbRol.Color = System.Drawing.Color.Transparent;
            this.cmbRol.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbRol.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbRol.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbRol.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbRol.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbRol.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRol.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbRol.FillDropDown = true;
            this.cmbRol.FillIndicator = true;
            this.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRol.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Icon = null;
            this.cmbRol.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbRol.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.cmbRol.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbRol.IndicatorThickness = 2;
            this.cmbRol.IsDropdownOpened = false;
            this.cmbRol.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbRol.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbRol.ItemForeColor = System.Drawing.Color.White;
            this.cmbRol.ItemHeight = 29;
            this.cmbRol.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(62)))), ((int)(((byte)(109)))));
            this.cmbRol.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbRol.ItemTopMargin = 3;
            this.cmbRol.Location = new System.Drawing.Point(192, 167);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(245, 35);
            this.cmbRol.TabIndex = 21;
            this.cmbRol.Text = "Rol";
            this.cmbRol.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbRol.TextLeftMargin = 5;
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstado.BackgroundColor = System.Drawing.Color.Transparent;
            this.cmbEstado.BorderColor = System.Drawing.Color.Transparent;
            this.cmbEstado.BorderRadius = 1;
            this.cmbEstado.Color = System.Drawing.Color.Transparent;
            this.cmbEstado.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbEstado.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbEstado.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbEstado.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbEstado.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbEstado.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstado.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbEstado.FillDropDown = true;
            this.cmbEstado.FillIndicator = true;
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstado.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Icon = null;
            this.cmbEstado.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbEstado.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.cmbEstado.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbEstado.IndicatorThickness = 2;
            this.cmbEstado.IsDropdownOpened = false;
            this.cmbEstado.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbEstado.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbEstado.ItemForeColor = System.Drawing.Color.White;
            this.cmbEstado.ItemHeight = 29;
            this.cmbEstado.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(62)))), ((int)(((byte)(109)))));
            this.cmbEstado.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbEstado.ItemTopMargin = 3;
            this.cmbEstado.Location = new System.Drawing.Point(193, 233);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(245, 35);
            this.cmbEstado.TabIndex = 20;
            this.cmbEstado.Text = "Estado";
            this.cmbEstado.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbEstado.TextLeftMargin = 5;
            // 
            // btnRegresar
            // 
            this.btnRegresar.AllowAnimations = true;
            this.btnRegresar.AllowMouseEffects = true;
            this.btnRegresar.AllowToggling = false;
            this.btnRegresar.AnimationSpeed = 200;
            this.btnRegresar.AutoGenerateColors = false;
            this.btnRegresar.AutoRoundBorders = false;
            this.btnRegresar.AutoSizeLeftIcon = true;
            this.btnRegresar.AutoSizeRightIcon = true;
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRegresar.ButtonText = "Regresar";
            this.btnRegresar.ButtonTextMarginLeft = 0;
            this.btnRegresar.ColorContrastOnClick = 45;
            this.btnRegresar.ColorContrastOnHover = 45;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnRegresar.CustomizableEdges = borderEdges2;
            this.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegresar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegresar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegresar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegresar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnRegresar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRegresar.IconMarginLeft = 11;
            this.btnRegresar.IconPadding = 10;
            this.btnRegresar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRegresar.IconSize = 25;
            this.btnRegresar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegresar.IdleBorderRadius = 1;
            this.btnRegresar.IdleBorderThickness = 2;
            this.btnRegresar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnRegresar.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.IdleIconLeftImage")));
            this.btnRegresar.IdleIconRightImage = null;
            this.btnRegresar.IndicateFocus = false;
            this.btnRegresar.Location = new System.Drawing.Point(137, 332);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegresar.OnDisabledState.BorderRadius = 1;
            this.btnRegresar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRegresar.OnDisabledState.BorderThickness = 2;
            this.btnRegresar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegresar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegresar.OnDisabledState.IconLeftImage = null;
            this.btnRegresar.OnDisabledState.IconRightImage = null;
            this.btnRegresar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(133)))), ((int)(((byte)(128)))));
            this.btnRegresar.onHoverState.BorderRadius = 1;
            this.btnRegresar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRegresar.onHoverState.BorderThickness = 2;
            this.btnRegresar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(133)))), ((int)(((byte)(128)))));
            this.btnRegresar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.onHoverState.IconLeftImage = null;
            this.btnRegresar.onHoverState.IconRightImage = null;
            this.btnRegresar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegresar.OnIdleState.BorderRadius = 1;
            this.btnRegresar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRegresar.OnIdleState.BorderThickness = 2;
            this.btnRegresar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnRegresar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.OnIdleState.IconLeftImage")));
            this.btnRegresar.OnIdleState.IconRightImage = null;
            this.btnRegresar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(133)))), ((int)(((byte)(128)))));
            this.btnRegresar.OnPressedState.BorderRadius = 1;
            this.btnRegresar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnRegresar.OnPressedState.BorderThickness = 2;
            this.btnRegresar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(133)))), ((int)(((byte)(128)))));
            this.btnRegresar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.OnPressedState.IconLeftImage = null;
            this.btnRegresar.OnPressedState.IconRightImage = null;
            this.btnRegresar.Size = new System.Drawing.Size(170, 39);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegresar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegresar.TextMarginLeft = 0;
            this.btnRegresar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRegresar.UseDefaultRadiusAndThickness = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AllowAnimations = true;
            this.btnGuardar.AllowMouseEffects = true;
            this.btnGuardar.AllowToggling = false;
            this.btnGuardar.AnimationSpeed = 200;
            this.btnGuardar.AutoGenerateColors = false;
            this.btnGuardar.AutoRoundBorders = false;
            this.btnGuardar.AutoSizeLeftIcon = true;
            this.btnGuardar.AutoSizeRightIcon = true;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.ButtonTextMarginLeft = 0;
            this.btnGuardar.ColorContrastOnClick = 45;
            this.btnGuardar.ColorContrastOnHover = 45;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnGuardar.CustomizableEdges = borderEdges3;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGuardar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGuardar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGuardar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnGuardar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnGuardar.IconMarginLeft = 11;
            this.btnGuardar.IconPadding = 10;
            this.btnGuardar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGuardar.IconSize = 25;
            this.btnGuardar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGuardar.IdleBorderRadius = 1;
            this.btnGuardar.IdleBorderThickness = 2;
            this.btnGuardar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnGuardar.IdleIconLeftImage = null;
            this.btnGuardar.IdleIconRightImage = null;
            this.btnGuardar.IndicateFocus = false;
            this.btnGuardar.Location = new System.Drawing.Point(314, 332);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGuardar.OnDisabledState.BorderRadius = 1;
            this.btnGuardar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGuardar.OnDisabledState.BorderThickness = 2;
            this.btnGuardar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGuardar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGuardar.OnDisabledState.IconLeftImage = null;
            this.btnGuardar.OnDisabledState.IconRightImage = null;
            this.btnGuardar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGuardar.onHoverState.BorderRadius = 1;
            this.btnGuardar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGuardar.onHoverState.BorderThickness = 2;
            this.btnGuardar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGuardar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.onHoverState.IconLeftImage = null;
            this.btnGuardar.onHoverState.IconRightImage = null;
            this.btnGuardar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGuardar.OnIdleState.BorderRadius = 1;
            this.btnGuardar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGuardar.OnIdleState.BorderThickness = 2;
            this.btnGuardar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnGuardar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnIdleState.IconLeftImage = null;
            this.btnGuardar.OnIdleState.IconRightImage = null;
            this.btnGuardar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGuardar.OnPressedState.BorderRadius = 1;
            this.btnGuardar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGuardar.OnPressedState.BorderThickness = 2;
            this.btnGuardar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGuardar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnPressedState.IconLeftImage = null;
            this.btnGuardar.OnPressedState.IconRightImage = null;
            this.btnGuardar.Size = new System.Drawing.Size(170, 39);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.TextMarginLeft = 0;
            this.btnGuardar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGuardar.UseDefaultRadiusAndThickness = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.label5.Location = new System.Drawing.Point(61, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "USERNAME";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.txtUsername.BorderColor = System.Drawing.Color.Lavender;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(62)))), ((int)(((byte)(109)))));
            this.txtUsername.BorderRadius = 0;
            this.txtUsername.BorderSize = 5;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(193, 24);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(370, 45);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.label6.Location = new System.Drawing.Point(121, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "ROL";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.txtContraseña.BorderColor = System.Drawing.Color.Lavender;
            this.txtContraseña.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(62)))), ((int)(((byte)(109)))));
            this.txtContraseña.BorderRadius = 0;
            this.txtContraseña.BorderSize = 5;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.Location = new System.Drawing.Point(193, 103);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContraseña.PasswordChar = false;
            this.txtContraseña.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContraseña.PlaceholderText = "Contraseña";
            this.txtContraseña.Size = new System.Drawing.Size(370, 45);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Texts = "";
            this.txtContraseña.UnderlinedStyle = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.label7.Location = new System.Drawing.Point(82, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 35);
            this.label7.TabIndex = 12;
            this.label7.Text = "ESTADO";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.txtEstado.BorderColor = System.Drawing.Color.Lavender;
            this.txtEstado.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(62)))), ((int)(((byte)(109)))));
            this.txtEstado.BorderRadius = 0;
            this.txtEstado.BorderSize = 5;
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEstado.Location = new System.Drawing.Point(193, 233);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEstado.PasswordChar = false;
            this.txtEstado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEstado.PlaceholderText = "";
            this.txtEstado.Size = new System.Drawing.Size(245, 45);
            this.txtEstado.TabIndex = 4;
            this.txtEstado.Texts = "";
            this.txtEstado.UnderlinedStyle = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 13.8F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.label8.Location = new System.Drawing.Point(35, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 35);
            this.label8.TabIndex = 11;
            this.label8.Text = "CONTRASEÑA";
            // 
            // txtRol
            // 
            this.txtRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.txtRol.BorderColor = System.Drawing.Color.Lavender;
            this.txtRol.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(62)))), ((int)(((byte)(109)))));
            this.txtRol.BorderRadius = 0;
            this.txtRol.BorderSize = 5;
            this.txtRol.Enabled = false;
            this.txtRol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRol.Location = new System.Drawing.Point(193, 167);
            this.txtRol.Margin = new System.Windows.Forms.Padding(4);
            this.txtRol.Multiline = false;
            this.txtRol.Name = "txtRol";
            this.txtRol.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRol.PasswordChar = false;
            this.txtRol.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRol.PlaceholderText = "";
            this.txtRol.Size = new System.Drawing.Size(245, 45);
            this.txtRol.TabIndex = 3;
            this.txtRol.Texts = "";
            this.txtRol.UnderlinedStyle = true;
            // 
            // btnModificar
            // 
            this.btnModificar.AllowAnimations = true;
            this.btnModificar.AllowMouseEffects = true;
            this.btnModificar.AllowToggling = false;
            this.btnModificar.AnimationSpeed = 200;
            this.btnModificar.AutoGenerateColors = false;
            this.btnModificar.AutoRoundBorders = false;
            this.btnModificar.AutoSizeLeftIcon = true;
            this.btnModificar.AutoSizeRightIcon = true;
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnModificar.ButtonText = "Modificar";
            this.btnModificar.ButtonTextMarginLeft = 0;
            this.btnModificar.ColorContrastOnClick = 45;
            this.btnModificar.ColorContrastOnHover = 45;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnModificar.CustomizableEdges = borderEdges4;
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnModificar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnModificar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnModificar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnModificar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnModificar.IconMarginLeft = 11;
            this.btnModificar.IconPadding = 10;
            this.btnModificar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnModificar.IconSize = 25;
            this.btnModificar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.IdleBorderRadius = 1;
            this.btnModificar.IdleBorderThickness = 1;
            this.btnModificar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.IdleIconLeftImage = null;
            this.btnModificar.IdleIconRightImage = null;
            this.btnModificar.IndicateFocus = false;
            this.btnModificar.Location = new System.Drawing.Point(314, 332);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnModificar.OnDisabledState.BorderRadius = 1;
            this.btnModificar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnModificar.OnDisabledState.BorderThickness = 1;
            this.btnModificar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnModificar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnModificar.OnDisabledState.IconLeftImage = null;
            this.btnModificar.OnDisabledState.IconRightImage = null;
            this.btnModificar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnModificar.onHoverState.BorderRadius = 1;
            this.btnModificar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnModificar.onHoverState.BorderThickness = 1;
            this.btnModificar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnModificar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnModificar.onHoverState.IconLeftImage = null;
            this.btnModificar.onHoverState.IconRightImage = null;
            this.btnModificar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.OnIdleState.BorderRadius = 1;
            this.btnModificar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnModificar.OnIdleState.BorderThickness = 1;
            this.btnModificar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnModificar.OnIdleState.IconLeftImage = null;
            this.btnModificar.OnIdleState.IconRightImage = null;
            this.btnModificar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnModificar.OnPressedState.BorderRadius = 1;
            this.btnModificar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnModificar.OnPressedState.BorderThickness = 1;
            this.btnModificar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnModificar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnModificar.OnPressedState.IconLeftImage = null;
            this.btnModificar.OnPressedState.IconRightImage = null;
            this.btnModificar.Size = new System.Drawing.Size(170, 39);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificar.TextMarginLeft = 0;
            this.btnModificar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnModificar.UseDefaultRadiusAndThickness = true;
            this.btnModificar.Visible = false;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.Silver;
            this.lblMode.Location = new System.Drawing.Point(60, 66);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(375, 43);
            this.lblMode.TabIndex = 18;
            this.lblMode.Text = "Registrar Usuario";
            // 
            // Usuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(743, 522);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.pnlDatosUsuario);
            this.Controls.Add(this.pnlUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuario";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlDatosUsuario.ResumeLayout(false);
            this.pnlDatosUsuario.PerformLayout();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        public System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDatosUsuario;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnContinuar;
        private System.Windows.Forms.Panel pnlUsuario;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnRegresar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public RJCodeAdvance.RJControls.RJTextBox txtEstado;
        private System.Windows.Forms.Label label8;
        public RJCodeAdvance.RJControls.RJTextBox txtRol;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnModificar;
        private System.Windows.Forms.Label lblMode;
        public Bunifu.UI.WinForms.BunifuDropdown cmbEspecialidad;
        public RJCodeAdvance.RJControls.RJTextBox txtNombres;
        public RJCodeAdvance.RJControls.RJTextBox txtApellidos;
        public RJCodeAdvance.RJControls.RJTextBox txtTelefono;
        public RJCodeAdvance.RJControls.RJTextBox txtEspecialidad;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnGuardar;
        public RJCodeAdvance.RJControls.RJTextBox txtUsername;
        public RJCodeAdvance.RJControls.RJTextBox txtContraseña;
        public Bunifu.UI.WinForms.BunifuDropdown cmbEstado;
        public Bunifu.UI.WinForms.BunifuDropdown cmbRol;
    }
}