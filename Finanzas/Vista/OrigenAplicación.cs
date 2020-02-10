﻿using Finanzas.Controlador;
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
    public partial class OA: Form
    {
        public OA ()
        {
            InitializeComponent();
            lista_añosOA.DisplayMember = "fecha";
            toolTip1.SetToolTip(lb_AV,"Fórmula= Monto cada Cuenta/Total Activo");
            ToolTip toolTip2 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(lb_AH, "Valor Absoluto / Monto de la Cuenta del Año Base");  

            // lista_años.da = CConsulta.Consultas_query();
            foreach (string i in CConsulta.Consultas_query())
            {
                lista_añosOA.Items.Add(i);
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
            if (lista_añosOA.SelectedIndex > -1 && lista_añosSelectOA.Items.Count < 2)
            {
                string año = lista_añosOA.Text;
                lista_añosSelectOA.Items.Add(año);
                int años = int.Parse(año);
                lista_añosOA.Items.Remove(lista_añosOA.SelectedItem);
                DataTable dtemp = new DataTable();
                dtemp.Merge(Controlador.CConsulta.ConsultaAV(años, "ACTIVO"));
                dtemp.Merge(Controlador.CConsulta.ConsultaAV(años, "PASIVO"));
                dtemp.Merge(Controlador.CConsulta.ConsultaAV(años, "CAPITAL"));
                tabla_av.DataSource = dtemp;
                if (lista_añosSelectOA.Items.Count == 1)
                {
                    lb_añoAV.Text = "" + lista_añosSelectOA.Items[0];
                }
                if (lista_añosSelectOA.Items.Count == 2)
                {
                    lb_añoAV.Text = "" + lista_añosSelectOA.Items[1];
                }               
            }
            if (lista_añosSelectOA.Items.Count==2)
            {
                int añoA = Convert.ToInt32(lista_añosSelectOA.Items[0]);
                int añoB = Convert.ToInt32(lista_añosSelectOA.Items[1]);
                lb_añoA.Text = "" + lista_añosSelectOA.Items[0];
                lb_añoB.Text = "" + lista_añosSelectOA.Items[1];
                lista_añosOA.Items.Remove(lista_añosOA.SelectedItem);
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
                    //MessageBox.Show("" + tabla_ah.Rows[i].Cells[0].Value.ToString());
                    if (double.Parse(tabla_ah.Rows[i].Cells[4].Value.ToString()) > 0
                        && int.Parse(tabla_ah.Rows[i].Cells[0].Value.ToString()) < int.Parse(tabla_ah.Rows[16].Cells[0].Value.ToString()))
                        tabla_ah.Rows[i].Cells[6].Value = "Aplicación";
                    else
                        tabla_ah.Rows[i].Cells[6].Value = "Origen";
                    if (double.Parse(tabla_ah.Rows[i].Cells[4].Value.ToString()) > 0 && int.Parse(tabla_ah.Rows[i].Cells[0].Value.ToString()) >= int.Parse(tabla_ah.Rows[16].Cells[0].Value.ToString()))
                        tabla_ah.Rows[i].Cells[6].Value = "Origen";
                    else
                        tabla_ah.Rows[i].Cells[6].Value = "Aplicación";
                }
            }
        }

        private void btn_izquierda_Click (object sender, EventArgs e)
        {
            if (lista_añosSelectOA.SelectedIndex > -1)
            {
                string año = lista_añosSelectOA.Text;
                lista_añosOA.Items.Add(año);
                int index = lista_añosSelectOA.SelectedIndex;
                lista_añosSelectOA.Items.Remove(lista_añosSelectOA.SelectedItem);
            }
            if (lista_añosSelectOA.Items.Count == 0)
            {
                tabla_av.DataSource = null;
            }
            if (lista_añosSelectOA.Items.Count == 1)
            {
                tabla_ah.Columns.RemoveAt(6);
                tabla_ah.DataSource = null;
            }
        }

        private void Análisis_Financiero_Load(object sender, EventArgs e)
        {

        }
    }
}
