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
    public partial class RazonesFinancieras: Form
    {

        public RazonesFinancieras ()
        {
            InitializeComponent();
        }



        private void btn_salir_Click (object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_is_Click (object sender, EventArgs e)
        {
            try
            { 
                string texto = "Por cada córdoba o dólar de deuda a corto plazo se cuenta con " + CRazónCuenta.Razon_cuenta("Indice_solvencia",bunifuDatePicker1.Value) + "\nde activo circulante para responder a esta obligación.";
                MessageWindow ms = new MessageWindow("Indice de solvencia",texto);
                ms.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Revise la exixtencia en la fecha!!","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

}

        private void RazonesFinancieras_Load (object sender, EventArgs e)
        {

        }

        private void btn_deuda_Click (object sender, EventArgs e)
        {
            try
            { 
                string texto = "El " + CRazónCuenta.Razon_cuenta("Razón_deuda", bunifuDatePicker1.Value) + "% de los bienes que tiene la empresa las debe a los acreedores.\n"+
                           "Es decir del total de los activos de la empresa se debe el " + CRazónCuenta.Razon_cuenta("Razón_deuda", bunifuDatePicker1.Value) +"%";
                 new MessageWindow("Razón de deuda", texto).Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Revise la exixtencia en la fecha!!","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
}

        private void btn_cnt_Click (object sender, EventArgs e)
        {
            try
            {
                double valor = CRazónCuenta.Razon_cuenta("Capital_Trabajo", bunifuDatePicker1.Value);
                string texto = "El Capital neto de trabajo es de " + valor + ", esto quiere decir cuenta con ese \n dinero una vez habiendo cancelado" +
                               "con todas las obligaciones \n a corto plazo.";
                new MessageWindow("Capital Neto Trabajo", texto).Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Revise la exixtencia en la fecha!!","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }   
        }

    }
}
