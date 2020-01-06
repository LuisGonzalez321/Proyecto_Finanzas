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
    public partial class EstadosFinancieros: Form
    {
        public EstadosFinancieros ()
        {
            InitializeComponent();
        }

        public void Cargar_datos ()
        {
            int año = datepicker_BG.Value.Year;
            tabla_activo.DataSource = Controlador.CConsulta.Consulta(año, "ACTIVO");
            tabla_pasivo.DataSource = Controlador.CConsulta.Consulta(año, "PASIVO");
            tabla_capital.DataSource = Controlador.CConsulta.Consulta(año, "CAPITAL");
            label_activo.Text = "BALANCE GENERAL :" + Convert.ToInt32(CRazónCuenta.Razon_cuenta("Total_Activo", datepicker_BG.Value));
        }
        

        private void EstadosFinancieros_Load (object sender, EventArgs e)
        {
            Cargar_datos();
        }

        private void btn_salir_Click (object sender, EventArgs e)
        {
            this.Hide();
        }

        private void datepicker_BG_ValueChanged (object sender, EventArgs e)
        {
            Cargar_datos();
        }

        private void btn_nuevo_Click (object sender, EventArgs e)
        {

        }
    }
}
