namespace Finanzas.Vista
{
    partial class MessageWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageWindow));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.btn_aceptar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbl_comentario = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_nombre = new Bunifu.UI.WinForms.BunifuLabel();
            this.tool_formula = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.btn_aceptar);
            this.bunifuShadowPanel1.Controls.Add(this.lbl_comentario);
            this.bunifuShadowPanel1.Controls.Add(this.lbl_nombre);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 1;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(395, 222);
            this.bunifuShadowPanel1.TabIndex = 1;
            this.tool_formula.SetToolTip(this.bunifuShadowPanel1, "");
            this.tool_formula.SetToolTipIcon(this.bunifuShadowPanel1, null);
            this.tool_formula.SetToolTipTitle(this.bunifuShadowPanel1, "");
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.ActiveBorderThickness = 1;
            this.btn_aceptar.ActiveCornerRadius = 20;
            this.btn_aceptar.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_aceptar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_aceptar.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btn_aceptar.BackColor = System.Drawing.Color.White;
            this.btn_aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_aceptar.BackgroundImage")));
            this.btn_aceptar.ButtonText = "Aceptar";
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_aceptar.IdleBorderThickness = 1;
            this.btn_aceptar.IdleCornerRadius = 20;
            this.btn_aceptar.IdleFillColor = System.Drawing.Color.White;
            this.btn_aceptar.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btn_aceptar.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btn_aceptar.Location = new System.Drawing.Point(200, 176);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(181, 41);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tool_formula.SetToolTip(this.btn_aceptar, "");
            this.tool_formula.SetToolTipIcon(this.btn_aceptar, null);
            this.tool_formula.SetToolTipTitle(this.btn_aceptar, "");
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click_1);
            // 
            // lbl_comentario
            // 
            this.lbl_comentario.AutoEllipsis = false;
            this.lbl_comentario.CursorType = null;
            this.lbl_comentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_comentario.ForeColor = System.Drawing.Color.Gray;
            this.lbl_comentario.Location = new System.Drawing.Point(12, 107);
            this.lbl_comentario.Name = "lbl_comentario";
            this.lbl_comentario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_comentario.Size = new System.Drawing.Size(75, 17);
            this.lbl_comentario.TabIndex = 1;
            this.lbl_comentario.Text = "bunifuLabel2";
            this.lbl_comentario.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_comentario.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.tool_formula.SetToolTip(this.lbl_comentario, "");
            this.tool_formula.SetToolTipIcon(this.lbl_comentario, null);
            this.tool_formula.SetToolTipTitle(this.lbl_comentario, "");
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoEllipsis = false;
            this.lbl_nombre.CursorType = null;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_nombre.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_nombre.Location = new System.Drawing.Point(27, 21);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_nombre.Size = new System.Drawing.Size(141, 31);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "bunifuLabel1";
            this.lbl_nombre.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_nombre.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.tool_formula.SetToolTip(this.lbl_nombre, "");
            this.tool_formula.SetToolTipIcon(this.lbl_nombre, null);
            this.tool_formula.SetToolTipTitle(this.lbl_nombre, "");
            this.lbl_nombre.MouseEnter += new System.EventHandler(this.lbl_nombre_MouseEnter);
            // 
            // tool_formula
            // 
            this.tool_formula.Active = true;
            this.tool_formula.AlignTextWithTitle = false;
            this.tool_formula.AllowAutoClose = false;
            this.tool_formula.AllowFading = true;
            this.tool_formula.AutoCloseDuration = 5000;
            this.tool_formula.BackColor = System.Drawing.SystemColors.Control;
            this.tool_formula.BorderColor = System.Drawing.Color.Gainsboro;
            this.tool_formula.ClickToShowDisplayControl = false;
            this.tool_formula.ConvertNewlinesToBreakTags = true;
            this.tool_formula.DisplayControl = null;
            this.tool_formula.EntryAnimationSpeed = 350;
            this.tool_formula.ExitAnimationSpeed = 200;
            this.tool_formula.GenerateAutoCloseDuration = false;
            this.tool_formula.IconMargin = 6;
            this.tool_formula.InitialDelay = 0;
            this.tool_formula.Name = "tool_formula";
            this.tool_formula.Opacity = 1D;
            this.tool_formula.OverrideToolTipTitles = false;
            this.tool_formula.Padding = new System.Windows.Forms.Padding(10);
            this.tool_formula.ReshowDelay = 100;
            this.tool_formula.ShowAlways = true;
            this.tool_formula.ShowBorders = false;
            this.tool_formula.ShowIcons = true;
            this.tool_formula.ShowShadows = true;
            this.tool_formula.Tag = null;
            this.tool_formula.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.tool_formula.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tool_formula.TextMargin = 2;
            this.tool_formula.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tool_formula.TitleForeColor = System.Drawing.Color.Black;
            this.tool_formula.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.tool_formula.ToolTipTitle = null;
            // 
            // MessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 222);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageWindow";
            this.Load += new System.EventHandler(this.MessageWindow_Load);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lbl_comentario;
        private Bunifu.UI.WinForms.BunifuLabel lbl_nombre;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_aceptar;
        private Bunifu.UI.WinForms.BunifuToolTip tool_formula;
    }
}