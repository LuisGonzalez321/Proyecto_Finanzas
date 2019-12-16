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
        
        public bool ValidarCampos (BunifuDataGridView datagrid)
        {
            foreach (DataGridTextBox i in datagrid.Rows)
            {
                if (i.Text == null)
                {
                    return false;
                }
            }
            return true;
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
