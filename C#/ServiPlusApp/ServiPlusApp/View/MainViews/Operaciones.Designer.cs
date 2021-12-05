
namespace ServiPlusApp.View
{
    partial class Operaciones
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation3 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operaciones));
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.pnlMenuContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCatalogos = new System.Windows.Forms.Button();
            this.MnCatalogos = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnMecanicos = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.MnOperaciones = new System.Windows.Forms.Panel();
            this.btnOpRepuestos = new System.Windows.Forms.Button();
            this.btnOpMantenimientos = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.MnReportes = new System.Windows.Forms.Panel();
            this.btnRecaudaciones = new System.Windows.Forms.Button();
            this.btnReMantenimientos = new System.Windows.Forms.Button();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.Mnseguridad = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.pbUsuario = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.btnSlide = new FontAwesome.Sharp.IconPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.btnCaRepuestos = new System.Windows.Forms.Button();
            this.SubMnRecaudaciones = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlMenuVertical.SuspendLayout();
            this.pnlMenuContenedor.SuspendLayout();
            this.MnCatalogos.SuspendLayout();
            this.MnOperaciones.SuspendLayout();
            this.MnReportes.SuspendLayout();
            this.Mnseguridad.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.SubMnRecaudaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlMenuVertical.Controls.Add(this.pnlMenuContenedor);
            this.pnlMenuVertical.Controls.Add(this.splitter1);
            this.pnlMenuVertical.Controls.Add(this.pnlUsuario);
            this.bunifuTransition1.SetDecoration(this.pnlMenuVertical, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(270, 903);
            this.pnlMenuVertical.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.pnlMenuVertical, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pnlMenuVertical, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pnlMenuVertical, "");
            this.pnlMenuVertical.SizeChanged += new System.EventHandler(this.pnlMenuVertical_SizeChanged);
            // 
            // pnlMenuContenedor
            // 
            this.pnlMenuContenedor.Controls.Add(this.btnCatalogos);
            this.pnlMenuContenedor.Controls.Add(this.MnCatalogos);
            this.pnlMenuContenedor.Controls.Add(this.btnOperaciones);
            this.pnlMenuContenedor.Controls.Add(this.MnOperaciones);
            this.pnlMenuContenedor.Controls.Add(this.btnReportes);
            this.pnlMenuContenedor.Controls.Add(this.MnReportes);
            this.pnlMenuContenedor.Controls.Add(this.btnSeguridad);
            this.pnlMenuContenedor.Controls.Add(this.Mnseguridad);
            this.bunifuTransition1.SetDecoration(this.pnlMenuContenedor, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlMenuContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuContenedor.Location = new System.Drawing.Point(0, 80);
            this.pnlMenuContenedor.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlMenuContenedor.Name = "pnlMenuContenedor";
            this.pnlMenuContenedor.Size = new System.Drawing.Size(270, 823);
            this.pnlMenuContenedor.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.pnlMenuContenedor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pnlMenuContenedor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pnlMenuContenedor, "");
            this.pnlMenuContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainDesk_MouseDown);
            // 
            // btnCatalogos
            // 
            this.btnCatalogos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.btnCatalogos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogos.FlatAppearance.BorderSize = 0;
            this.btnCatalogos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCatalogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogos.ForeColor = System.Drawing.Color.White;
            this.btnCatalogos.Image = global::ServiPlusApp.Properties.Resources.catalogo_de_colores;
            this.btnCatalogos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogos.Location = new System.Drawing.Point(0, 10);
            this.btnCatalogos.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.btnCatalogos.Name = "btnCatalogos";
            this.btnCatalogos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCatalogos.Size = new System.Drawing.Size(270, 45);
            this.btnCatalogos.TabIndex = 6;
            this.btnCatalogos.Tag = "Catalogos";
            this.btnCatalogos.Text = "     Catálogos";
            this.btnCatalogos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnCatalogos, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnCatalogos, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnCatalogos, "");
            this.btnCatalogos.UseVisualStyleBackColor = false;
            this.btnCatalogos.Click += new System.EventHandler(this.btnCatalogos_Click);
            // 
            // MnCatalogos
            // 
            this.MnCatalogos.Controls.Add(this.btnCaRepuestos);
            this.MnCatalogos.Controls.Add(this.btnClientes);
            this.MnCatalogos.Controls.Add(this.btnServicios);
            this.MnCatalogos.Controls.Add(this.btnMecanicos);
            this.MnCatalogos.Controls.Add(this.btnVehiculos);
            this.bunifuTransition1.SetDecoration(this.MnCatalogos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.MnCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.MnCatalogos.Location = new System.Drawing.Point(50, 61);
            this.MnCatalogos.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.MnCatalogos.Name = "MnCatalogos";
            this.MnCatalogos.Size = new System.Drawing.Size(220, 225);
            this.MnCatalogos.TabIndex = 8;
            this.bunifuToolTip1.SetToolTip(this.MnCatalogos, "");
            this.bunifuToolTip1.SetToolTipIcon(this.MnCatalogos, null);
            this.bunifuToolTip1.SetToolTipTitle(this.MnCatalogos, "");
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.btnClientes, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::ServiPlusApp.Properties.Resources.grupo;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 135);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(220, 45);
            this.btnClientes.TabIndex = 8;
            this.btnClientes.Tag = "Clientes";
            this.btnClientes.Text = "    Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnClientes, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnClientes, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnClientes, "");
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.btnServicios, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.ForeColor = System.Drawing.Color.White;
            this.btnServicios.Image = global::ServiPlusApp.Properties.Resources.reparar;
            this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.Location = new System.Drawing.Point(0, 90);
            this.btnServicios.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(220, 45);
            this.btnServicios.TabIndex = 7;
            this.btnServicios.Tag = "Servicios";
            this.btnServicios.Text = "    Servicios";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnServicios, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnServicios, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnServicios, "");
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnMecanicos
            // 
            this.btnMecanicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.btnMecanicos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnMecanicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMecanicos.FlatAppearance.BorderSize = 0;
            this.btnMecanicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMecanicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMecanicos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMecanicos.ForeColor = System.Drawing.Color.White;
            this.btnMecanicos.Image = global::ServiPlusApp.Properties.Resources.mecanico;
            this.btnMecanicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMecanicos.Location = new System.Drawing.Point(0, 45);
            this.btnMecanicos.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnMecanicos.Name = "btnMecanicos";
            this.btnMecanicos.Size = new System.Drawing.Size(220, 45);
            this.btnMecanicos.TabIndex = 5;
            this.btnMecanicos.Tag = "Mecanicos";
            this.btnMecanicos.Text = "    Mecanicos";
            this.btnMecanicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMecanicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnMecanicos, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnMecanicos, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnMecanicos, "");
            this.btnMecanicos.UseVisualStyleBackColor = false;
            this.btnMecanicos.Click += new System.EventHandler(this.btnMecanicos_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.btnVehiculos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiculos.FlatAppearance.BorderSize = 0;
            this.btnVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculos.ForeColor = System.Drawing.Color.White;
            this.btnVehiculos.Image = global::ServiPlusApp.Properties.Resources.coche;
            this.btnVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculos.Location = new System.Drawing.Point(0, 0);
            this.btnVehiculos.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(220, 45);
            this.btnVehiculos.TabIndex = 6;
            this.btnVehiculos.Tag = "Vehiculos";
            this.btnVehiculos.Text = "    Vehiculos";
            this.btnVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnVehiculos, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnVehiculos, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnVehiculos, "");
            this.btnVehiculos.UseVisualStyleBackColor = false;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.btnOperaciones, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnOperaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOperaciones.FlatAppearance.BorderSize = 0;
            this.btnOperaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperaciones.ForeColor = System.Drawing.Color.White;
            this.btnOperaciones.Image = global::ServiPlusApp.Properties.Resources.sistema_operativo__1_;
            this.btnOperaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperaciones.Location = new System.Drawing.Point(0, 292);
            this.btnOperaciones.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOperaciones.Size = new System.Drawing.Size(270, 45);
            this.btnOperaciones.TabIndex = 7;
            this.btnOperaciones.Tag = "Operaciones";
            this.btnOperaciones.Text = "     Operaciones";
            this.btnOperaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnOperaciones, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnOperaciones, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnOperaciones, "");
            this.btnOperaciones.UseVisualStyleBackColor = false;
            this.btnOperaciones.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // MnOperaciones
            // 
            this.MnOperaciones.Controls.Add(this.btnOpRepuestos);
            this.MnOperaciones.Controls.Add(this.btnOpMantenimientos);
            this.bunifuTransition1.SetDecoration(this.MnOperaciones, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.MnOperaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.MnOperaciones.Location = new System.Drawing.Point(50, 343);
            this.MnOperaciones.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.MnOperaciones.Name = "MnOperaciones";
            this.MnOperaciones.Size = new System.Drawing.Size(220, 90);
            this.MnOperaciones.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.MnOperaciones, "");
            this.bunifuToolTip1.SetToolTipIcon(this.MnOperaciones, null);
            this.bunifuToolTip1.SetToolTipTitle(this.MnOperaciones, "");
            // 
            // btnOpRepuestos
            // 
            this.btnOpRepuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.btnOpRepuestos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnOpRepuestos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpRepuestos.FlatAppearance.BorderSize = 0;
            this.btnOpRepuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpRepuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpRepuestos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpRepuestos.ForeColor = System.Drawing.Color.White;
            this.btnOpRepuestos.Image = global::ServiPlusApp.Properties.Resources.neumatico;
            this.btnOpRepuestos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOpRepuestos.Location = new System.Drawing.Point(0, 45);
            this.btnOpRepuestos.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnOpRepuestos.Name = "btnOpRepuestos";
            this.btnOpRepuestos.Size = new System.Drawing.Size(220, 45);
            this.btnOpRepuestos.TabIndex = 8;
            this.btnOpRepuestos.Tag = "OpRepuestos";
            this.btnOpRepuestos.Text = "          Asignar Repuestos";
            this.bunifuToolTip1.SetToolTip(this.btnOpRepuestos, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnOpRepuestos, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnOpRepuestos, "");
            this.btnOpRepuestos.UseVisualStyleBackColor = false;
            this.btnOpRepuestos.Click += new System.EventHandler(this.btnOpRepuestos_Click);
            // 
            // btnOpMantenimientos
            // 
            this.btnOpMantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.btnOpMantenimientos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnOpMantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpMantenimientos.FlatAppearance.BorderSize = 0;
            this.btnOpMantenimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpMantenimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpMantenimientos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpMantenimientos.ForeColor = System.Drawing.Color.White;
            this.btnOpMantenimientos.Image = global::ServiPlusApp.Properties.Resources.mantenimientoCoche;
            this.btnOpMantenimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpMantenimientos.Location = new System.Drawing.Point(0, 0);
            this.btnOpMantenimientos.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnOpMantenimientos.Name = "btnOpMantenimientos";
            this.btnOpMantenimientos.Size = new System.Drawing.Size(220, 45);
            this.btnOpMantenimientos.TabIndex = 6;
            this.btnOpMantenimientos.Tag = "OpMantenimientos";
            this.btnOpMantenimientos.Text = "    Mantenimientos";
            this.btnOpMantenimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpMantenimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnOpMantenimientos, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnOpMantenimientos, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnOpMantenimientos, "");
            this.btnOpMantenimientos.UseVisualStyleBackColor = false;
            this.btnOpMantenimientos.Click += new System.EventHandler(this.btnOpMantenimientos_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.btnReportes, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = global::ServiPlusApp.Properties.Resources.report;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 439);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(270, 45);
            this.btnReportes.TabIndex = 9;
            this.btnReportes.Tag = "Reportes";
            this.btnReportes.Text = "     Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnReportes, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnReportes, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnReportes, "");
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // MnReportes
            // 
            this.MnReportes.Controls.Add(this.SubMnRecaudaciones);
            this.MnReportes.Controls.Add(this.btnRecaudaciones);
            this.MnReportes.Controls.Add(this.btnReMantenimientos);
            this.bunifuTransition1.SetDecoration(this.MnReportes, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.MnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.MnReportes.Location = new System.Drawing.Point(50, 490);
            this.MnReportes.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.MnReportes.Name = "MnReportes";
            this.MnReportes.Size = new System.Drawing.Size(220, 180);
            this.MnReportes.TabIndex = 10;
            this.bunifuToolTip1.SetToolTip(this.MnReportes, "");
            this.bunifuToolTip1.SetToolTipIcon(this.MnReportes, null);
            this.bunifuToolTip1.SetToolTipTitle(this.MnReportes, "");
            // 
            // btnRecaudaciones
            // 
            this.btnRecaudaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.btnRecaudaciones, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnRecaudaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecaudaciones.FlatAppearance.BorderSize = 0;
            this.btnRecaudaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecaudaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecaudaciones.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecaudaciones.ForeColor = System.Drawing.Color.White;
            this.btnRecaudaciones.Image = global::ServiPlusApp.Properties.Resources.gestion_de_datos;
            this.btnRecaudaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecaudaciones.Location = new System.Drawing.Point(0, 45);
            this.btnRecaudaciones.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnRecaudaciones.Name = "btnRecaudaciones";
            this.btnRecaudaciones.Size = new System.Drawing.Size(220, 45);
            this.btnRecaudaciones.TabIndex = 11;
            this.btnRecaudaciones.Tag = "Recaudaciones";
            this.btnRecaudaciones.Text = "    Recaudaciones";
            this.btnRecaudaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnRecaudaciones, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnRecaudaciones, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnRecaudaciones, "");
            this.btnRecaudaciones.UseVisualStyleBackColor = false;
            this.btnRecaudaciones.Click += new System.EventHandler(this.btnRecaudaciones_Click);
            // 
            // btnReMantenimientos
            // 
            this.btnReMantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.btnReMantenimientos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnReMantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReMantenimientos.FlatAppearance.BorderSize = 0;
            this.btnReMantenimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReMantenimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReMantenimientos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReMantenimientos.ForeColor = System.Drawing.Color.White;
            this.btnReMantenimientos.Image = global::ServiPlusApp.Properties.Resources.servicio_de_administracion;
            this.btnReMantenimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReMantenimientos.Location = new System.Drawing.Point(0, 0);
            this.btnReMantenimientos.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnReMantenimientos.Name = "btnReMantenimientos";
            this.btnReMantenimientos.Size = new System.Drawing.Size(220, 45);
            this.btnReMantenimientos.TabIndex = 10;
            this.btnReMantenimientos.Tag = "ReMantenimientos";
            this.btnReMantenimientos.Text = "    Mantenimientos";
            this.btnReMantenimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReMantenimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnReMantenimientos, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnReMantenimientos, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnReMantenimientos, "");
            this.btnReMantenimientos.UseVisualStyleBackColor = false;
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.btnSeguridad, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeguridad.FlatAppearance.BorderSize = 0;
            this.btnSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.ForeColor = System.Drawing.Color.White;
            this.btnSeguridad.Image = global::ServiPlusApp.Properties.Resources.proteger;
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(0, 676);
            this.btnSeguridad.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSeguridad.Size = new System.Drawing.Size(270, 45);
            this.btnSeguridad.TabIndex = 10;
            this.btnSeguridad.Tag = "Seguridad";
            this.btnSeguridad.Text = "     Seguridad";
            this.btnSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnSeguridad, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnSeguridad, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnSeguridad, "");
            this.btnSeguridad.UseVisualStyleBackColor = false;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // Mnseguridad
            // 
            this.Mnseguridad.Controls.Add(this.btnUsuarios);
            this.bunifuTransition1.SetDecoration(this.Mnseguridad, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Mnseguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.Mnseguridad.Location = new System.Drawing.Point(50, 727);
            this.Mnseguridad.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.Mnseguridad.Name = "Mnseguridad";
            this.Mnseguridad.Size = new System.Drawing.Size(220, 45);
            this.Mnseguridad.TabIndex = 11;
            this.bunifuToolTip1.SetToolTip(this.Mnseguridad, "");
            this.bunifuToolTip1.SetToolTipIcon(this.Mnseguridad, null);
            this.bunifuToolTip1.SetToolTipTitle(this.Mnseguridad, "");
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.btnUsuarios, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::ServiPlusApp.Properties.Resources.usuarios;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(220, 45);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Tag = "Usuarios";
            this.btnUsuarios.Text = "    Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnUsuarios, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnUsuarios, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnUsuarios, "");
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.splitter1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 78);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(270, 2);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.splitter1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.splitter1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.splitter1, "");
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(141)))));
            this.pnlUsuario.Controls.Add(this.lblRol);
            this.pnlUsuario.Controls.Add(this.pbUsuario);
            this.pnlUsuario.Controls.Add(this.lblUsername);
            this.pnlUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.pnlUsuario, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(270, 78);
            this.pnlUsuario.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.pnlUsuario, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pnlUsuario, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pnlUsuario, "");
            this.pnlUsuario.Click += new System.EventHandler(this.pnlUsuario_Click);
            this.pnlUsuario.MouseLeave += new System.EventHandler(this.pnlUsuario_MouseLeave);
            this.pnlUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlUsuario_MouseMove);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.lblRol, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRol.Location = new System.Drawing.Point(72, 38);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(42, 23);
            this.lblRol.TabIndex = 2;
            this.lblRol.Tag = "Rol";
            this.lblRol.Text = "Rol";
            this.bunifuToolTip1.SetToolTip(this.lblRol, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblRol, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblRol, "");
            this.lblRol.Click += new System.EventHandler(this.pnlUsuario_Click);
            this.lblRol.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlUsuario_MouseMove);
            // 
            // pbUsuario
            // 
            this.pbUsuario.AllowFocused = false;
            this.pbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbUsuario.AutoSizeHeight = true;
            this.pbUsuario.BorderRadius = 32;
            this.bunifuTransition1.SetDecoration(this.pbUsuario, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pbUsuario.Image = global::ServiPlusApp.Properties.Resources.hombre_de_traje_y_corbata__1_;
            this.pbUsuario.IsCircle = true;
            this.pbUsuario.Location = new System.Drawing.Point(2, 6);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(64, 64);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 0;
            this.pbUsuario.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pbUsuario, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pbUsuario, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pbUsuario, "");
            this.pbUsuario.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.pbUsuario.Click += new System.EventHandler(this.pnlUsuario_Click);
            this.pbUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlUsuario_MouseMove);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.lblUsername, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsername.Location = new System.Drawing.Point(72, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(169, 23);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Tag = "Username";
            this.lblUsername.Text = "Leonardo Duarte";
            this.bunifuToolTip1.SetToolTip(this.lblUsername, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblUsername, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblUsername, "");
            this.lblUsername.Click += new System.EventHandler(this.pnlUsuario_Click);
            this.lblUsername.MouseLeave += new System.EventHandler(this.pnlUsuario_MouseLeave);
            this.lblUsername.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlUsuario_MouseMove);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.pnlBarraTitulo.Controls.Add(this.btnRestaurar);
            this.pnlBarraTitulo.Controls.Add(this.btnClose);
            this.pnlBarraTitulo.Controls.Add(this.btnMaximizar);
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.btnSlide);
            this.bunifuTransition1.SetDecoration(this.pnlBarraTitulo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(270, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1062, 50);
            this.pnlBarraTitulo.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.pnlBarraTitulo, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pnlBarraTitulo, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pnlBarraTitulo, "");
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            this.pnlBarraTitulo.MouseLeave += new System.EventHandler(this.pnlUsuario_MouseLeave);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnRestaurar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestaurar.IconColor = System.Drawing.Color.White;
            this.btnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRestaurar.IconSize = 25;
            this.btnRestaurar.Location = new System.Drawing.Point(1003, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnRestaurar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnRestaurar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnRestaurar, "");
            this.btnRestaurar.UseGdi = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnClose, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 25;
            this.btnClose.Location = new System.Drawing.Point(1034, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnClose, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnClose, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnClose, "");
            this.btnClose.UseGdi = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMaximizar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.White;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMaximizar.IconSize = 25;
            this.btnMaximizar.Location = new System.Drawing.Point(1003, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnMaximizar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnMaximizar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnMaximizar, "");
            this.btnMaximizar.UseGdi = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMinimizar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimizar.IconSize = 25;
            this.btnMinimizar.Location = new System.Drawing.Point(972, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 35);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnMinimizar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnMinimizar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnMinimizar, "");
            this.btnMinimizar.UseGdi = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.BackColor = System.Drawing.Color.Transparent;
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnSlide, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSlide.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnSlide.IconColor = System.Drawing.Color.White;
            this.btnSlide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSlide.IconSize = 35;
            this.btnSlide.Location = new System.Drawing.Point(6, 3);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSlide.TabIndex = 1;
            this.btnSlide.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnSlide, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnSlide, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnSlide, "");
            this.btnSlide.UseGdi = true;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 30;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.bunifuTransition1.SetDecoration(this.pnlContenedor, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(270, 50);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Padding = new System.Windows.Forms.Padding(2);
            this.pnlContenedor.Size = new System.Drawing.Size(1062, 853);
            this.pnlContenedor.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.pnlContenedor, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pnlContenedor, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pnlContenedor, "");
            this.pnlContenedor.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlContenedor_ControlRemoved);
            this.pnlContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            this.pnlContenedor.MouseLeave += new System.EventHandler(this.pnlUsuario_MouseLeave);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            // 
            // btnCaRepuestos
            // 
            this.btnCaRepuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.btnCaRepuestos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnCaRepuestos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaRepuestos.FlatAppearance.BorderSize = 0;
            this.btnCaRepuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCaRepuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaRepuestos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaRepuestos.ForeColor = System.Drawing.Color.White;
            this.btnCaRepuestos.Image = global::ServiPlusApp.Properties.Resources.neumatico;
            this.btnCaRepuestos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaRepuestos.Location = new System.Drawing.Point(0, 180);
            this.btnCaRepuestos.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCaRepuestos.Name = "btnCaRepuestos";
            this.btnCaRepuestos.Size = new System.Drawing.Size(220, 45);
            this.btnCaRepuestos.TabIndex = 9;
            this.btnCaRepuestos.Tag = "Repuestos";
            this.btnCaRepuestos.Text = "    Repuestos";
            this.btnCaRepuestos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaRepuestos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.btnCaRepuestos, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnCaRepuestos, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnCaRepuestos, "");
            this.btnCaRepuestos.UseVisualStyleBackColor = false;
            this.btnCaRepuestos.Click += new System.EventHandler(this.btnCaRepuestos_Click);
            // 
            // SubMnRecaudaciones
            // 
            this.SubMnRecaudaciones.Controls.Add(this.button3);
            this.SubMnRecaudaciones.Controls.Add(this.button4);
            this.bunifuTransition1.SetDecoration(this.SubMnRecaudaciones, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SubMnRecaudaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMnRecaudaciones.Location = new System.Drawing.Point(0, 90);
            this.SubMnRecaudaciones.Name = "SubMnRecaudaciones";
            this.SubMnRecaudaciones.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.SubMnRecaudaciones.Size = new System.Drawing.Size(220, 90);
            this.SubMnRecaudaciones.TabIndex = 14;
            this.bunifuToolTip1.SetToolTip(this.SubMnRecaudaciones, "");
            this.bunifuToolTip1.SetToolTipIcon(this.SubMnRecaudaciones, null);
            this.bunifuToolTip1.SetToolTipTitle(this.SubMnRecaudaciones, "");
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.button3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::ServiPlusApp.Properties.Resources.gestion_de_datos;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(35, 45);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 45);
            this.button3.TabIndex = 13;
            this.button3.Tag = "ReRepuestos";
            this.button3.Text = "    Repuestos";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.button3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.button3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.button3, "");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuTransition1.SetDecoration(this.button4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::ServiPlusApp.Properties.Resources.servicio_de_administracion;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(35, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 45);
            this.button4.TabIndex = 12;
            this.button4.Tag = "ReMantenimientos";
            this.button4.Text = "    Servicios";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bunifuToolTip1.SetToolTip(this.button4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.button4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.button4, "");
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Operaciones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1332, 903);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.pnlMenuVertical);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 480);
            this.Name = "Operaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones";
            this.Load += new System.EventHandler(this.Operaciones_Load);
            this.Resize += new System.EventHandler(this.Operaciones_Resize);
            this.pnlMenuVertical.ResumeLayout(false);
            this.pnlMenuContenedor.ResumeLayout(false);
            this.MnCatalogos.ResumeLayout(false);
            this.MnOperaciones.ResumeLayout(false);
            this.MnReportes.ResumeLayout(false);
            this.Mnseguridad.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.SubMnRecaudaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private FontAwesome.Sharp.IconPictureBox btnSlide;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconPictureBox btnMaximizar;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconPictureBox btnRestaurar;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.FlowLayoutPanel pnlMenuContenedor;
        private System.Windows.Forms.Button btnCatalogos;
        private System.Windows.Forms.Panel MnCatalogos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnMecanicos;
        private System.Windows.Forms.Button btnOperaciones;
        private System.Windows.Forms.Panel MnOperaciones;
        private System.Windows.Forms.Button btnOpRepuestos;
        private System.Windows.Forms.Button btnOpMantenimientos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel MnReportes;
        private System.Windows.Forms.Button btnRecaudaciones;
        private System.Windows.Forms.Button btnReMantenimientos;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Panel Mnseguridad;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Timer timer4;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.UI.WinForms.BunifuPictureBox pbUsuario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Panel pnlContenedor;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Button btnCaRepuestos;
        private System.Windows.Forms.Panel SubMnRecaudaciones;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}