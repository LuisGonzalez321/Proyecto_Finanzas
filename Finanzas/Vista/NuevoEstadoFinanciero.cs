using Bunifu.UI.WinForms;
using Finanzas.Controlador;
using Finazas.Vista;
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
    public partial class NuevoEstadoFinanciero: Form
    {
        public NuevoEstadoFinanciero ()
        {
            InitializeComponent();
            tabla_activo.DataSource = CConsulta.Catalogo_Cuentas("ACTIVO");

        }


        private const int cGrip = 16;
        private const int cCaption = 32;


        /*
         * Metodo para poder mover la ventana
         */
        protected override void WndProc (ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.bunifuGradientPanel1.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr) 2;
                    return;
                }
                if (pos.X >= this.bunifuGradientPanel1.ClientSize.Width - cGrip && pos.Y >= this.bunifuGradientPanel1.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr) 17;
                    return;
                }
            }
            base.WndProc(ref m);
        }


        public bool ValidarCampos (BunifuDataGridView datagrid)
        {
            return false;
        }

        private void btn_guardar_Click (object sender, EventArgs e)
        {
            MessageBox.Show("Exito al guardar!!","Exito!!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            if (ValidarCampos(tabla_activo))
            {
                MessageBox.Show("Texto Completo");
            }else
            {
                MessageBox.Show("Verifique los ");
            }
        }

        private void btn_cancelar_Click (object sender, EventArgs e)
        {
            MessageBox.Show("Desea Salir?", "Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void btn_salir_Click (object sender, EventArgs e)
        {
            MessageBox.Show("Desea Salir?", "Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void tabla_activo_KeyPress (object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void btn_ER_Click (object sender, EventArgs e)
        {
            page_EF.PageIndex = 1;
        }
    }
}
