using Finanzas.Controlador;
using Finanzas.Controlador.Herramientas;
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
    public partial class Apalancamiento: Form
    {
        int contador = 0, contador2 = 0;
        private double UO = 0;

        public Apalancamiento ()
        {
            InitializeComponent();
            this.group_operativo.Size = new System.Drawing.Size(445, 78);
            this.group_financiero.Size = new System.Drawing.Size(445, 78);
            validar_text();
        }

        public void validar_text ()
        {
            txt_costos.KeyPress += Controlador.Herramientas.Toolkit.ValidarNumeros_KeyPress;
            txt_CostosF.KeyPress += Controlador.Herramientas.Toolkit.ValidarNumeros_KeyPress;
            txt_dividendos.KeyPress += Controlador.Herramientas.Toolkit.ValidarNumeros_KeyPress;
            txt_GastosOp.KeyPress += Controlador.Herramientas.Toolkit.ValidarNumeros_KeyPress;
            txt_impuesto.KeyPress += Controlador.Herramientas.Toolkit.ValidarNumeros_KeyPress;
            txt_interes.KeyPress += Controlador.Herramientas.Toolkit.ValidarNumeros_KeyPress;
            txt_ventas.KeyPress += Controlador.Herramientas.Toolkit.ValidarNumeros_KeyPress;
        }

        private void btn_VistaOperativa_Click (object sender, EventArgs e)
        {
            if (contador == 0)
            {
                this.group_operativo.Size = new System.Drawing.Size(445, 422);
                contador = 1;
            }
            else
            {
                this.group_operativo.Size = new System.Drawing.Size(445, 78);
                contador = 0;
            }
        }

        private void btn_salir_Click (object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_minimizar_Click (object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_calcular_Click (object sender, EventArgs e)
        {
            if (Toolkit.validar_camposTextbox(txt_costos.Text) && Toolkit.validar_camposTextbox(txt_CostosF.Text) && Toolkit.validar_camposTextbox(txt_GastosOp.Text) && Toolkit.validar_camposTextbox(txt_ventas.Text) &&  txt_cantidad.Value > 0)
            {
                double ventas = double.Parse(txt_ventas.Text);
                double costos = double.Parse(txt_costos.Text);

                double costos_fijos = double.Parse(txt_CostosF.Text);

                UInt32 cantidad = UInt32.Parse(txt_cantidad.Value.ToString());

                double gastos = double.Parse(txt_GastosOp.Text);

                double margen = (ventas - costos) * cantidad - costos_fijos;

                this.UO = margen - gastos;

                lbl_GAO.Text = "Grado de apalancamiento operativo :   " + (margen / UO);
            }
            else
            {
                MessageBox.Show("Verifique bien los campos!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_calcularGAF_Click (object sender, EventArgs e)
        {
            if (Toolkit.validar_camposTextbox(txt_interes.Text) && Toolkit.validar_camposTextbox(txt_impuesto.Text) && Toolkit.validar_camposTextbox(txt_dividendos.Text) && UO !=0)
            {
                double UAI = UO - double.Parse(txt_interes.Text);

                lbl_UAI.Text = "Utilidad antes de impuestos(UAI): " + UAI;

                double UAII = UAI - double.Parse(txt_impuesto.Text);

                lbl_UAII.Text = "Utilidad antes de impuestos e interes(UAII): " + UAII;

                double dividendos = UAII - double.Parse(txt_dividendos.Text);

                lbl_UPA.Text = "Utilidad por acción(UPA) :" + dividendos;

                lbl_GAF.Text = "Grado de apalancamiento financiero :" + (UAII / UAI);     

            }
            else
            {
                MessageBox.Show("Verifique bien los campos!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuLabel11_MouseEnter (object sender, EventArgs e)
        {
            string informe = "";
        }

        private void btn_financiero_Click (object sender, EventArgs e)
        {
            if (contador2 == 0)
            {
                this.group_financiero.Size = new System.Drawing.Size(446, 424);
                contador2 = 1;
            }
            else
            {
                this.group_financiero.Size = new System.Drawing.Size(445, 72);
                contador2 = 0;
            }
        }
    }
}
