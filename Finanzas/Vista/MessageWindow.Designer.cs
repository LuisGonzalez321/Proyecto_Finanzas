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
            this.btn_izquierda = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_derecha = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_izquierda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_derecha)).BeginInit();
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
            this.bunifuShadowPanel1.Controls.Add(this.btn_derecha);
            this.bunifuShadowPanel1.Controls.Add(this.btn_izquierda);
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
            // 
            // btn_izquierda
            // 
            this.btn_izquierda.Image = ((System.Drawing.Image)(resources.GetObject("btn_izquierda.Image")));
            this.btn_izquierda.ImageActive = null;
            this.btn_izquierda.Location = new System.Drawing.Point(27, 168);
            this.btn_izquierda.Name = "btn_izquierda";
            this.btn_izquierda.Size = new System.Drawing.Size(38, 42);
            this.btn_izquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_izquierda.TabIndex = 3;
            this.btn_izquierda.TabStop = false;
            this.btn_izquierda.Zoom = 10;
            // 
            // btn_derecha
            // 
            this.btn_derecha.Image = ((System.Drawing.Image)(resources.GetObject("btn_derecha.Image")));
            this.btn_derecha.ImageActive = null;
            this.btn_derecha.Location = new System.Drawing.Point(71, 168);
            this.btn_derecha.Name = "btn_derecha";
            this.btn_derecha.Size = new System.Drawing.Size(38, 42);
            this.btn_derecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_derecha.TabIndex = 4;
            this.btn_derecha.TabStop = false;
            this.btn_derecha.Zoom = 10;
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_izquierda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_derecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lbl_comentario;
        private Bunifu.UI.WinForms.BunifuLabel lbl_nombre;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_aceptar;
        private Bunifu.Framework.UI.BunifuImageButton btn_derecha;
        private Bunifu.Framework.UI.BunifuImageButton btn_izquierda;
    }
}