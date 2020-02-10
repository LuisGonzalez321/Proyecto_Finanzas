using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finanzas.Controlador;

namespace Finanzas.Vista
{
    public partial class OrigenAplicaci : Form
    {
        public OrigenAplicaci()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(lb_OA, "Valor Absoluto / Monto de la Cuenta del Año Base\n ACTIVO PASIVO CAPITAL\n      +          -           -          Aplicacion \n      +          -           -         Origen");

            // lista_años.da = CConsulta.Consultas_query();
            foreach (string i in CConsulta.Consultas_query())
            {
                lista_años.Items.Add(i);
            }
        }

        private void btn_derecha_Click(object sender, EventArgs e)
        {
            if (lista_años.SelectedIndex > -1)
            {
                string año = lista_años.Text;
                lista_añosSelect.Items.Add(año);
                lista_años.Items.Remove(lista_años.SelectedItem);             
            }
            if (lista_añosSelect.Items.Count == 2)
            {
                int añoA = Convert.ToInt32(lista_añosSelect.Items[0]);
                int añoB = Convert.ToInt32(lista_añosSelect.Items[1]);
                lb_añoA.Text = "" + lista_añosSelect.Items[0];
                lb_añoB.Text = "" + lista_añosSelect.Items[1];
                lista_años.Items.Remove(lista_años.SelectedItem);
                DataTable dtemp2 = new DataTable();

                dtemp2.Merge(Controlador.CConsulta.ConsultaAH(añoA, añoB, "ACTIVO"));
                dtemp2.Merge(Controlador.CConsulta.ConsultaAH(añoA, añoB, "PASIVO"));
                dtemp2.Merge(Controlador.CConsulta.ConsultaAH(añoA, añoB, "CAPITAL"));
                tabla_oa.DataSource = dtemp2;
                DataGridViewColumn col = new DataGridViewColumn();
                col.Name = "Clasificación";
                col.HeaderText = "Clasicación";
                col.CellTemplate = new DataGridViewTextBoxCell();
                tabla_oa.Columns.Add(col);

                for (int i = 0; i < tabla_oa.Rows.Count; i++)
                {
                    //MessageBox.Show("" + tabla_ah.Rows[i].Cells[0].Value.ToString());
                    if (double.Parse(tabla_oa.Rows[i].Cells[4].Value.ToString()) > 0
                        && int.Parse(tabla_oa.Rows[i].Cells[0].Value.ToString()) < int.Parse(tabla_oa.Rows[16].Cells[0].Value.ToString()))
                        tabla_oa.Rows[i].Cells[6].Value = "Aplicación";
                    else
                        tabla_oa.Rows[i].Cells[6].Value = "Origen";
                    if (double.Parse(tabla_oa.Rows[i].Cells[4].Value.ToString()) > 0 
                        && Convert.ToInt32(tabla_oa.Rows[i].Cells[0].Value.ToString()) >= Convert.ToInt32(tabla_oa.Rows[16].Cells[0].Value.ToString()))
                        tabla_oa.Rows[i].Cells[6].Value = "Origen";
                    else
                        tabla_oa.Rows[i].Cells[6].Value = "Aplicación";
                }
            }
        }

        private void btn_izquierda_Click(object sender, EventArgs e)
        {
            if (lista_añosSelect.SelectedIndex > -1)
            {
                string año = lista_añosSelect.Text;
                lista_años.Items.Add(año);
                int index = lista_añosSelect.SelectedIndex;
                lista_añosSelect.Items.Remove(lista_añosSelect.SelectedItem);
            }
            if (lista_añosSelect.Items.Count == 1)
            {
                tabla_oa.Columns.RemoveAt(6);
                tabla_oa.DataSource = null;
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
