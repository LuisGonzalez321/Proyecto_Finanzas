﻿namespace Finanzas.Vista
{
    partial class AgregarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btn_salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_agregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.btn_actualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabla_usuario = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btn_cancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.combox_rol = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_contraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 58);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(708, 19);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageActive = null;
            this.btn_salir.Location = new System.Drawing.Point(683, 3);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(37, 37);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 11;
            this.btn_salir.TabStop = false;
            this.btn_salir.Zoom = 10;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.ImageActive = null;
            this.btn_minimizar.Location = new System.Drawing.Point(639, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(38, 37);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimizar.TabIndex = 12;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Zoom = 10;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Active = false;
            this.btn_agregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_agregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.BorderRadius = 7;
            this.btn_agregar.ButtonText = "Guardar";
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_agregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_agregar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Iconimage")));
            this.btn_agregar.Iconimage_right = null;
            this.btn_agregar.Iconimage_right_Selected = null;
            this.btn_agregar.Iconimage_Selected = null;
            this.btn_agregar.IconMarginLeft = 0;
            this.btn_agregar.IconMarginRight = 0;
            this.btn_agregar.IconRightVisible = true;
            this.btn_agregar.IconRightZoom = 0D;
            this.btn_agregar.IconVisible = true;
            this.btn_agregar.IconZoom = 50D;
            this.btn_agregar.IsTab = false;
            this.btn_agregar.Location = new System.Drawing.Point(391, 207);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_agregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_agregar.selected = false;
            this.btn_agregar.Size = new System.Drawing.Size(101, 45);
            this.btn_agregar.TabIndex = 19;
            this.btn_agregar.Text = "Guardar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Textcolor = System.Drawing.Color.White;
            this.btn_agregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_actualizar);
            this.panel1.Controls.Add(this.tabla_usuario);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.bunifuLabel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.combox_rol);
            this.panel1.Controls.Add(this.txt_contraseña);
            this.panel1.Controls.Add(this.txt_usuario);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.bunifuLabel4);
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.PanelColor = System.Drawing.Color.Empty;
            this.panel1.ShadowDept = 2;
            this.panel1.ShadowTopLeftVisible = false;
            this.panel1.Size = new System.Drawing.Size(732, 529);
            this.panel1.TabIndex = 0;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Active = false;
            this.btn_actualizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_actualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.BorderRadius = 7;
            this.btn_actualizar.ButtonText = "Actualizar";
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_actualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_actualizar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Iconimage")));
            this.btn_actualizar.Iconimage_right = null;
            this.btn_actualizar.Iconimage_right_Selected = null;
            this.btn_actualizar.Iconimage_Selected = null;
            this.btn_actualizar.IconMarginLeft = 0;
            this.btn_actualizar.IconMarginRight = 0;
            this.btn_actualizar.IconRightVisible = true;
            this.btn_actualizar.IconRightZoom = 0D;
            this.btn_actualizar.IconVisible = true;
            this.btn_actualizar.IconZoom = 50D;
            this.btn_actualizar.IsTab = false;
            this.btn_actualizar.Location = new System.Drawing.Point(498, 207);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btn_actualizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_actualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_actualizar.selected = false;
            this.btn_actualizar.Size = new System.Drawing.Size(100, 45);
            this.btn_actualizar.TabIndex = 28;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizar.Textcolor = System.Drawing.Color.White;
            this.btn_actualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // tabla_usuario
            // 
            this.tabla_usuario.AllowCustomTheming = false;
            this.tabla_usuario.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tabla_usuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_usuario.BackgroundColor = System.Drawing.Color.White;
            this.tabla_usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabla_usuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla_usuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_usuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_usuario.ColumnHeadersHeight = 40;
            this.tabla_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_eliminar});
            this.tabla_usuario.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tabla_usuario.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabla_usuario.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla_usuario.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tabla_usuario.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tabla_usuario.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tabla_usuario.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tabla_usuario.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabla_usuario.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tabla_usuario.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabla_usuario.CurrentTheme.Name = null;
            this.tabla_usuario.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tabla_usuario.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabla_usuario.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla_usuario.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tabla_usuario.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_usuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla_usuario.EnableHeadersVisualStyles = false;
            this.tabla_usuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tabla_usuario.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tabla_usuario.HeaderBgColor = System.Drawing.Color.Empty;
            this.tabla_usuario.HeaderForeColor = System.Drawing.Color.White;
            this.tabla_usuario.Location = new System.Drawing.Point(30, 347);
            this.tabla_usuario.Name = "tabla_usuario";
            this.tabla_usuario.ReadOnly = true;
            this.tabla_usuario.RowHeadersVisible = false;
            this.tabla_usuario.RowTemplate.Height = 40;
            this.tabla_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_usuario.Size = new System.Drawing.Size(673, 161);
            this.tabla_usuario.TabIndex = 27;
            this.tabla_usuario.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tabla_usuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_usuario_CellClick);
            this.tabla_usuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_usuario_CellDoubleClick);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.HeaderText = "Eliminar";
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.ReadOnly = true;
            this.btn_eliminar.UseColumnTextForButtonValue = true;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(12, 258);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(708, 19);
            this.bunifuSeparator2.TabIndex = 26;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Active = false;
            this.btn_cancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_cancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.BorderRadius = 7;
            this.btn_cancelar.ButtonText = "Cancelar";
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Iconimage")));
            this.btn_cancelar.Iconimage_right = null;
            this.btn_cancelar.Iconimage_right_Selected = null;
            this.btn_cancelar.Iconimage_Selected = null;
            this.btn_cancelar.IconMarginLeft = 0;
            this.btn_cancelar.IconMarginRight = 0;
            this.btn_cancelar.IconRightVisible = true;
            this.btn_cancelar.IconRightZoom = 0D;
            this.btn_cancelar.IconVisible = true;
            this.btn_cancelar.IconZoom = 50D;
            this.btn_cancelar.IsTab = false;
            this.btn_cancelar.Location = new System.Drawing.Point(604, 207);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btn_cancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_cancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancelar.selected = false;
            this.btn_cancelar.Size = new System.Drawing.Size(101, 45);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Textcolor = System.Drawing.Color.White;
            this.btn_cancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(30, 292);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(250, 40);
            this.bunifuLabel2.TabIndex = 24;
            this.bunifuLabel2.Text = "Lista de usuarios";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // combox_rol
            // 
            this.combox_rol.BackColor = System.Drawing.Color.Teal;
            this.combox_rol.BorderRadius = 7;
            this.combox_rol.DisabledColor = System.Drawing.Color.Gray;
            this.combox_rol.ForeColor = System.Drawing.Color.White;
            this.combox_rol.items = new string[] {
        "-Seleccionar",
        "Usuario",
        "Administrador",
        "Jefe"};
            this.combox_rol.Location = new System.Drawing.Point(86, 216);
            this.combox_rol.Name = "combox_rol";
            this.combox_rol.NomalColor = System.Drawing.Color.DodgerBlue;
            this.combox_rol.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.combox_rol.selectedIndex = 0;
            this.combox_rol.Size = new System.Drawing.Size(299, 35);
            this.combox_rol.TabIndex = 22;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_contraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_contraseña.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_contraseña.HintForeColor = System.Drawing.Color.Empty;
            this.txt_contraseña.HintText = "Contraseña";
            this.txt_contraseña.isPassword = false;
            this.txt_contraseña.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_contraseña.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_contraseña.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_contraseña.LineThickness = 3;
            this.txt_contraseña.Location = new System.Drawing.Point(64, 160);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contraseña.MaxLength = 32767;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(320, 33);
            this.txt_contraseña.TabIndex = 21;
            this.txt_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_usuario.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_usuario.HintForeColor = System.Drawing.Color.Empty;
            this.txt_usuario.HintText = "Usuario";
            this.txt_usuario.isPassword = false;
            this.txt_usuario.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_usuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_usuario.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_usuario.LineThickness = 3;
            this.txt_usuario.Location = new System.Drawing.Point(64, 84);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.MaxLength = 32767;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(320, 33);
            this.txt_usuario.TabIndex = 20;
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel4.Location = new System.Drawing.Point(30, 217);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(49, 34);
            this.bunifuLabel4.TabIndex = 18;
            this.bunifuLabel4.Text = "Rol :";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuLabel1.Location = new System.Drawing.Point(30, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(219, 40);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Añadir Usuario";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 529);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_agregar;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimizar;
        private Bunifu.Framework.UI.BunifuImageButton btn_salir;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_usuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_contraseña;
        private Bunifu.Framework.UI.BunifuDropdown combox_rol;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cancelar;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuDataGridView tabla_usuario;
        private System.Windows.Forms.DataGridViewButtonColumn btn_eliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_actualizar;
    }
}