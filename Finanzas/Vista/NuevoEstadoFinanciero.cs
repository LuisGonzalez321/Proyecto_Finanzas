using Bunifu.UI.WinForms;
using Finanzas.Controlador;
using System;
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
                this.Hide();
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
                this.Hide();
            }
        }

        private void btn_cancelar_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Hide();
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

        public void metodo_cochino () {
            double ventas = double.Parse(tabla_er.Rows [0].Cells [0].Value.ToString()),
                   dev_venta = double.Parse(tabla_er.Rows [1].Cells [0].Value.ToString()),
                   des_venta = double.Parse(tabla_er.Rows [2].Cells [0].Value.ToString()),
                   ventas_netasC = double.Parse(tabla_er.Rows [3].Cells [0].Value.ToString()),
                   otros_ingresos = double.Parse(tabla_er.Rows [4].Cells [0].Value.ToString()),

            costo_venta = double.Parse(tabla_er.Rows [5].Cells [0].Value.ToString()),
            sueldo_gerente = double.Parse(tabla_er.Rows [6].Cells [0].Value.ToString()),
            publicidad = double.Parse(tabla_er.Rows [7].Cells [0].Value.ToString()),
            consumo_luz = double.Parse(tabla_er.Rows [8].Cells [0].Value.ToString()),
            sueldo_empleado = double.Parse(tabla_er.Rows [9].Cells [0].Value.ToString()),
            papeleria = double.Parse(tabla_er.Rows [10].Cells [0].Value.ToString()),
            impuesto = double.Parse(tabla_er.Rows [11].Cells [0].Value.ToString()),
            intereses = papeleria = double.Parse(tabla_er.Rows [12].Cells [0].Value.ToString()),
            producto_financiero = double.Parse(tabla_er.Rows [13].Cells [0].Value.ToString()),
            Operacion = double.Parse(tabla_er.Rows [14].Cells [0].Value.ToString()),
            perdida_acti = double.Parse(tabla_er.Rows [15].Cells [0].Value.ToString()),
            rentas_pagadas = double.Parse(tabla_er.Rows [16].Cells [0].Value.ToString()),
            dividendos = double.Parse(tabla_er.Rows [17].Cells [0].Value.ToString()),
            gastos_dep = double.Parse(tabla_er.Rows [18].Cells [0].Value.ToString()),
            gastos_dep2 = double.Parse(tabla_er.Rows [19].Cells [0].Value.ToString()),
            amortiz = double.Parse(tabla_er.Rows [20].Cells [0].Value.ToString()),
            impuestoSR = double.Parse(tabla_er.Rows [21].Cells [0].Value.ToString()),

            UB = ventas - dev_venta - des_venta - ventas_netasC + otros_ingresos - costo_venta,
            UO = UB - Operacion,
            UDI = UO - impuesto - intereses - producto_financiero - perdida_acti - gastos_dep - gastos_dep2 - dividendos - rentas_pagadas - amortiz,
            UN = UDI - impuestoSR;

            lbl_utilidadB.Text = "Utilidad Bruta: " + UB;
            lbl_opera.Text = "Utilidad Operativa : " + UO;
            lbl_UDI.Text = "Utilidad despues de IR : " +UDI;
            lbl_utilidad.Text = "Utilidad Neta :" + UN;
        }

        private void btn_calcular_Click (object sender, EventArgs e)
        {
            if (Toolkit.ValidarCampos(tabla_er))
            {
                metodo_cochino();
            }
            else
            {
                MessageBox.Show("Verifique los campos");
            }
        }

        private void btn_minimizar_Click (object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
