namespace Finanzas.Vista
{
    partial class EstadosFinancieros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadosFinancieros));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.btn_salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_buscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.datepicker_BG = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pages_EF = new Bunifu.UI.WinForms.BunifuPages();
            this.page_BG = new System.Windows.Forms.TabPage();
            this.tabla_capital = new System.Windows.Forms.DataGridView();
            this.tabla_pasivo = new System.Windows.Forms.DataGridView();
            this.tabla_activo = new System.Windows.Forms.DataGridView();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label_pc = new Bunifu.UI.WinForms.BunifuLabel();
            this.label_activo = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_nuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_er = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.page_ER = new System.Windows.Forms.TabPage();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.tabla_er = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_UO = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_UDI = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_UB = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_UN = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_bg = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            this.pages_EF.SuspendLayout();
            this.page_BG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_capital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_pasivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_activo)).BeginInit();
            this.page_ER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_er)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageActive = null;
            this.btn_salir.Location = new System.Drawing.Point(944, 0);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(36, 35);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 8;
            this.btn_salir.TabStop = false;
            this.btn_salir.Zoom = 10;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btn_minimizar);
            this.bunifuGradientPanel1.Controls.Add(this.btn_buscar);
            this.bunifuGradientPanel1.Controls.Add(this.datepicker_BG);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.btn_salir);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(980, 50);
            this.bunifuGradientPanel1.TabIndex = 13;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.ImageActive = null;
            this.btn_minimizar.Location = new System.Drawing.Point(902, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(36, 35);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimizar.TabIndex = 54;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Zoom = 10;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageActive = null;
            this.btn_buscar.Location = new System.Drawing.Point(276, 8);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(30, 32);
            this.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_buscar.TabIndex = 59;
            this.btn_buscar.TabStop = false;
            this.btn_buscar.Zoom = 10;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // datepicker_BG
            // 
            this.datepicker_BG.BackColor = System.Drawing.Color.DodgerBlue;
            this.datepicker_BG.BorderRadius = 1;
            this.datepicker_BG.Color = System.Drawing.Color.White;
            this.datepicker_BG.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.datepicker_BG.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.datepicker_BG.DisabledColor = System.Drawing.Color.Gray;
            this.datepicker_BG.DisplayWeekNumbers = false;
            this.datepicker_BG.DPHeight = 0;
            this.datepicker_BG.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datepicker_BG.FillDatePicker = false;
            this.datepicker_BG.ForeColor = System.Drawing.Color.White;
            this.datepicker_BG.Icon = ((System.Drawing.Image)(resources.GetObject("datepicker_BG.Icon")));
            this.datepicker_BG.IconColor = System.Drawing.Color.White;
            this.datepicker_BG.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.datepicker_BG.Location = new System.Drawing.Point(53, 8);
            this.datepicker_BG.MinimumSize = new System.Drawing.Size(217, 32);
            this.datepicker_BG.Name = "datepicker_BG";
            this.datepicker_BG.Size = new System.Drawing.Size(217, 32);
            this.datepicker_BG.TabIndex = 58;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(240)))));
            this.bunifuLabel4.Location = new System.Drawing.Point(331, 3);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(174, 34);
            this.bunifuLabel4.TabIndex = 14;
            this.bunifuLabel4.Text = "Balance General";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pages_EF
            // 
            this.pages_EF.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pages_EF.AllowTransitions = true;
            this.pages_EF.Controls.Add(this.page_BG);
            this.pages_EF.Controls.Add(this.page_ER);
            this.pages_EF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pages_EF.Location = new System.Drawing.Point(0, 50);
            this.pages_EF.Multiline = true;
            this.pages_EF.Name = "pages_EF";
            this.pages_EF.Page = this.page_BG;
            this.pages_EF.PageIndex = 0;
            this.pages_EF.PageName = "page_BG";
            this.pages_EF.PageTitle = "BalanceGeneral";
            this.pages_EF.SelectedIndex = 0;
            this.pages_EF.Size = new System.Drawing.Size(980, 560);
            this.pages_EF.TabIndex = 53;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.pages_EF.Transition = animation1;
            this.pages_EF.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // page_BG
            // 
            this.page_BG.Controls.Add(this.bunifuLabel7);
            this.page_BG.Controls.Add(this.tabla_capital);
            this.page_BG.Controls.Add(this.tabla_pasivo);
            this.page_BG.Controls.Add(this.tabla_activo);
            this.page_BG.Controls.Add(this.bunifuSeparator5);
            this.page_BG.Controls.Add(this.bunifuSeparator6);
            this.page_BG.Controls.Add(this.bunifuSeparator7);
            this.page_BG.Controls.Add(this.bunifuSeparator8);
            this.page_BG.Controls.Add(this.label_pc);
            this.page_BG.Controls.Add(this.label_activo);
            this.page_BG.Controls.Add(this.btn_nuevo);
            this.page_BG.Controls.Add(this.btn_er);
            this.page_BG.Controls.Add(this.bunifuLabel3);
            this.page_BG.Controls.Add(this.bunifuLabel2);
            this.page_BG.Controls.Add(this.bunifuLabel1);
            this.page_BG.Location = new System.Drawing.Point(4, 4);
            this.page_BG.Name = "page_BG";
            this.page_BG.Padding = new System.Windows.Forms.Padding(3);
            this.page_BG.Size = new System.Drawing.Size(972, 534);
            this.page_BG.TabIndex = 0;
            this.page_BG.Text = "BalanceGeneral";
            this.page_BG.UseVisualStyleBackColor = true;
            // 
            // tabla_capital
            // 
            this.tabla_capital.AllowUserToAddRows = false;
            this.tabla_capital.BackgroundColor = System.Drawing.Color.White;
            this.tabla_capital.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabla_capital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_capital.Location = new System.Drawing.Point(523, 297);
            this.tabla_capital.Name = "tabla_capital";
            this.tabla_capital.Size = new System.Drawing.Size(382, 146);
            this.tabla_capital.TabIndex = 79;
            // 
            // tabla_pasivo
            // 
            this.tabla_pasivo.AllowUserToAddRows = false;
            this.tabla_pasivo.BackgroundColor = System.Drawing.Color.White;
            this.tabla_pasivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabla_pasivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_pasivo.Location = new System.Drawing.Point(523, 62);
            this.tabla_pasivo.Name = "tabla_pasivo";
            this.tabla_pasivo.Size = new System.Drawing.Size(382, 189);
            this.tabla_pasivo.TabIndex = 78;
            // 
            // tabla_activo
            // 
            this.tabla_activo.AllowUserToAddRows = false;
            this.tabla_activo.BackgroundColor = System.Drawing.Color.White;
            this.tabla_activo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabla_activo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_activo.Location = new System.Drawing.Point(49, 62);
            this.tabla_activo.Name = "tabla_activo";
            this.tabla_activo.Size = new System.Drawing.Size(402, 440);
            this.tabla_activo.TabIndex = 77;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(13, 3);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(946, 10);
            this.bunifuSeparator5.TabIndex = 76;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator6.LineThickness = 1;
            this.bunifuSeparator6.Location = new System.Drawing.Point(13, 521);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(946, 10);
            this.bunifuSeparator6.TabIndex = 75;
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = false;
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator7.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator7.LineThickness = 1;
            this.bunifuSeparator7.Location = new System.Drawing.Point(959, 3);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Size = new System.Drawing.Size(10, 528);
            this.bunifuSeparator7.TabIndex = 74;
            this.bunifuSeparator7.Transparency = 255;
            this.bunifuSeparator7.Vertical = true;
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator8.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator8.LineThickness = 1;
            this.bunifuSeparator8.Location = new System.Drawing.Point(3, 3);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Size = new System.Drawing.Size(10, 528);
            this.bunifuSeparator8.TabIndex = 73;
            this.bunifuSeparator8.Transparency = 255;
            this.bunifuSeparator8.Vertical = true;
            // 
            // label_pc
            // 
            this.label_pc.AutoEllipsis = false;
            this.label_pc.CursorType = null;
            this.label_pc.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label_pc.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_pc.Location = new System.Drawing.Point(523, 508);
            this.label_pc.Name = "label_pc";
            this.label_pc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_pc.Size = new System.Drawing.Size(280, 35);
            this.label_pc.TabIndex = 61;
            this.label_pc.Text = "TOTAL PASIVO Y CAPITAL:";
            this.label_pc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pc.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label_activo
            // 
            this.label_activo.AutoEllipsis = false;
            this.label_activo.CursorType = null;
            this.label_activo.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label_activo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_activo.Location = new System.Drawing.Point(49, 508);
            this.label_activo.Name = "label_activo";
            this.label_activo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_activo.Size = new System.Drawing.Size(174, 35);
            this.label_activo.TabIndex = 60;
            this.label_activo.Text = "TOTAL ACTIVO :";
            this.label_activo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_activo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Active = false;
            this.btn_nuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_nuevo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.BorderRadius = 7;
            this.btn_nuevo.ButtonText = "Nuevo";
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_nuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_nuevo.Iconimage = null;
            this.btn_nuevo.Iconimage_right = null;
            this.btn_nuevo.Iconimage_right_Selected = null;
            this.btn_nuevo.Iconimage_Selected = null;
            this.btn_nuevo.IconMarginLeft = 0;
            this.btn_nuevo.IconMarginRight = 0;
            this.btn_nuevo.IconRightVisible = false;
            this.btn_nuevo.IconRightZoom = 0D;
            this.btn_nuevo.IconVisible = false;
            this.btn_nuevo.IconZoom = 90D;
            this.btn_nuevo.IsTab = false;
            this.btn_nuevo.Location = new System.Drawing.Point(523, 454);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btn_nuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_nuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_nuevo.selected = false;
            this.btn_nuevo.Size = new System.Drawing.Size(166, 48);
            this.btn_nuevo.TabIndex = 59;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_nuevo.Textcolor = System.Drawing.Color.White;
            this.btn_nuevo.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_er
            // 
            this.btn_er.Active = false;
            this.btn_er.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_er.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_er.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_er.BorderRadius = 7;
            this.btn_er.ButtonText = "Estado de Resultado";
            this.btn_er.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_er.DisabledColor = System.Drawing.Color.Gray;
            this.btn_er.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_er.Iconimage = null;
            this.btn_er.Iconimage_right = null;
            this.btn_er.Iconimage_right_Selected = null;
            this.btn_er.Iconimage_Selected = null;
            this.btn_er.IconMarginLeft = 0;
            this.btn_er.IconMarginRight = 0;
            this.btn_er.IconRightVisible = false;
            this.btn_er.IconRightZoom = 0D;
            this.btn_er.IconVisible = false;
            this.btn_er.IconZoom = 90D;
            this.btn_er.IsTab = false;
            this.btn_er.Location = new System.Drawing.Point(713, 454);
            this.btn_er.Name = "btn_er";
            this.btn_er.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btn_er.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_er.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_er.selected = false;
            this.btn_er.Size = new System.Drawing.Size(192, 48);
            this.btn_er.TabIndex = 58;
            this.btn_er.Text = "Estado de Resultado";
            this.btn_er.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_er.Textcolor = System.Drawing.Color.White;
            this.btn_er.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_er.Click += new System.EventHandler(this.btn_er_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuLabel3.Location = new System.Drawing.Point(523, 16);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(80, 35);
            this.bunifuLabel3.TabIndex = 55;
            this.bunifuLabel3.Text = "Pasivos";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuLabel2.Location = new System.Drawing.Point(523, 257);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(76, 34);
            this.bunifuLabel2.TabIndex = 54;
            this.bunifuLabel2.Text = "Capital";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuLabel1.Location = new System.Drawing.Point(49, 17);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(79, 34);
            this.bunifuLabel1.TabIndex = 53;
            this.bunifuLabel1.Text = "Activos";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // page_ER
            // 
            this.page_ER.Controls.Add(this.bunifuLabel5);
            this.page_ER.Controls.Add(this.bunifuLabel6);
            this.page_ER.Controls.Add(this.tabla_er);
            this.page_ER.Controls.Add(this.groupBox1);
            this.page_ER.Controls.Add(this.btn_bg);
            this.page_ER.Controls.Add(this.bunifuSeparator1);
            this.page_ER.Controls.Add(this.bunifuSeparator2);
            this.page_ER.Controls.Add(this.bunifuSeparator3);
            this.page_ER.Controls.Add(this.bunifuSeparator4);
            this.page_ER.Location = new System.Drawing.Point(4, 4);
            this.page_ER.Name = "page_ER";
            this.page_ER.Padding = new System.Windows.Forms.Padding(3);
            this.page_ER.Size = new System.Drawing.Size(972, 534);
            this.page_ER.TabIndex = 1;
            this.page_ER.Text = "EstadoResultado";
            this.page_ER.UseVisualStyleBackColor = true;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuLabel6.Location = new System.Drawing.Point(49, 23);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(209, 33);
            this.bunifuLabel6.TabIndex = 56;
            this.bunifuLabel6.Text = "Ingresos - Egresos";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tabla_er
            // 
            this.tabla_er.AllowUserToAddRows = false;
            this.tabla_er.BackgroundColor = System.Drawing.Color.White;
            this.tabla_er.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabla_er.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_er.Location = new System.Drawing.Point(49, 62);
            this.tabla_er.Name = "tabla_er";
            this.tabla_er.Size = new System.Drawing.Size(524, 400);
            this.tabla_er.TabIndex = 85;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_UO);
            this.groupBox1.Controls.Add(this.lbl_UDI);
            this.groupBox1.Controls.Add(this.lbl_UB);
            this.groupBox1.Controls.Add(this.lbl_UN);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(616, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 439);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utilidades";
            // 
            // lbl_UO
            // 
            this.lbl_UO.AutoEllipsis = false;
            this.lbl_UO.CursorType = null;
            this.lbl_UO.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_UO.Location = new System.Drawing.Point(18, 144);
            this.lbl_UO.Name = "lbl_UO";
            this.lbl_UO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_UO.Size = new System.Drawing.Size(196, 35);
            this.lbl_UO.TabIndex = 55;
            this.lbl_UO.Text = "Utilidad Operativa :";
            this.lbl_UO.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_UO.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_UDI
            // 
            this.lbl_UDI.AutoEllipsis = false;
            this.lbl_UDI.CursorType = null;
            this.lbl_UDI.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UDI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_UDI.Location = new System.Drawing.Point(18, 231);
            this.lbl_UDI.Name = "lbl_UDI";
            this.lbl_UDI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_UDI.Size = new System.Drawing.Size(236, 35);
            this.lbl_UDI.TabIndex = 54;
            this.lbl_UDI.Text = "Utilidad despues de IR :";
            this.lbl_UDI.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_UDI.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_UB
            // 
            this.lbl_UB.AutoEllipsis = false;
            this.lbl_UB.CursorType = null;
            this.lbl_UB.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_UB.Location = new System.Drawing.Point(18, 57);
            this.lbl_UB.Name = "lbl_UB";
            this.lbl_UB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_UB.Size = new System.Drawing.Size(144, 35);
            this.lbl_UB.TabIndex = 53;
            this.lbl_UB.Text = "Utilidad Bruta:";
            this.lbl_UB.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_UB.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_UN
            // 
            this.lbl_UN.AutoEllipsis = false;
            this.lbl_UN.CursorType = null;
            this.lbl_UN.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_UN.Location = new System.Drawing.Point(18, 318);
            this.lbl_UN.Name = "lbl_UN";
            this.lbl_UN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_UN.Size = new System.Drawing.Size(146, 35);
            this.lbl_UN.TabIndex = 44;
            this.lbl_UN.Text = "Utilidad Neta :";
            this.lbl_UN.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_UN.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_bg
            // 
            this.btn_bg.Active = false;
            this.btn_bg.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_bg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bg.BorderRadius = 7;
            this.btn_bg.ButtonText = "Balance General";
            this.btn_bg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bg.DisabledColor = System.Drawing.Color.Gray;
            this.btn_bg.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_bg.Iconimage = null;
            this.btn_bg.Iconimage_right = null;
            this.btn_bg.Iconimage_right_Selected = null;
            this.btn_bg.Iconimage_Selected = null;
            this.btn_bg.IconMarginLeft = 0;
            this.btn_bg.IconMarginRight = 0;
            this.btn_bg.IconRightVisible = false;
            this.btn_bg.IconRightZoom = 0D;
            this.btn_bg.IconVisible = false;
            this.btn_bg.IconZoom = 90D;
            this.btn_bg.IsTab = false;
            this.btn_bg.Location = new System.Drawing.Point(616, 468);
            this.btn_bg.Name = "btn_bg";
            this.btn_bg.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btn_bg.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_bg.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_bg.selected = false;
            this.btn_bg.Size = new System.Drawing.Size(131, 48);
            this.btn_bg.TabIndex = 82;
            this.btn_bg.Text = "Balance General";
            this.btn_bg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_bg.Textcolor = System.Drawing.Color.White;
            this.btn_bg.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_bg.Click += new System.EventHandler(this.btn_bg_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(13, 3);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(946, 10);
            this.bunifuSeparator1.TabIndex = 76;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(13, 521);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(946, 10);
            this.bunifuSeparator2.TabIndex = 75;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(959, 3);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(10, 528);
            this.bunifuSeparator3.TabIndex = 74;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(3, 3);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(10, 528);
            this.bunifuSeparator4.TabIndex = 73;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = true;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuLabel5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuLabel5.Location = new System.Drawing.Point(399, 19);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(190, 34);
            this.bunifuLabel5.TabIndex = 60;
            this.bunifuLabel5.Text = "Empresa FERRISIS";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuLabel7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuLabel7.Location = new System.Drawing.Point(311, -4);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(190, 34);
            this.bunifuLabel7.TabIndex = 80;
            this.bunifuLabel7.Text = "Empresa FERRISIS";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // EstadosFinancieros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 610);
            this.Controls.Add(this.pages_EF);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EstadosFinancieros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadosFinancieros";
            this.Load += new System.EventHandler(this.EstadosFinancieros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            this.pages_EF.ResumeLayout(false);
            this.page_BG.ResumeLayout(false);
            this.page_BG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_capital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_pasivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_activo)).EndInit();
            this.page_ER.ResumeLayout(false);
            this.page_ER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_er)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btn_salir;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuPages pages_EF;
        private System.Windows.Forms.TabPage page_BG;
        private Bunifu.UI.WinForms.BunifuLabel label_pc;
        private Bunifu.UI.WinForms.BunifuLabel label_activo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_nuevo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_er;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.TabPage page_ER;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_bg;
        private Bunifu.UI.WinForms.BunifuDatePicker datepicker_BG;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuLabel lbl_UO;
        private Bunifu.UI.WinForms.BunifuLabel lbl_UDI;
        private Bunifu.UI.WinForms.BunifuLabel lbl_UB;
        private Bunifu.UI.WinForms.BunifuLabel lbl_UN;
        private Bunifu.Framework.UI.BunifuImageButton btn_buscar;
        private System.Windows.Forms.DataGridView tabla_activo;
        private System.Windows.Forms.DataGridView tabla_capital;
        private System.Windows.Forms.DataGridView tabla_pasivo;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private System.Windows.Forms.DataGridView tabla_er;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimizar;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
    }
}