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
            tabla_pasivo.DataSource = CConsulta.Catalogo_Cuentas("PASIVO");
            tabla_capital.DataSource = CConsulta.Catalogo_Cuentas("CAPITAL");
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

        public void Guardar_activos (BunifuDataGridView datagrid)
        {
            double monto;
            for (int i = 0 ;i < datagrid.RowCount - 1 ;i++)
            {
                monto = double.Parse(datagrid.Rows [i].Cells [0].Value.ToString());
                CCuenta.Insertart_monto(i + 1, monto, datepicker_BG.Value, "D");
            }
        }

        public bool ValidarCampos (BunifuDataGridView datagrid)
        {
            for (int i = 0 ;i < datagrid.RowCount - 1 ;i++)
            {
                if (datagrid.Rows [i].Cells [0].Value == null)
                {
                    //return false;
                    MessageBox.Show("Her null");
                }
                else if(datagrid.Rows [i].Cells [0].Value.ToString() == "0.00")
                {
                    MessageBox.Show("Her");
                }
            }
            return true;
        }

        private void btn_guardar_Click (object sender, EventArgs e)
        {
            if (ValidarCampos(tabla_activo))
            {
                //Guardar_activos(tabla_activo);
                MessageBox.Show("Texto Completo");
            } else
            {
                MessageBox.Show("Verifique los campos");
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

        private void tabla_activo_CellValueChanged (object sender, DataGridViewCellEventArgs e)
        {
            double monto = suma_monto_datagrid(tabla_activo);
            label_activo.Text = "TOTAL ACTIVO :" + monto;
        }

        public double suma_monto_datagrid (BunifuDataGridView datagrid)
        {
            double monto = 0;
            for (int i = 0 ;i < datagrid.RowCount - 1 ;i++)
            {
                if (datagrid.Rows [i].Cells [0].Value != null)
                {
                    monto += double.Parse(datagrid.Rows [i].Cells [0].Value.ToString());
                }
            }
            return monto;
        }

        private void tabla_capital_CellValueChanged (object sender, DataGridViewCellEventArgs e)
        {
            double monto = suma_monto_datagrid(tabla_capital) + suma_monto_datagrid(tabla_pasivo);
            label_pc.Text = "TOTAL PASIVO Y CAPITAL: "+ monto;
        }

        private void tabla_pasivo_CellValueChanged (object sender, DataGridViewCellEventArgs e)
        {
            double monto = suma_monto_datagrid(tabla_capital) + suma_monto_datagrid(tabla_pasivo);
            label_pc.Text = "TOTAL PASIVO Y CAPITAL: " + monto;
        }
    }
}
