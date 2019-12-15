using Finazas.Controlador;
using Finazas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finazas
{
    public partial class Login: Form
    {
        public Login ()
        {
            InitializeComponent();
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc (ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.panel1.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr) 2;
                    return;
                }
                if (pos.X >= this.panel1.ClientSize.Width - cGrip && pos.Y >= this.panel1.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr) 17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void Login_Load (object sender, EventArgs e)
        {

        }

        private void btn_salir_Click (object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_ingresar_Click (object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string contraseña = txt_contraseña.Text;
            string rol = combox_rol.selectedValue.ToString();
            bool flag = CUsuario.MostrarUsuario(usuario, contraseña, rol) > 0;
            if (flag)
            {
                Vista.MenuPrincipal menu = new Vista.MenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
          
        }
    }
}
