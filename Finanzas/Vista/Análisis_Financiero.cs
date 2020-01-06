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
                int index = lista_años.SelectedIndex;
                lista_años.Items.Remove(lista_años.SelectedItem);
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
        }
    }
}
