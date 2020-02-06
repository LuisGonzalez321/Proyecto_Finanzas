using Finanzas.Controlador;
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
    public partial class Análisis_Financiero: Form
    {
        public Análisis_Financiero ()
        {
            InitializeComponent();
            lista_años.DisplayMember = "fecha";
            // lista_años.da = CConsulta.Consultas_query();
            foreach (string i in CConsulta.Consultas_query())
            {
                lista_años.Items.Add(i);
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

        private void btn_derecha_Click (object sender, EventArgs e)
        {
            if (lista_años.SelectedIndex > -1 && lista_añosSelect.Items.Count < 2)
            {
                string año = lista_años.Text;
                lista_añosSelect.Items.Add(año);
                int años = int.Parse(año);
                lista_años.Items.Remove(lista_años.SelectedItem);
                DataTable dtemp = new DataTable();
                dtemp.Merge(Controlador.CConsulta.ConsultaAV(años, "ACTIVO"));
                dtemp.Merge(Controlador.CConsulta.ConsultaAV(años, "PASIVO"));
                dtemp.Merge(Controlador.CConsulta.ConsultaAV(años, "CAPITAL"));
                tabla_av.DataSource = dtemp;
            }
            if (lista_añosSelect.Items.Count==2)
            {
                int añoA = Convert.ToInt32(lista_añosSelect.Items[0]);
                int añoB = Convert.ToInt32(lista_añosSelect.Items[1]);
                lista_años.Items.Remove(lista_años.SelectedItem);
                DataTable dtemp2 = new DataTable();
                
                dtemp2.Merge(Controlador.CConsulta.ConsultaAH(añoA, añoB, "ACTIVO"));
                dtemp2.Merge(Controlador.CConsulta.ConsultaAH(añoA, añoB, "PASIVO"));
                dtemp2.Merge(Controlador.CConsulta.ConsultaAH(añoA, añoB, "CAPITAL"));
                tabla_ah.DataSource = dtemp2;
                DataGridViewColumn col = new DataGridViewColumn();
                col.Name = "Clasificación";
                col.HeaderText = "Clasicación";
                col.CellTemplate = new DataGridViewTextBoxCell();
                tabla_ah.Columns.Add(col);
                
                for (int i = 0; i < tabla_ah.Rows.Count; i++)
                {
                    MessageBox.Show("" + tabla_ah.Rows[i].Cells[0].Value.ToString());
                    //if (double.Parse(tabla_ah.Rows[i].Cells[4].Value.ToString()) > 0)
                    //{
                    //    if(int.Parse(tabla_ah.Rows[i].Cells[0].Value.ToString()) < int.Parse(tabla_ah.Rows[16].Cells[0].Value.ToString()) )
                    //    {
                    //        tabla_ah.Rows[i].Cells[6].Value = "Aplicación";
                    //    }     
                    //    else
                    //    {
                    //        tabla_ah.Rows[i].Cells[6].Value = "Origen";
                    //    }
                        //if (double.Parse(tabla_ah.Rows[i].Cells[4].Value.ToString()) < double.Parse(tabla_ah.Rows[15].Cells[4].Value.ToString()) )
                        //{
                        //    tabla_ah.Rows[i].Cells[6].Value = "Aplicación";
                        //}
                        //else
                        //{
                        //    tabla_ah.Rows[i].Cells[6].Value = "Origen";
                        //}
                    //}
                }
            }

            
        }

        private void btn_izquierda_Click (object sender, EventArgs e)
        {
            if (lista_añosSelect.SelectedIndex > -1)
            {
                string año = lista_añosSelect.Text;
                lista_años.Items.Add(año);
                int index = lista_añosSelect.SelectedIndex;
                lista_añosSelect.Items.Remove(lista_añosSelect.SelectedItem);
            }
            if (lista_añosSelect.Items.Count == 0)
            {
                tabla_av.DataSource = null;
            }
        }

        private void Análisis_Financiero_Load(object sender, EventArgs e)
        {

        }
    }
}
