using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas.Vista
{
    public partial class MessageWindow: Form
    {
        public string nombre;
        public string comentario;


        public string Nombre { get; set; }

        public string Comentario { get; set; }

        public void MostrarBotones (bool flag)
        {
            if (flag)
            {
                btn_derecha.Visible = true;
                btn_izquierda.Visible = true;
            }
            else
            {
                btn_derecha.Visible = false;
                btn_izquierda.Visible = false;
            }
        }

        public MessageWindow (string nombre, string comentario)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.comentario = comentario;
            MostrarBotones(false);
        }

        private void MessageWindow_Load (object sender, EventArgs e)
        {
            lbl_nombre.Text = nombre;
            lbl_comentario.Text = comentario;
        }

        private void btn_aceptar_Click_1 (object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
