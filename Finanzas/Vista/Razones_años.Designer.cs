namespace Finanzas.Vista
{
    partial class Razones_años
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Razones_años));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lista_añosSelect = new System.Windows.Forms.ListBox();
            this.lista_años = new System.Windows.Forms.ListBox();
            this.btn_izquierda = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_derecha = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_izquierda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_derecha)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lista_añosSelect);
            this.groupBox1.Controls.Add(this.btn_izquierda);
            this.groupBox1.Controls.Add(this.btn_derecha);
            this.groupBox1.Controls.Add(this.lista_años);
            this.groupBox1.Location = new System.Drawing.Point(39, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 182);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar años a comparar";
            // 
            // lista_añosSelect
            // 
            this.lista_añosSelect.FormattingEnabled = true;
            this.lista_añosSelect.Location = new System.Drawing.Point(115, 40);
            this.lista_añosSelect.Name = "lista_añosSelect";
            this.lista_añosSelect.Size = new System.Drawing.Size(70, 121);
            this.lista_añosSelect.TabIndex = 12;
            // 
            // lista_años
            // 
            this.lista_años.FormattingEnabled = true;
            this.lista_años.Location = new System.Drawing.Point(6, 40);
            this.lista_años.Name = "lista_años";
            this.lista_años.Size = new System.Drawing.Size(70, 121);
            this.lista_años.TabIndex = 9;
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
            // 
            // Razones_años
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 419);
            this.Controls.Add(this.groupBox1);
            this.Name = "Razones_años";
            this.Text = "Razones_años";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_izquierda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_derecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lista_añosSelect;
        private Bunifu.Framework.UI.BunifuImageButton btn_izquierda;
        private Bunifu.Framework.UI.BunifuImageButton btn_derecha;
        private System.Windows.Forms.ListBox lista_años;
    }
}