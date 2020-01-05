namespace Finazas
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_ingresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_contraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.combox_rol = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btn_salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Active = false;
            this.btn_ingresar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_ingresar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ingresar.BorderRadius = 7;
            this.btn_ingresar.ButtonText = "Ingresar";
            this.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ingresar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ingresar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ingresar.Iconimage = null;
            this.btn_ingresar.Iconimage_right = null;
            this.btn_ingresar.Iconimage_right_Selected = null;
            this.btn_ingresar.Iconimage_Selected = null;
            this.btn_ingresar.IconMarginLeft = 0;
            this.btn_ingresar.IconMarginRight = 0;
            this.btn_ingresar.IconRightVisible = true;
            this.btn_ingresar.IconRightZoom = 0D;
            this.btn_ingresar.IconVisible = true;
            this.btn_ingresar.IconZoom = 90D;
            this.btn_ingresar.IsTab = false;
            this.btn_ingresar.Location = new System.Drawing.Point(113, 390);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btn_ingresar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_ingresar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ingresar.selected = false;
            this.btn_ingresar.Size = new System.Drawing.Size(118, 45);
            this.btn_ingresar.TabIndex = 0;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ingresar.Textcolor = System.Drawing.Color.White;
            this.btn_ingresar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_contraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_contraseña.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_contraseña.HintForeColor = System.Drawing.Color.Empty;
            this.txt_contraseña.HintText = "Contraseña";
            this.txt_contraseña.isPassword = true;
            this.txt_contraseña.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_contraseña.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_contraseña.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_contraseña.LineThickness = 3;
            this.txt_contraseña.Location = new System.Drawing.Point(61, 263);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contraseña.MaxLength = 32767;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(232, 35);
            this.txt_contraseña.TabIndex = 3;
            this.txt_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.combox_rol.Location = new System.Drawing.Point(61, 330);
            this.combox_rol.Name = "combox_rol";
            this.combox_rol.NomalColor = System.Drawing.Color.DodgerBlue;
            this.combox_rol.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.combox_rol.selectedIndex = 0;
            this.combox_rol.Size = new System.Drawing.Size(232, 35);
            this.combox_rol.TabIndex = 5;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = false;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(128, 73);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(76, 76);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuPictureBox1.TabIndex = 7;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageActive = null;
            this.btn_salir.Location = new System.Drawing.Point(289, -1);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(38, 39);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_salir.TabIndex = 6;
            this.btn_salir.TabStop = false;
            this.btn_salir.Zoom = 10;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_usuario.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_usuario.HintForeColor = System.Drawing.Color.Empty;
            this.txt_usuario.HintText = "Usuario";
            this.txt_usuario.isPassword = false;
            this.txt_usuario.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_usuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_usuario.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txt_usuario.LineThickness = 3;
            this.txt_usuario.Location = new System.Drawing.Point(61, 193);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.MaxLength = 32767;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(232, 35);
            this.txt_usuario.TabIndex = 2;
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Controls.Add(this.bunifuPictureBox1);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 165);
            this.panel1.TabIndex = 8;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.ImageActive = null;
            this.btn_minimizar.Location = new System.Drawing.Point(245, -1);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(38, 39);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimizar.TabIndex = 8;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Zoom = 10;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // elipse
            // 
            this.elipse.ElipseRadius = 7;
            this.elipse.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 462);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.combox_rol);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_ingresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_ingresar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_usuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_contraseña;
        private Bunifu.Framework.UI.BunifuDropdown combox_rol;
        private Bunifu.Framework.UI.BunifuImageButton btn_salir;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimizar;
        private Bunifu.Framework.UI.BunifuElipse elipse;
    }
}

