namespace Finanzas.Vista
{
    partial class OA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OA));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lista_añosSelectOA = new System.Windows.Forms.ListBox();
            this.btn_izquierda = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_derecha = new Bunifu.Framework.UI.BunifuImageButton();
            this.lista_añosOA = new System.Windows.Forms.ListBox();
            this.tabla_ah = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lb_AH = new System.Windows.Forms.Label();
            this.lb_añoA = new System.Windows.Forms.Label();
            this.lb_añoB = new System.Windows.Forms.Label();
            this.lb_TOTAL_ACT = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_izquierda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_derecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_ah)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btn_minimizar);
            this.bunifuGradientPanel1.Controls.Add(this.btn_salir);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(979, 60);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.ImageActive = null;
            this.btn_minimizar.Location = new System.Drawing.Point(1169, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(40, 40);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimizar.TabIndex = 6;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Zoom = 10;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageActive = null;
            this.btn_salir.Location = new System.Drawing.Point(1206, 0);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 40);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 5;
            this.btn_salir.TabStop = false;
            this.btn_salir.Zoom = 10;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(370, 13);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(246, 34);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "ORIGEN Y APLICACIÓN";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // elipse
            // 
            this.elipse.ElipseRadius = 7;
            this.elipse.TargetControl = this;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 600);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(979, 10);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 60);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(979, 10);
            this.bunifuSeparator2.TabIndex = 2;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(0, 70);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(10, 530);
            this.bunifuSeparator3.TabIndex = 3;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(969, 70);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(10, 530);
            this.bunifuSeparator4.TabIndex = 4;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lista_añosSelectOA);
            this.groupBox1.Controls.Add(this.btn_izquierda);
            this.groupBox1.Controls.Add(this.btn_derecha);
            this.groupBox1.Controls.Add(this.lista_añosOA);
            this.groupBox1.Location = new System.Drawing.Point(16, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 182);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar años a comparar";
            // 
            // lista_añosSelectOA
            // 
            this.lista_añosSelectOA.FormattingEnabled = true;
            this.lista_añosSelectOA.Location = new System.Drawing.Point(115, 40);
            this.lista_añosSelectOA.Name = "lista_añosSelectOA";
            this.lista_añosSelectOA.Size = new System.Drawing.Size(70, 121);
            this.lista_añosSelectOA.TabIndex = 12;
            // 
            // btn_izquierda
            // 
            this.btn_izquierda.Image = ((System.Drawing.Image)(resources.GetObject("btn_izquierda.Image")));
            this.btn_izquierda.ImageActive = null;
            this.btn_izquierda.Location = new System.Drawing.Point(82, 101);
            this.btn_izquierda.Name = "btn_izquierda";
            this.btn_izquierda.Size = new System.Drawing.Size(27, 29);
            this.btn_izquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_izquierda.TabIndex = 11;
            this.btn_izquierda.TabStop = false;
            this.btn_izquierda.Zoom = 10;
            this.btn_izquierda.Click += new System.EventHandler(this.btn_izquierda_Click);
            // 
            // btn_derecha
            // 
            this.btn_derecha.Image = ((System.Drawing.Image)(resources.GetObject("btn_derecha.Image")));
            this.btn_derecha.ImageActive = null;
            this.btn_derecha.Location = new System.Drawing.Point(82, 66);
            this.btn_derecha.Name = "btn_derecha";
            this.btn_derecha.Size = new System.Drawing.Size(27, 29);
            this.btn_derecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_derecha.TabIndex = 10;
            this.btn_derecha.TabStop = false;
            this.btn_derecha.Zoom = 10;
            this.btn_derecha.Click += new System.EventHandler(this.btn_derecha_Click);
            // 
            // lista_añosOA
            // 
            this.lista_añosOA.FormattingEnabled = true;
            this.lista_añosOA.Location = new System.Drawing.Point(6, 40);
            this.lista_añosOA.Name = "lista_añosOA";
            this.lista_añosOA.Size = new System.Drawing.Size(70, 121);
            this.lista_añosOA.TabIndex = 9;
            // 
            // tabla_ah
            // 
            this.tabla_ah.AllowCustomTheming = false;
            this.tabla_ah.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tabla_ah.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_ah.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_ah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_ah.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla_ah.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_ah.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_ah.ColumnHeadersHeight = 40;
            this.tabla_ah.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tabla_ah.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabla_ah.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla_ah.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tabla_ah.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tabla_ah.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tabla_ah.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tabla_ah.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabla_ah.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tabla_ah.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabla_ah.CurrentTheme.Name = null;
            this.tabla_ah.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tabla_ah.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabla_ah.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla_ah.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tabla_ah.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_ah.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla_ah.EnableHeadersVisualStyles = false;
            this.tabla_ah.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tabla_ah.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tabla_ah.HeaderBgColor = System.Drawing.Color.Empty;
            this.tabla_ah.HeaderForeColor = System.Drawing.Color.White;
            this.tabla_ah.Location = new System.Drawing.Point(248, 110);
            this.tabla_ah.Name = "tabla_ah";
            this.tabla_ah.RowHeadersVisible = false;
            this.tabla_ah.RowTemplate.Height = 40;
            this.tabla_ah.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_ah.Size = new System.Drawing.Size(715, 476);
            this.tabla_ah.TabIndex = 8;
            this.tabla_ah.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // lb_AH
            // 
            this.lb_AH.AutoSize = true;
            this.lb_AH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_AH.Location = new System.Drawing.Point(279, 84);
            this.lb_AH.Name = "lb_AH";
            this.lb_AH.Size = new System.Drawing.Size(261, 23);
            this.lb_AH.TabIndex = 10;
            this.lb_AH.Text = "Estado de Origen y Aplicación";
            // 
            // lb_añoA
            // 
            this.lb_añoA.AutoSize = true;
            this.lb_añoA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_añoA.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_añoA.Location = new System.Drawing.Point(595, 87);
            this.lb_añoA.Name = "lb_añoA";
            this.lb_añoA.Size = new System.Drawing.Size(47, 19);
            this.lb_añoA.TabIndex = 12;
            this.lb_añoA.Text = " AÑO";
            // 
            // lb_añoB
            // 
            this.lb_añoB.AutoSize = true;
            this.lb_añoB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_añoB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_añoB.Location = new System.Drawing.Point(700, 88);
            this.lb_añoB.Name = "lb_añoB";
            this.lb_añoB.Size = new System.Drawing.Size(47, 19);
            this.lb_añoB.TabIndex = 13;
            this.lb_añoB.Text = " AÑO";
            // 
            // lb_TOTAL_ACT
            // 
            this.lb_TOTAL_ACT.AutoSize = true;
            this.lb_TOTAL_ACT.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TOTAL_ACT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_TOTAL_ACT.Location = new System.Drawing.Point(26, 275);
            this.lb_TOTAL_ACT.Name = "lb_TOTAL_ACT";
            this.lb_TOTAL_ACT.Size = new System.Drawing.Size(129, 30);
            this.lb_TOTAL_ACT.TabIndex = 15;
            this.lb_TOTAL_ACT.Text = "Total Activo\r\n";
            // 
            // OA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 610);
            this.Controls.Add(this.lb_TOTAL_ACT);
            this.Controls.Add(this.lb_añoB);
            this.Controls.Add(this.lb_añoA);
            this.Controls.Add(this.lb_AH);
            this.Controls.Add(this.tabla_ah);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análisis_Financiero";
            this.Load += new System.EventHandler(this.Análisis_Financiero_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_izquierda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_derecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_ah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse elipse;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimizar;
        private Bunifu.Framework.UI.BunifuImageButton btn_salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lista_añosSelectOA;
        private Bunifu.Framework.UI.BunifuImageButton btn_izquierda;
        private Bunifu.Framework.UI.BunifuImageButton btn_derecha;
        private System.Windows.Forms.ListBox lista_añosOA;
        private Bunifu.UI.WinForms.BunifuDataGridView tabla_ah;
        private System.Windows.Forms.Label lb_AH;
        private System.Windows.Forms.Label lb_añoB;
        private System.Windows.Forms.Label lb_añoA;
        private System.Windows.Forms.Label lb_TOTAL_ACT;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}