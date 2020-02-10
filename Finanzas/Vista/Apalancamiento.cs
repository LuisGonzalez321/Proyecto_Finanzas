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
        int contador = 0, contador2 = 0, contador3 = 0;
        private double UO = 0;
        UInt32 cantidad = 0;
        double GAO = 0;

        public Apalancamiento ()
        {
            InitializeComponent();
            this.group_operativo.Size = new System.Drawing.Size(445, 78);
            this.group_financiero.Size = new System.Drawing.Size(445, 78);
            this.group_reporte.Size = new System.Drawing.Size(445, 78);
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

                cantidad = UInt32.Parse(txt_cantidad.Value.ToString());

                double gastos = double.Parse(txt_GastosOp.Text);

                double margen = (ventas - costos) * cantidad - costos_fijos;

                this.UO = margen - gastos;

                this.GAO = (margen / UO);

                lbl_GAO.Text = "Grado de apalancamiento operativo :   " + GAO;

                lbl_report.Text = "Por cada punto de incremento en el margen de contribución a partir <br> "+
                                  "de " + cantidad + "de producción, utilidad operacional antes de intereses e <br> "+
                                  "impuestos(UAII) se incrementara en " + GAO;
            }
            else
            {
                MessageBox.Show("Verifique bien los campos!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_calcularGAF_Click (object sender, EventArgs e)
        {
            if (Toolkit.validar_camposTextbox(txt_interes.Text) && Toolkit.validar_camposTextbox(txt_impuesto.Text) && Toolkit.validar_camposTextbox(txt_dividendos.Text) && UO != 0)
            {
                double UAI = UO - double.Parse(txt_interes.Text);

                lbl_UAI.Text = "Utilidad antes de impuestos(UAI): " + UAI;

                double UAII = UAI - double.Parse(txt_impuesto.Text);

                lbl_UAII.Text = "Utilidad antes de impuestos e interes(UAII): " + UAII;

                double dividendos = UAII - double.Parse(txt_dividendos.Text);

                lbl_UPA.Text = "Utilidad por acción(UPA) :" + dividendos;

                double GAF = (UAII / UAI);

                lbl_GAF.Text = "Grado de apalancamiento financiero :" + GAF;

                lbl_report2.Text = "Por cada punto de incremento en la utilidad operativa antes de intereses e impuestos (uAII) <br> " +
                                   "a partir de " + cantidad + " de producción, la utilidad antes de impuestos se incrementará " +
                                   "en " + GAF +" puntos.";


                double GAT = GAO * GAF;

                lbl_report3.Text = "Por cada punto de incremento en la utilidad operativa antes de intereses e impuestos (UAII) en la <br> " +
                                   "utilidad operativa antes de impuestos e intereses (UAII) a partir de " + cantidad + " unidades de <br> "+
                                   "producción la utilidad por acción UPA sera " + GAT;
            }
            else
            {
                MessageBox.Show("Verifique bien los campos!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_info1_MouseEnter (object sender, EventArgs e)
        {
            string informe = "Fórmula <br>" +
                             "GAO = Margen de contrubución / UAII";
                            
            tool_operativo.SetToolTip(lbl_info1, informe);
        }

        private void lbl_info2_MouseEnter (object sender, EventArgs e)
        {
            string informe = "Fórmula <br>" +
                             "GAF = UAII / UAI";

            tool_operativo.SetToolTip(lbl_info2, informe);
        }

        private void lbl_info3_MouseEnter (object sender, EventArgs e)
        {
            string informe = "Fórmula <br>" +
                             "GAF = GAO * GAF";

            tool_operativo.SetToolTip(lbl_info3, informe);
        }

        private void btn_reporte_Click (object sender, EventArgs e)
        {
            if (contador3 == 0)
            {
                //933; 643
                this.group_reporte.Size = new System.Drawing.Size(445, 643);
                contador3 = 1;
            }
            else
            {
                this.group_reporte.Size = new System.Drawing.Size(445, 78);
                contador3 = 0;
            }
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
