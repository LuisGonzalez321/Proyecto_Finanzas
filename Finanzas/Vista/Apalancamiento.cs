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
        private double UAII = 0;

        public Apalancamiento ()
        {
            InitializeComponent();
            this.group_operativo.Size = new System.Drawing.Size(445, 78);
            this.group_financiero.Size = new System.Drawing.Size(445, 78);
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

                this.UAII = margen - gastos;

                lbl_GAO.Text = "Grado de apalancamiento operativo :   " + (margen / UAII);
            }
            else
            {
                MessageBox.Show("Verifique bien los campos!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
