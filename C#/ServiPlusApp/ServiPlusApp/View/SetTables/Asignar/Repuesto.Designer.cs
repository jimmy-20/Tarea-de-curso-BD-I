
namespace ServiPlusApp.View.SetTables.Asignar
{
    partial class Repuesto
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
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repuesto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnBuscarRepuesto = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.dgvRepuestos = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.IdRepuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuTextBox14 = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarRepuesto
            // 
            this.btnBuscarRepuesto.AllowAnimations = true;
            this.btnBuscarRepuesto.AllowBorderColorChanges = true;
            this.btnBuscarRepuesto.AllowMouseEffects = true;
            this.btnBuscarRepuesto.AnimationSpeed = 200;
            this.btnBuscarRepuesto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarRepuesto.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.btnBuscarRepuesto.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarRepuesto.BorderRadius = 1;
            this.btnBuscarRepuesto.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnBuscarRepuesto.BorderThickness = 3;
            this.btnBuscarRepuesto.ColorContrastOnClick = 30;
            this.btnBuscarRepuesto.ColorContrastOnHover = 30;
            this.btnBuscarRepuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnBuscarRepuesto.CustomizableEdges = borderEdges1;
            this.btnBuscarRepuesto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarRepuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarRepuesto.Image")));
            this.btnBuscarRepuesto.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnBuscarRepuesto.Location = new System.Drawing.Point(659, 138);
            this.btnBuscarRepuesto.Name = "btnBuscarRepuesto";
            this.btnBuscarRepuesto.RoundBorders = false;
            this.btnBuscarRepuesto.ShowBorders = true;
            this.btnBuscarRepuesto.Size = new System.Drawing.Size(40, 35);
            this.btnBuscarRepuesto.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Flat;
            this.btnBuscarRepuesto.TabIndex = 107;
            this.btnBuscarRepuesto.Tag = "Repuestos";
            // 
            // dgvRepuestos
            // 
            this.dgvRepuestos.AllowCustomTheming = false;
            this.dgvRepuestos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvRepuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRepuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRepuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRepuestos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRepuestos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRepuestos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRepuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRepuestos.ColumnHeadersHeight = 40;
            this.dgvRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRepuesto,
            this.ReDescripcion,
            this.Marca,
            this.Modelo,
            this.Precio,
            this.ReDescuento,
            this.ReCantidad,
            this.ReEstado});
            this.dgvRepuestos.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dgvRepuestos.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvRepuestos.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRepuestos.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvRepuestos.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRepuestos.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.dgvRepuestos.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvRepuestos.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.dgvRepuestos.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvRepuestos.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRepuestos.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvRepuestos.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRepuestos.CurrentTheme.Name = null;
            this.dgvRepuestos.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvRepuestos.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvRepuestos.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRepuestos.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvRepuestos.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRepuestos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRepuestos.EnableHeadersVisualStyles = false;
            this.dgvRepuestos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvRepuestos.HeaderBackColor = System.Drawing.Color.Teal;
            this.dgvRepuestos.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvRepuestos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvRepuestos.Location = new System.Drawing.Point(110, 138);
            this.dgvRepuestos.Name = "dgvRepuestos";
            this.dgvRepuestos.RowHeadersVisible = false;
            this.dgvRepuestos.RowHeadersWidth = 51;
            this.dgvRepuestos.RowTemplate.Height = 40;
            this.dgvRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepuestos.Size = new System.Drawing.Size(543, 220);
            this.dgvRepuestos.TabIndex = 106;
            this.dgvRepuestos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            // 
            // IdRepuesto
            // 
            this.IdRepuesto.HeaderText = "IdRepuesto";
            this.IdRepuesto.MinimumWidth = 6;
            this.IdRepuesto.Name = "IdRepuesto";
            this.IdRepuesto.ReadOnly = true;
            this.IdRepuesto.Visible = false;
            this.IdRepuesto.Width = 142;
            // 
            // ReDescripcion
            // 
            this.ReDescripcion.HeaderText = "Descripción";
            this.ReDescripcion.MinimumWidth = 6;
            this.ReDescripcion.Name = "ReDescripcion";
            this.ReDescripcion.ReadOnly = true;
            this.ReDescripcion.Width = 144;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 93;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 109;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 95;
            // 
            // ReDescuento
            // 
            this.ReDescuento.HeaderText = "Descuento";
            this.ReDescuento.MinimumWidth = 6;
            this.ReDescuento.Name = "ReDescuento";
            this.ReDescuento.ReadOnly = true;
            this.ReDescuento.Width = 136;
            // 
            // ReCantidad
            // 
            this.ReCantidad.HeaderText = "Cantidad";
            this.ReCantidad.MinimumWidth = 6;
            this.ReCantidad.Name = "ReCantidad";
            this.ReCantidad.Width = 119;
            // 
            // ReEstado
            // 
            this.ReEstado.HeaderText = "Estado";
            this.ReEstado.MinimumWidth = 6;
            this.ReEstado.Name = "ReEstado";
            this.ReEstado.ReadOnly = true;
            this.ReEstado.Visible = false;
            this.ReEstado.Width = 99;
            // 
            // bunifuTextBox14
            // 
            this.bunifuTextBox14.AcceptsReturn = false;
            this.bunifuTextBox14.AcceptsTab = false;
            this.bunifuTextBox14.AnimationSpeed = 200;
            this.bunifuTextBox14.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox14.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox14.AutoSizeHeight = true;
            this.bunifuTextBox14.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuTextBox14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox14.BackgroundImage")));
            this.bunifuTextBox14.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox14.BorderColorDisabled = System.Drawing.Color.MediumSlateBlue;
            this.bunifuTextBox14.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox14.BorderColorIdle = System.Drawing.Color.MediumSlateBlue;
            this.bunifuTextBox14.BorderRadius = 1;
            this.bunifuTextBox14.BorderThickness = 2;
            this.bunifuTextBox14.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox14.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox14.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuTextBox14.DefaultText = "";
            this.bunifuTextBox14.Enabled = false;
            this.bunifuTextBox14.FillColor = System.Drawing.SystemColors.Control;
            this.bunifuTextBox14.HideSelection = true;
            this.bunifuTextBox14.IconLeft = null;
            this.bunifuTextBox14.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox14.IconPadding = 10;
            this.bunifuTextBox14.IconRight = null;
            this.bunifuTextBox14.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox14.Lines = new string[0];
            this.bunifuTextBox14.Location = new System.Drawing.Point(97, 92);
            this.bunifuTextBox14.MaxLength = 32767;
            this.bunifuTextBox14.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox14.Modified = false;
            this.bunifuTextBox14.Multiline = false;
            this.bunifuTextBox14.Name = "bunifuTextBox14";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox14.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            stateProperties2.FillColor = System.Drawing.SystemColors.Control;
            stateProperties2.ForeColor = System.Drawing.Color.Black;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Black;
            this.bunifuTextBox14.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox14.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            stateProperties4.FillColor = System.Drawing.SystemColors.Control;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox14.OnIdleState = stateProperties4;
            this.bunifuTextBox14.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBox14.PasswordChar = '\0';
            this.bunifuTextBox14.PlaceholderForeColor = System.Drawing.Color.Black;
            this.bunifuTextBox14.PlaceholderText = "Asginar Repuestos";
            this.bunifuTextBox14.ReadOnly = true;
            this.bunifuTextBox14.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox14.SelectedText = "";
            this.bunifuTextBox14.SelectionLength = 0;
            this.bunifuTextBox14.SelectionStart = 0;
            this.bunifuTextBox14.ShortcutsEnabled = true;
            this.bunifuTextBox14.Size = new System.Drawing.Size(606, 40);
            this.bunifuTextBox14.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.bunifuTextBox14.TabIndex = 105;
            this.bunifuTextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox14.TextMarginBottom = 0;
            this.bunifuTextBox14.TextMarginLeft = 3;
            this.bunifuTextBox14.TextMarginTop = 1;
            this.bunifuTextBox14.TextPlaceholder = "Asginar Repuestos";
            this.bunifuTextBox14.UseSystemPasswordChar = false;
            this.bunifuTextBox14.WordWrap = true;
            // 
            // Repuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarRepuesto);
            this.Controls.Add(this.dgvRepuestos);
            this.Controls.Add(this.bunifuTextBox14);
            this.Name = "Repuesto";
            this.Text = "Repuesto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnBuscarRepuesto;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvRepuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRepuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReEstado;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox14;
    }
}