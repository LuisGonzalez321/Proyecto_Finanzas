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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Scrollbar_A = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.tabla_activo = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.datepicker_BG = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btn_salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_nuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label_activo = new Bunifu.UI.WinForms.BunifuLabel();
            this.label_pc = new Bunifu.UI.WinForms.BunifuLabel();
            this.tabla_pasivo = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.tabla_capital = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.bunifuVScrollBar2 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_activo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_pasivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_capital)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuLabel1.Location = new System.Drawing.Point(22, 41);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(79, 34);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "Activos";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuLabel2.Location = new System.Drawing.Point(496, 304);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(76, 34);
            this.bunifuLabel2.TabIndex = 4;
            this.bunifuLabel2.Text = "Capital";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuLabel3.Location = new System.Drawing.Point(496, 38);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(80, 35);
            this.bunifuLabel3.TabIndex = 5;
            this.bunifuLabel3.Text = "Pasivos";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Scrollbar_A
            // 
            this.Scrollbar_A.AllowCursorChanges = true;
            this.Scrollbar_A.AllowHomeEndKeysDetection = false;
            this.Scrollbar_A.AllowIncrementalClickMoves = true;
            this.Scrollbar_A.AllowMouseDownEffects = true;
            this.Scrollbar_A.AllowMouseHoverEffects = true;
            this.Scrollbar_A.AllowScrollingAnimations = true;
            this.Scrollbar_A.AllowScrollKeysDetection = true;
            this.Scrollbar_A.AllowScrollOptionsMenu = true;
            this.Scrollbar_A.AllowShrinkingOnFocusLost = false;
            this.Scrollbar_A.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Scrollbar_A.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Scrollbar_A.BackgroundImage")));
            this.Scrollbar_A.BindingContainer = this.tabla_activo;
            this.Scrollbar_A.BorderColor = System.Drawing.SystemColors.Control;
            this.Scrollbar_A.BorderRadius = 14;
            this.Scrollbar_A.BorderThickness = 1;
            this.Scrollbar_A.DurationBeforeShrink = 2000;
            this.Scrollbar_A.LargeChange = 10;
            this.Scrollbar_A.Location = new System.Drawing.Point(430, 81);
            this.Scrollbar_A.Maximum = 100;
            this.Scrollbar_A.Minimum = 0;
            this.Scrollbar_A.MinimumThumbLength = 18;
            this.Scrollbar_A.Name = "Scrollbar_A";
            this.Scrollbar_A.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.Scrollbar_A.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.Scrollbar_A.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.Scrollbar_A.ScrollBarBorderColor = System.Drawing.SystemColors.Control;
            this.Scrollbar_A.ScrollBarColor = System.Drawing.SystemColors.Control;
            this.Scrollbar_A.ShrinkSizeLimit = 3;
            this.Scrollbar_A.Size = new System.Drawing.Size(12, 468);
            this.Scrollbar_A.SmallChange = 1;
            this.Scrollbar_A.TabIndex = 6;
            this.Scrollbar_A.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.Scrollbar_A.ThumbLength = 46;
            this.Scrollbar_A.ThumbMargin = 1;
            this.Scrollbar_A.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Proportional;
            this.Scrollbar_A.Value = 0;
            // 
            // tabla_activo
            // 
            this.tabla_activo.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tabla_activo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_activo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_activo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_activo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla_activo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_activo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_activo.ColumnHeadersHeight = 40;
            this.tabla_activo.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tabla_activo.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabla_activo.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla_activo.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tabla_activo.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tabla_activo.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tabla_activo.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tabla_activo.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabla_activo.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tabla_activo.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabla_activo.CurrentTheme.Name = null;
            this.tabla_activo.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tabla_activo.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabla_activo.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla_activo.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tabla_activo.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_activo.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla_activo.EnableHeadersVisualStyles = false;
            this.tabla_activo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tabla_activo.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tabla_activo.HeaderForeColor = System.Drawing.Color.White;
            this.tabla_activo.Location = new System.Drawing.Point(22, 79);
            this.tabla_activo.Name = "tabla_activo";
            this.tabla_activo.ReadOnly = true;
            this.tabla_activo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabla_activo.RowHeadersVisible = false;
            this.tabla_activo.RowTemplate.Height = 40;
            this.tabla_activo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tabla_activo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_activo.Size = new System.Drawing.Size(402, 470);
            this.tabla_activo.TabIndex = 48;
            this.tabla_activo.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // datepicker_BG
            // 
            this.datepicker_BG.BorderRadius = 1;
            this.datepicker_BG.Color = System.Drawing.Color.DodgerBlue;
            this.datepicker_BG.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.datepicker_BG.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.datepicker_BG.DisabledColor = System.Drawing.Color.Gray;
            this.datepicker_BG.DisplayWeekNumbers = false;
            this.datepicker_BG.DPHeight = 0;
            this.datepicker_BG.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datepicker_BG.FillDatePicker = false;
            this.datepicker_BG.ForeColor = System.Drawing.Color.DodgerBlue;
            this.datepicker_BG.Icon = ((System.Drawing.Image)(resources.GetObject("datepicker_BG.Icon")));
            this.datepicker_BG.IconColor = System.Drawing.Color.DodgerBlue;
            this.datepicker_BG.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.datepicker_BG.Location = new System.Drawing.Point(207, 43);
            this.datepicker_BG.MinimumSize = new System.Drawing.Size(217, 32);
            this.datepicker_BG.Name = "datepicker_BG";
            this.datepicker_BG.Size = new System.Drawing.Size(217, 32);
            this.datepicker_BG.TabIndex = 7;
            this.datepicker_BG.ValueChanged += new System.EventHandler(this.datepicker_BG_ValueChanged);
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
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Estado de Resultado";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(686, 501);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(210, 48);
            this.bunifuFlatButton1.TabIndex = 9;
            this.bunifuFlatButton1.Text = "Estado de Resultado";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Active = false;
            this.btn_nuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_nuevo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.BorderRadius = 0;
            this.btn_nuevo.ButtonText = "     Nuevo";
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_nuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_nuevo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Iconimage")));
            this.btn_nuevo.Iconimage_right = null;
            this.btn_nuevo.Iconimage_right_Selected = null;
            this.btn_nuevo.Iconimage_Selected = null;
            this.btn_nuevo.IconMarginLeft = 0;
            this.btn_nuevo.IconMarginRight = 0;
            this.btn_nuevo.IconRightVisible = true;
            this.btn_nuevo.IconRightZoom = 0D;
            this.btn_nuevo.IconVisible = true;
            this.btn_nuevo.IconZoom = 90D;
            this.btn_nuevo.IsTab = false;
            this.btn_nuevo.Location = new System.Drawing.Point(496, 502);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btn_nuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_nuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_nuevo.selected = false;
            this.btn_nuevo.Size = new System.Drawing.Size(166, 48);
            this.btn_nuevo.TabIndex = 10;
            this.btn_nuevo.Text = "     Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Textcolor = System.Drawing.Color.White;
            this.btn_nuevo.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.btn_salir);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(980, 35);
            this.bunifuGradientPanel1.TabIndex = 13;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(240)))));
            this.bunifuLabel4.Location = new System.Drawing.Point(393, -2);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(174, 34);
            this.bunifuLabel4.TabIndex = 14;
            this.bunifuLabel4.Text = "Balance General";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label_activo
            // 
            this.label_activo.AutoEllipsis = false;
            this.label_activo.CursorType = null;
            this.label_activo.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label_activo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_activo.Location = new System.Drawing.Point(22, 555);
            this.label_activo.Name = "label_activo";
            this.label_activo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_activo.Size = new System.Drawing.Size(174, 35);
            this.label_activo.TabIndex = 14;
            this.label_activo.Text = "TOTAL ACTIVO :";
            this.label_activo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_activo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label_pc
            // 
            this.label_pc.AutoEllipsis = false;
            this.label_pc.CursorType = null;
            this.label_pc.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label_pc.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_pc.Location = new System.Drawing.Point(496, 555);
            this.label_pc.Name = "label_pc";
            this.label_pc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_pc.Size = new System.Drawing.Size(280, 35);
            this.label_pc.TabIndex = 15;
            this.label_pc.Text = "TOTAL PASIVO Y CAPITAL:";
            this.label_pc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pc.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tabla_pasivo
            // 
            this.tabla_pasivo.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.tabla_pasivo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tabla_pasivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_pasivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_pasivo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla_pasivo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_pasivo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tabla_pasivo.ColumnHeadersHeight = 40;
            this.tabla_pasivo.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tabla_pasivo.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabla_pasivo.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla_pasivo.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tabla_pasivo.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tabla_pasivo.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tabla_pasivo.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tabla_pasivo.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabla_pasivo.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tabla_pasivo.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabla_pasivo.CurrentTheme.Name = null;
            this.tabla_pasivo.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tabla_pasivo.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabla_pasivo.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla_pasivo.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tabla_pasivo.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_pasivo.DefaultCellStyle = dataGridViewCellStyle6;
            this.tabla_pasivo.EnableHeadersVisualStyles = false;
            this.tabla_pasivo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tabla_pasivo.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tabla_pasivo.HeaderForeColor = System.Drawing.Color.White;
            this.tabla_pasivo.Location = new System.Drawing.Point(496, 79);
            this.tabla_pasivo.Name = "tabla_pasivo";
            this.tabla_pasivo.ReadOnly = true;
            this.tabla_pasivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabla_pasivo.RowHeadersVisible = false;
            this.tabla_pasivo.RowTemplate.Height = 40;
            this.tabla_pasivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tabla_pasivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_pasivo.Size = new System.Drawing.Size(382, 207);
            this.tabla_pasivo.TabIndex = 49;
            this.tabla_pasivo.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // tabla_capital
            // 
            this.tabla_capital.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.tabla_capital.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tabla_capital.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_capital.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_capital.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla_capital.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_capital.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tabla_capital.ColumnHeadersHeight = 40;
            this.tabla_capital.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tabla_capital.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabla_capital.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla_capital.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tabla_capital.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tabla_capital.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tabla_capital.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tabla_capital.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabla_capital.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tabla_capital.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabla_capital.CurrentTheme.Name = null;
            this.tabla_capital.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tabla_capital.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabla_capital.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla_capital.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tabla_capital.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_capital.DefaultCellStyle = dataGridViewCellStyle9;
            this.tabla_capital.EnableHeadersVisualStyles = false;
            this.tabla_capital.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tabla_capital.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tabla_capital.HeaderForeColor = System.Drawing.Color.White;
            this.tabla_capital.Location = new System.Drawing.Point(496, 344);
            this.tabla_capital.Name = "tabla_capital";
            this.tabla_capital.ReadOnly = true;
            this.tabla_capital.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabla_capital.RowHeadersVisible = false;
            this.tabla_capital.RowTemplate.Height = 40;
            this.tabla_capital.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tabla_capital.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_capital.Size = new System.Drawing.Size(382, 151);
            this.tabla_capital.TabIndex = 50;
            this.tabla_capital.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuVScrollBar1
            // 
            this.bunifuVScrollBar1.AllowCursorChanges = true;
            this.bunifuVScrollBar1.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar1.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar1.AllowMouseDownEffects = true;
            this.bunifuVScrollBar1.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar1.AllowScrollingAnimations = true;
            this.bunifuVScrollBar1.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar1.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar1.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = this.tabla_pasivo;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.SystemColors.Control;
            this.bunifuVScrollBar1.BorderRadius = 14;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(884, 79);
            this.bunifuVScrollBar1.Maximum = 100;
            this.bunifuVScrollBar1.Minimum = 0;
            this.bunifuVScrollBar1.MinimumThumbLength = 18;
            this.bunifuVScrollBar1.Name = "bunifuVScrollBar1";
            this.bunifuVScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.ScrollBarBorderColor = System.Drawing.SystemColors.Control;
            this.bunifuVScrollBar1.ScrollBarColor = System.Drawing.SystemColors.Control;
            this.bunifuVScrollBar1.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar1.Size = new System.Drawing.Size(12, 207);
            this.bunifuVScrollBar1.SmallChange = 1;
            this.bunifuVScrollBar1.TabIndex = 51;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.bunifuVScrollBar1.ThumbLength = 20;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Proportional;
            this.bunifuVScrollBar1.Value = 0;
            // 
            // bunifuVScrollBar2
            // 
            this.bunifuVScrollBar2.AllowCursorChanges = true;
            this.bunifuVScrollBar2.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar2.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar2.AllowMouseDownEffects = true;
            this.bunifuVScrollBar2.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar2.AllowScrollingAnimations = true;
            this.bunifuVScrollBar2.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar2.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar2.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bunifuVScrollBar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar2.BackgroundImage")));
            this.bunifuVScrollBar2.BindingContainer = this.tabla_capital;
            this.bunifuVScrollBar2.BorderColor = System.Drawing.SystemColors.Control;
            this.bunifuVScrollBar2.BorderRadius = 14;
            this.bunifuVScrollBar2.BorderThickness = 1;
            this.bunifuVScrollBar2.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar2.LargeChange = 10;
            this.bunifuVScrollBar2.Location = new System.Drawing.Point(884, 344);
            this.bunifuVScrollBar2.Maximum = 100;
            this.bunifuVScrollBar2.Minimum = 0;
            this.bunifuVScrollBar2.MinimumThumbLength = 18;
            this.bunifuVScrollBar2.Name = "bunifuVScrollBar2";
            this.bunifuVScrollBar2.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar2.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar2.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar2.ScrollBarBorderColor = System.Drawing.SystemColors.Control;
            this.bunifuVScrollBar2.ScrollBarColor = System.Drawing.SystemColors.Control;
            this.bunifuVScrollBar2.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar2.Size = new System.Drawing.Size(12, 151);
            this.bunifuVScrollBar2.SmallChange = 1;
            this.bunifuVScrollBar2.TabIndex = 52;
            this.bunifuVScrollBar2.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.bunifuVScrollBar2.ThumbLength = 18;
            this.bunifuVScrollBar2.ThumbMargin = 1;
            this.bunifuVScrollBar2.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Proportional;
            this.bunifuVScrollBar2.Value = 0;
            // 
            // EstadosFinancieros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 610);
            this.Controls.Add(this.bunifuVScrollBar2);
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.tabla_capital);
            this.Controls.Add(this.tabla_pasivo);
            this.Controls.Add(this.tabla_activo);
            this.Controls.Add(this.label_pc);
            this.Controls.Add(this.label_activo);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.datepicker_BG);
            this.Controls.Add(this.Scrollbar_A);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstadosFinancieros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadosFinancieros";
            this.Load += new System.EventHandler(this.EstadosFinancieros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_activo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_pasivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_capital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuVScrollBar Scrollbar_A;
        private Bunifu.UI.WinForms.BunifuDatePicker datepicker_BG;
        private Bunifu.Framework.UI.BunifuImageButton btn_salir;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_nuevo;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel label_activo;
        private Bunifu.UI.WinForms.BunifuLabel label_pc;
        private Bunifu.UI.WinForms.BunifuDataGridView tabla_activo;
        private Bunifu.UI.WinForms.BunifuDataGridView tabla_pasivo;
        private Bunifu.UI.WinForms.BunifuDataGridView tabla_capital;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar2;
    }
}