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
            //this.tabla_BG.ScrollBars = ScrollBars.None;
            //this.tabla_BG.ScrollBars = Scrollbar_A;//System.Windows.Forms.ScrollBars.None;
        }

        public void Cargar_datos ()
        {
            int año = datepicker_BG.Value.Year;
            tabla_activo.DataSource = Controlador.Consultas.Consulta(año, "ACTIVO");

            tabla_pasivo.DataSource  = Controlador.Consultas.Consulta(año, "PASIVO");
            tabla_capital.DataSource = Controlador.Consultas.Consulta(año, "CAPITAL");

          //  label_activo.Text += "" + suma(tabla_activo);

        }

        public float suma (DataGridView tabla)
        {
            float sumatoria = 0;
            foreach (DataRow i in tabla.Rows)
            {
                sumatoria += float.Parse( i.ItemArray[1].ToString() );
            }
            return sumatoria;
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
            NuevoEstadoFinanciero nuevo_estado = new NuevoEstadoFinanciero();
            nuevo_estado.Show();
            this.Hide();
        }
    }
}
