namespace Finanzas.Vista
{
    partial class Apalancamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apalancamiento));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.group_financiero = new System.Windows.Forms.GroupBox();
            this.btn_calcularGAF = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbl_UAII = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_UPA = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbl_GAF = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_dividendos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_financiero = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_impuesto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_UAI = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel12 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_interes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.group_operativo = new System.Windows.Forms.GroupBox();
            this.txt_cantidad = new System.Windows.Forms.NumericUpDown();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_calcular = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_GastosOp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_GAO = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_CostosF = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_VistaOperativa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_costos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_ventas = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.group_financiero.SuspendLayout();
            this.group_operativo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel4.Location = new System.Drawing.Point(337, 12);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(306, 40);
            this.bunifuLabel4.TabIndex = 7;
            this.bunifuLabel4.Text = "APALANCAMIENTO";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.ImageActive = null;
            this.btn_minimizar.Location = new System.Drawing.Point(897, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(38, 37);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimizar.TabIndex = 12;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Zoom = 10;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageActive = null;
            this.btn_salir.Location = new System.Drawing.Point(941, 3);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(37, 37);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 11;
            this.btn_salir.TabStop = false;
            this.btn_salir.Zoom = 10;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 58);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(964, 10);
            this.bunifuSeparator1.TabIndex = 14;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.group_financiero);
            this.groupBox2.Controls.Add(this.group_operativo);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(956, 524);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apalancamiento Total";
            // 
            // group_financiero
            // 
            this.group_financiero.Controls.Add(this.btn_calcularGAF);
            this.group_financiero.Controls.Add(this.lbl_UAII);
            this.group_financiero.Controls.Add(this.lbl_UPA);
            this.group_financiero.Controls.Add(this.bunifuThinButton21);
            this.group_financiero.Controls.Add(this.lbl_GAF);
            this.group_financiero.Controls.Add(this.txt_dividendos);
            this.group_financiero.Controls.Add(this.bunifuLabel9);
            this.group_financiero.Controls.Add(this.btn_financiero);
            this.group_financiero.Controls.Add(this.bunifuLabel10);
            this.group_financiero.Controls.Add(this.txt_impuesto);
            this.group_financiero.Controls.Add(this.lbl_UAI);
            this.group_financiero.Controls.Add(this.bunifuLabel12);
            this.group_financiero.Controls.Add(this.txt_interes);
            this.group_financiero.Dock = System.Windows.Forms.DockStyle.Top;
            this.group_financiero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_financiero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.group_financiero.Location = new System.Drawing.Point(3, 436);
            this.group_financiero.Name = "group_financiero";
            this.group_financiero.Size = new System.Drawing.Size(950, 209);
            this.group_financiero.TabIndex = 15;
            this.group_financiero.TabStop = false;
            this.group_financiero.Text = "Apalancamiento";
            // 
            // btn_calcularGAF
            // 
            this.btn_calcularGAF.ActiveBorderThickness = 1;
            this.btn_calcularGAF.ActiveCornerRadius = 20;
            this.btn_calcularGAF.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_calcularGAF.ActiveForecolor = System.Drawing.Color.White;
            this.btn_calcularGAF.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btn_calcularGAF.BackColor = System.Drawing.Color.White;
            this.btn_calcularGAF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_calcularGAF.BackgroundImage")));
            this.btn_calcularGAF.ButtonText = "Calcular";
            this.btn_calcularGAF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calcularGAF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcularGAF.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_calcularGAF.IdleBorderThickness = 1;
            this.btn_calcularGAF.IdleCornerRadius = 20;
            this.btn_calcularGAF.IdleFillColor = System.Drawing.Color.White;
            this.btn_calcularGAF.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_calcularGAF.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btn_calcularGAF.Location = new System.Drawing.Point(288, 374);
            this.btn_calcularGAF.Margin = new System.Windows.Forms.Padding(5);
            this.btn_calcularGAF.Name = "btn_calcularGAF";
            this.btn_calcularGAF.Size = new System.Drawing.Size(140, 41);
            this.btn_calcularGAF.TabIndex = 15;
            this.btn_calcularGAF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_calcularGAF.Click += new System.EventHandler(this.btn_calcularGAF_Click);
            // 
            // lbl_UAII
            // 
            this.lbl_UAII.AutoEllipsis = false;
            this.lbl_UAII.CursorType = null;
            this.lbl_UAII.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UAII.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_UAII.Location = new System.Drawing.Point(18, 195);
            this.lbl_UAII.Name = "lbl_UAII";
            this.lbl_UAII.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_UAII.Size = new System.Drawing.Size(300, 23);
            this.lbl_UAII.TabIndex = 14;
            this.lbl_UAII.Text = "Utilidad antes de impuestos e interes(UAII): ";
            this.lbl_UAII.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_UAII.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_UPA
            // 
            this.lbl_UPA.AutoEllipsis = false;
            this.lbl_UPA.CursorType = null;
            this.lbl_UPA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UPA.Location = new System.Drawing.Point(18, 295);
            this.lbl_UPA.Name = "lbl_UPA";
            this.lbl_UPA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_UPA.Size = new System.Drawing.Size(180, 23);
            this.lbl_UPA.TabIndex = 13;
            this.lbl_UPA.Text = "Utilidad por acción(UPA) :";
            this.lbl_UPA.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_UPA.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Calcular";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(288, 442);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(140, 41);
            this.bunifuThinButton21.TabIndex = 12;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GAF
            // 
            this.lbl_GAF.AutoEllipsis = false;
            this.lbl_GAF.CursorType = null;
            this.lbl_GAF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GAF.Location = new System.Drawing.Point(18, 340);
            this.lbl_GAF.Name = "lbl_GAF";
            this.lbl_GAF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_GAF.Size = new System.Drawing.Size(261, 23);
            this.lbl_GAF.TabIndex = 9;
            this.lbl_GAF.Text = "Grado de apalancamiento financiero :";
            this.lbl_GAF.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_GAF.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_dividendos
            // 
            this.txt_dividendos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_dividendos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_dividendos.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_dividendos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dividendos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_dividendos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_dividendos.HintForeColor = System.Drawing.Color.Empty;
            this.txt_dividendos.HintText = "0.00";
            this.txt_dividendos.isPassword = false;
            this.txt_dividendos.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_dividendos.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_dividendos.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_dividendos.LineThickness = 3;
            this.txt_dividendos.Location = new System.Drawing.Point(275, 233);
            this.txt_dividendos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dividendos.MaxLength = 12;
            this.txt_dividendos.Name = "txt_dividendos";
            this.txt_dividendos.Size = new System.Drawing.Size(114, 33);
            this.txt_dividendos.TabIndex = 7;
            this.txt_dividendos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.CursorType = null;
            this.bunifuLabel9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel9.Location = new System.Drawing.Point(15, 234);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(253, 34);
            this.bunifuLabel9.TabIndex = 8;
            this.bunifuLabel9.Text = "Dividendos por acción :";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_financiero
            // 
            this.btn_financiero.Active = false;
            this.btn_financiero.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btn_financiero.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_financiero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_financiero.BorderRadius = 7;
            this.btn_financiero.ButtonText = "FINANCIERO";
            this.btn_financiero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_financiero.DisabledColor = System.Drawing.Color.Gray;
            this.btn_financiero.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_financiero.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_financiero.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_financiero.Iconimage")));
            this.btn_financiero.Iconimage_right = null;
            this.btn_financiero.Iconimage_right_Selected = null;
            this.btn_financiero.Iconimage_Selected = null;
            this.btn_financiero.IconMarginLeft = 0;
            this.btn_financiero.IconMarginRight = 0;
            this.btn_financiero.IconRightVisible = true;
            this.btn_financiero.IconRightZoom = 0D;
            this.btn_financiero.IconVisible = true;
            this.btn_financiero.IconZoom = 90D;
            this.btn_financiero.IsTab = false;
            this.btn_financiero.Location = new System.Drawing.Point(3, 21);
            this.btn_financiero.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_financiero.Name = "btn_financiero";
            this.btn_financiero.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btn_financiero.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_financiero.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_financiero.selected = false;
            this.btn_financiero.Size = new System.Drawing.Size(944, 42);
            this.btn_financiero.TabIndex = 0;
            this.btn_financiero.Text = "FINANCIERO";
            this.btn_financiero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_financiero.Textcolor = System.Drawing.Color.White;
            this.btn_financiero.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_financiero.Click += new System.EventHandler(this.btn_financiero_Click);
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.AutoEllipsis = false;
            this.bunifuLabel10.CursorType = null;
            this.bunifuLabel10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel10.Location = new System.Drawing.Point(18, 71);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(110, 34);
            this.bunifuLabel10.TabIndex = 1;
            this.bunifuLabel10.Text = "Intereses :";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_impuesto
            // 
            this.txt_impuesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_impuesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_impuesto.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_impuesto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_impuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_impuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_impuesto.HintForeColor = System.Drawing.Color.Empty;
            this.txt_impuesto.HintText = "0.00";
            this.txt_impuesto.isPassword = false;
            this.txt_impuesto.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_impuesto.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_impuesto.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_impuesto.LineThickness = 3;
            this.txt_impuesto.Location = new System.Drawing.Point(155, 142);
            this.txt_impuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_impuesto.MaxLength = 12;
            this.txt_impuesto.Name = "txt_impuesto";
            this.txt_impuesto.Size = new System.Drawing.Size(118, 37);
            this.txt_impuesto.TabIndex = 2;
            this.txt_impuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_UAI
            // 
            this.lbl_UAI.AutoEllipsis = false;
            this.lbl_UAI.CursorType = null;
            this.lbl_UAI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UAI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_UAI.Location = new System.Drawing.Point(18, 116);
            this.lbl_UAI.Name = "lbl_UAI";
            this.lbl_UAI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_UAI.Size = new System.Drawing.Size(237, 23);
            this.lbl_UAI.TabIndex = 6;
            this.lbl_UAI.Text = "Utilidad antes de impuestos(UAI) : ";
            this.lbl_UAI.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_UAI.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel12
            // 
            this.bunifuLabel12.AutoEllipsis = false;
            this.bunifuLabel12.CursorType = null;
            this.bunifuLabel12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel12.Location = new System.Drawing.Point(18, 145);
            this.bunifuLabel12.Name = "bunifuLabel12";
            this.bunifuLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel12.Size = new System.Drawing.Size(125, 34);
            this.bunifuLabel12.TabIndex = 4;
            this.bunifuLabel12.Text = "Impuestos :";
            this.bunifuLabel12.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel12.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_interes
            // 
            this.txt_interes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_interes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_interes.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_interes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_interes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_interes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_interes.HintForeColor = System.Drawing.Color.Empty;
            this.txt_interes.HintText = "0.00";
            this.txt_interes.isPassword = false;
            this.txt_interes.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_interes.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_interes.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_interes.LineThickness = 3;
            this.txt_interes.Location = new System.Drawing.Point(138, 71);
            this.txt_interes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_interes.MaxLength = 12;
            this.txt_interes.Name = "txt_interes";
            this.txt_interes.Size = new System.Drawing.Size(118, 33);
            this.txt_interes.TabIndex = 5;
            this.txt_interes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // group_operativo
            // 
            this.group_operativo.Controls.Add(this.txt_cantidad);
            this.group_operativo.Controls.Add(this.bunifuLabel3);
            this.group_operativo.Controls.Add(this.btn_calcular);
            this.group_operativo.Controls.Add(this.txt_GastosOp);
            this.group_operativo.Controls.Add(this.bunifuLabel6);
            this.group_operativo.Controls.Add(this.lbl_GAO);
            this.group_operativo.Controls.Add(this.txt_CostosF);
            this.group_operativo.Controls.Add(this.bunifuLabel5);
            this.group_operativo.Controls.Add(this.btn_VistaOperativa);
            this.group_operativo.Controls.Add(this.bunifuLabel1);
            this.group_operativo.Controls.Add(this.txt_costos);
            this.group_operativo.Controls.Add(this.bunifuLabel2);
            this.group_operativo.Controls.Add(this.txt_ventas);
            this.group_operativo.Dock = System.Windows.Forms.DockStyle.Top;
            this.group_operativo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_operativo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.group_operativo.Location = new System.Drawing.Point(3, 21);
            this.group_operativo.Name = "group_operativo";
            this.group_operativo.Size = new System.Drawing.Size(950, 415);
            this.group_operativo.TabIndex = 14;
            this.group_operativo.TabStop = false;
            this.group_operativo.Text = "Apalancamiento";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cantidad.Location = new System.Drawing.Point(197, 82);
            this.txt_cantidad.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(105, 25);
            this.txt_cantidad.TabIndex = 13;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(18, 82);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(145, 23);
            this.bunifuLabel3.TabIndex = 14;
            this.bunifuLabel3.Text = "Nivel de producción:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_calcular
            // 
            this.btn_calcular.ActiveBorderThickness = 1;
            this.btn_calcular.ActiveCornerRadius = 20;
            this.btn_calcular.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_calcular.ActiveForecolor = System.Drawing.Color.White;
            this.btn_calcular.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btn_calcular.BackColor = System.Drawing.Color.White;
            this.btn_calcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_calcular.BackgroundImage")));
            this.btn_calcular.ButtonText = "Calcular";
            this.btn_calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_calcular.IdleBorderThickness = 1;
            this.btn_calcular.IdleCornerRadius = 20;
            this.btn_calcular.IdleFillColor = System.Drawing.Color.White;
            this.btn_calcular.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_calcular.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btn_calcular.Location = new System.Drawing.Point(249, 373);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(5);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(140, 41);
            this.btn_calcular.TabIndex = 12;
            this.btn_calcular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_GastosOp
            // 
            this.txt_GastosOp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_GastosOp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_GastosOp.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_GastosOp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_GastosOp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_GastosOp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_GastosOp.HintForeColor = System.Drawing.Color.Empty;
            this.txt_GastosOp.HintText = "0.00";
            this.txt_GastosOp.isPassword = false;
            this.txt_GastosOp.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_GastosOp.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_GastosOp.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_GastosOp.LineThickness = 3;
            this.txt_GastosOp.Location = new System.Drawing.Point(232, 283);
            this.txt_GastosOp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GastosOp.MaxLength = 12;
            this.txt_GastosOp.Name = "txt_GastosOp";
            this.txt_GastosOp.Size = new System.Drawing.Size(114, 33);
            this.txt_GastosOp.TabIndex = 10;
            this.txt_GastosOp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel6.Location = new System.Drawing.Point(18, 283);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(207, 34);
            this.bunifuLabel6.TabIndex = 11;
            this.bunifuLabel6.Text = "Gastos Operativos :";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_GAO
            // 
            this.lbl_GAO.AutoEllipsis = false;
            this.lbl_GAO.CursorType = null;
            this.lbl_GAO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GAO.Location = new System.Drawing.Point(18, 339);
            this.lbl_GAO.Name = "lbl_GAO";
            this.lbl_GAO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_GAO.Size = new System.Drawing.Size(258, 23);
            this.lbl_GAO.TabIndex = 9;
            this.lbl_GAO.Text = "Grado de apalancamiento operativo :";
            this.lbl_GAO.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_GAO.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_CostosF
            // 
            this.txt_CostosF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_CostosF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_CostosF.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_CostosF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CostosF.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_CostosF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_CostosF.HintForeColor = System.Drawing.Color.Empty;
            this.txt_CostosF.HintText = "0.00";
            this.txt_CostosF.isPassword = false;
            this.txt_CostosF.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_CostosF.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_CostosF.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_CostosF.LineThickness = 3;
            this.txt_CostosF.Location = new System.Drawing.Point(175, 227);
            this.txt_CostosF.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CostosF.MaxLength = 12;
            this.txt_CostosF.Name = "txt_CostosF";
            this.txt_CostosF.Size = new System.Drawing.Size(114, 33);
            this.txt_CostosF.TabIndex = 7;
            this.txt_CostosF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel5.Location = new System.Drawing.Point(18, 227);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(141, 34);
            this.bunifuLabel5.TabIndex = 8;
            this.bunifuLabel5.Text = "Costos Fijos :";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_VistaOperativa
            // 
            this.btn_VistaOperativa.Active = false;
            this.btn_VistaOperativa.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btn_VistaOperativa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_VistaOperativa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_VistaOperativa.BorderRadius = 7;
            this.btn_VistaOperativa.ButtonText = "OPERATIVO";
            this.btn_VistaOperativa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VistaOperativa.DisabledColor = System.Drawing.Color.Gray;
            this.btn_VistaOperativa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_VistaOperativa.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_VistaOperativa.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_VistaOperativa.Iconimage")));
            this.btn_VistaOperativa.Iconimage_right = null;
            this.btn_VistaOperativa.Iconimage_right_Selected = null;
            this.btn_VistaOperativa.Iconimage_Selected = null;
            this.btn_VistaOperativa.IconMarginLeft = 0;
            this.btn_VistaOperativa.IconMarginRight = 0;
            this.btn_VistaOperativa.IconRightVisible = true;
            this.btn_VistaOperativa.IconRightZoom = 0D;
            this.btn_VistaOperativa.IconVisible = true;
            this.btn_VistaOperativa.IconZoom = 90D;
            this.btn_VistaOperativa.IsTab = false;
            this.btn_VistaOperativa.Location = new System.Drawing.Point(3, 21);
            this.btn_VistaOperativa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_VistaOperativa.Name = "btn_VistaOperativa";
            this.btn_VistaOperativa.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btn_VistaOperativa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_VistaOperativa.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_VistaOperativa.selected = false;
            this.btn_VistaOperativa.Size = new System.Drawing.Size(944, 42);
            this.btn_VistaOperativa.TabIndex = 0;
            this.btn_VistaOperativa.Text = "OPERATIVO";
            this.btn_VistaOperativa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VistaOperativa.Textcolor = System.Drawing.Color.White;
            this.btn_VistaOperativa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VistaOperativa.Click += new System.EventHandler(this.btn_VistaOperativa_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(18, 126);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(87, 34);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Ventas :";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_costos
            // 
            this.txt_costos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_costos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_costos.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_costos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_costos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_costos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_costos.HintForeColor = System.Drawing.Color.Empty;
            this.txt_costos.HintText = "0.00";
            this.txt_costos.isPassword = false;
            this.txt_costos.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_costos.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_costos.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_costos.LineThickness = 3;
            this.txt_costos.Location = new System.Drawing.Point(123, 167);
            this.txt_costos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_costos.MaxLength = 12;
            this.txt_costos.Name = "txt_costos";
            this.txt_costos.Size = new System.Drawing.Size(118, 37);
            this.txt_costos.TabIndex = 2;
            this.txt_costos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(19, 176);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(86, 34);
            this.bunifuLabel2.TabIndex = 4;
            this.bunifuLabel2.Text = "Costos :";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_ventas
            // 
            this.txt_ventas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_ventas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_ventas.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_ventas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ventas.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ventas.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ventas.HintText = "0.00";
            this.txt_ventas.isPassword = false;
            this.txt_ventas.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_ventas.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_ventas.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_ventas.LineThickness = 3;
            this.txt_ventas.Location = new System.Drawing.Point(123, 126);
            this.txt_ventas.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ventas.MaxLength = 12;
            this.txt_ventas.Name = "txt_ventas";
            this.txt_ventas.Size = new System.Drawing.Size(118, 33);
            this.txt_ventas.TabIndex = 5;
            this.txt_ventas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Apalancamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 610);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btn_minimizar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.bunifuLabel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Apalancamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apalancamiento";
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.group_financiero.ResumeLayout(false);
            this.group_financiero.PerformLayout();
            this.group_operativo.ResumeLayout(false);
            this.group_operativo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimizar;
        private Bunifu.Framework.UI.BunifuImageButton btn_salir;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox group_financiero;
        private Bunifu.UI.WinForms.BunifuLabel lbl_UAII;
        private Bunifu.UI.WinForms.BunifuLabel lbl_UPA;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.UI.WinForms.BunifuLabel lbl_GAF;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_dividendos;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private Bunifu.Framework.UI.BunifuFlatButton btn_financiero;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_impuesto;
        private Bunifu.UI.WinForms.BunifuLabel lbl_UAI;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_interes;
        private System.Windows.Forms.GroupBox group_operativo;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_calcular;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_GastosOp;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel lbl_GAO;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_CostosF;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.Framework.UI.BunifuFlatButton btn_VistaOperativa;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_costos;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ventas;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_calcularGAF;
        private System.Windows.Forms.NumericUpDown txt_cantidad;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}