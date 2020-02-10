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
using Finanzas.Controlador.Herramientas;

namespace Finanzas.Vista
{
    public partial class NuevoEstadoFinanciero: Form
    {

        double activo = 0 , pasivo_capital = 0;

        public NuevoEstadoFinanciero ()
        {
            InitializeComponent();
        }


        private void NuevoEstadoFinanciero_Load (object sender, EventArgs e)
        {
            tabla_activo.DataSource = CConsulta.Catalogo_Cuentas("ACTIVO");
            tabla_pasivo.DataSource = CConsulta.Catalogo_Cuentas("PASIVO");
            tabla_capital.DataSource = CConsulta.Catalogo_Cuentas("CAPITAL");
            tabla_er.DataSource = CCuenta.Mostrar_EstadoResultado();
            BunifuDataGridView [] da = { tabla_activo,tabla_pasivo,tabla_capital, tabla_er};
            Toolkit.Formato_tabla(da);
        }

        private void btn_salir_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void tabla_activo_CellValueChanged (object sender, DataGridViewCellEventArgs e)
        {           
            activo = suma_monto_datagrid(tabla_activo);
            label_activo.Text = "TOTAL ACTIVO :" + activo;   
        }     

        private void Suma_MontoTabla_CellValueChanged (object sender, DataGridViewCellEventArgs e)
        {
            pasivo_capital = suma_monto_datagrid(tabla_capital) + suma_monto_datagrid(tabla_pasivo);
            label_pc.Text = "TOTAL PASIVO Y CAPITAL :" + pasivo_capital;
        }

        private void btn_guardar_Click (object sender, EventArgs e)
        {
            if (Toolkit.ValidarCampos(tabla_activo) && Toolkit.ValidarCampos(tabla_pasivo) && Toolkit.ValidarCampos(tabla_capital) && Toolkit.ValidarCampos(tabla_er))
            {
                if (activo == pasivo_capital)
                {
                    CCuenta.Guardar_activos(tabla_activo, datepicker_BG);
                    CCuenta.Guardar_Pasivos(tabla_pasivo, datepicker_BG);
                    CCuenta.Guardar_Capital(tabla_capital, datepicker_BG);

                    double monto = 0;
                    for (int i = 0 ;i < tabla_er.RowCount ;i++)
                    {
                        monto = double.Parse(tabla_er.Rows [i].Cells [0].Value.ToString());
                        CCuenta.Insertart_monto(i + 29, monto, datepicker_BG.Value, "D");
                    }
                    MessageBox.Show("Registro Guardados exitosamente!!");
                }
            }
            else
            {
                MessageBox.Show("Verifique los campos");
            }
        }

        private void btn_bg_Click (object sender, EventArgs e)
        {
            page_EF.PageIndex = 0;
            lbl_texto.Text = "Balance General";
        }

        private void btn_cancelar2_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (this.IsDisposed != true)
                {
                    this.Dispose();
                }
                else
                    MessageBox.Show("control existente");
            }
        }

        private void btn_cancelar_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btn_er_Click (object sender, EventArgs e)
        {
            page_EF.PageIndex = 1;
            lbl_texto.Text = "Estado de resultados";
        }

        private void Tabla_EditingControlShowing (object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl) e.Control;

            dText.KeyPress -= new KeyPressEventHandler(Finanzas.Controlador.Herramientas.Toolkit.ValidarNumeros_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(Finanzas.Controlador.Herramientas.Toolkit.ValidarNumeros_KeyPress);
        }

        public double suma_monto_datagrid (BunifuDataGridView datagrid)
        {
            double monto = 0;
            for (int i = 0 ;i < datagrid.RowCount ;i++)
            {
                if (datagrid.Rows [i].Cells [0].Value != null )
                {
                    monto += double.Parse(datagrid.Rows [i].Cells [0].Value.ToString());
                }
            }
            return monto;
        }

        private void tabla_er_CellValueChanged (object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_minimizar_Click (object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
