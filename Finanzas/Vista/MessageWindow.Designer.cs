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
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lbl_comentario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_aceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_nombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.bunifuCards1.SuspendLayout();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.lbl_comentario);
            this.bunifuCards1.Controls.Add(this.btn_aceptar);
            this.bunifuCards1.Controls.Add(this.lbl_nombre);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(1);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(395, 183);
            this.bunifuCards1.TabIndex = 0;
            // 
            // lbl_comentario
            // 
            this.lbl_comentario.AutoSize = true;
            this.lbl_comentario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_comentario.Location = new System.Drawing.Point(24, 77);
            this.lbl_comentario.Name = "lbl_comentario";
            this.lbl_comentario.Size = new System.Drawing.Size(43, 13);
            this.lbl_comentario.TabIndex = 6;
            this.lbl_comentario.Text = "TEXTO";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Active = false;
            this.btn_aceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.BorderRadius = 7;
            this.btn_aceptar.ButtonText = "Aceptar";
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_aceptar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_aceptar.Iconimage = null;
            this.btn_aceptar.Iconimage_right = null;
            this.btn_aceptar.Iconimage_right_Selected = null;
            this.btn_aceptar.Iconimage_Selected = null;
            this.btn_aceptar.IconMarginLeft = 0;
            this.btn_aceptar.IconMarginRight = 0;
            this.btn_aceptar.IconRightVisible = true;
            this.btn_aceptar.IconRightZoom = 0D;
            this.btn_aceptar.IconVisible = true;
            this.btn_aceptar.IconZoom = 90D;
            this.btn_aceptar.IsTab = false;
            this.btn_aceptar.Location = new System.Drawing.Point(263, 138);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_aceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_aceptar.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_aceptar.selected = false;
            this.btn_aceptar.Size = new System.Drawing.Size(104, 31);
            this.btn_aceptar.TabIndex = 8;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_aceptar.Textcolor = System.Drawing.Color.DodgerBlue;
            this.btn_aceptar.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_nombre.Location = new System.Drawing.Point(115, 19);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(172, 25);
            this.lbl_nombre.TabIndex = 7;
            this.lbl_nombre.Text = "Indice de solvencia";
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuShadowPanel1.Controls.Add(this.bunifuCards1);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Black;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(395, 183);
            this.bunifuShadowPanel1.TabIndex = 1;
            // 
            // MessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(395, 183);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageWindow";
            this.Load += new System.EventHandler(this.MessageWindow_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_aceptar;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_nombre;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_comentario;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
    }
}