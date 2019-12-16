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
        }

        private void btn_guardar_Click (object sender, EventArgs e)
        {
            MessageBox.Show("Exito al guardar!!","Exito!!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
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
    }
}
