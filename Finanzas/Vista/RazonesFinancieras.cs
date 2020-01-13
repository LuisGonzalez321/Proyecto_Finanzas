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

        private void RazonesFinancieras_Load (object sender, EventArgs e)
        {

        }


        private void btn_salir_Click (object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_is_Click (object sender, EventArgs e)
        {
            try
            {
                double valor = CRazónCuenta.Razon_cuenta("Indice_solvencia", bunifuDatePicker1.Value);
                string texto = "Por cada córdoba o dólar de deuda a corto plazo se cuenta <br> "+
                                "con " + valor + " de activo circulante para responder a esta obligación.";
                MessageWindow ms = new MessageWindow("Indice de solvencia",texto);
                ms.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Revise la exixtencia en la fecha!!","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btn_deuda_Click (object sender, EventArgs e)
        {
            try
            {
                double valor = CRazónCuenta.Razon_cuenta("Razón_deuda", bunifuDatePicker1.Value);
                string texto = "El " + valor + "% de los bienes de la empresa las debe a los acreedores.<br>"+
                               "Es decir del total de los activos de la empresa se debe el " + valor +"%";
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
                string texto = "El Capital neto de trabajo es de " + valor + ", esto quiere decir cuenta <br> "+
                                "con ese dinero una vez habiendo cancelado con todas las obligaciones <br> a corto plazo.";
                new MessageWindow("Capital Neto Trabajo", texto).Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Revise la exixtencia en la fecha!!","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }   
        }

        private void btn_pa_Click (object sender, EventArgs e)
        {
            try
            {
                double valor = CRazónCuenta.Razon_cuenta("Razon_ácida", bunifuDatePicker1.Value);
                string texto = "La razón para el año,significa que por cada córdobao de deuda de la empresa <br> "+
                               " esta en capacidad de responder con " + valor + " centavos,si esta decidiera <br> no entregar sus inventarios.";
                new MessageWindow("Razón de pruba ácida", texto).Show();
            }
            catch(Exception)
            {

            }
        }

        private void btn_RotInt_Click (object sender, EventArgs e)
        {
            
        }

        private void btn_rotaciónInventario_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Rotación_Inventario", bunifuDatePicker1.Value);
            string texto = "La razón para el año, significa que por cada córdobao de deuda de la empresa esta en capacidad de responder <br> "+
                           "con " + valor + " centavos,si esta decidiera no entregar sus inventarios.";
            new MessageWindow("Rotación de inventario", texto).Show();
        }

        private void btn_CuentasCobrar_Click (object sender, EventArgs e)
        {
            //Rotación_Cuentas_por_cobrar
            double valor = CRazónCuenta.Razon_cuenta("Rotación_Cuentas_por_cobrar", bunifuDatePicker1.Value);
            string texto = "";
            new MessageWindow("Rotación cuentas por cobrar ", texto).Show();
        }

        private void btn_ActivoFijo_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Rotación_ActivoFijo", bunifuDatePicker1.Value);
            string texto = "EL índice indica que por cada córdoba invertido en activos fijos netos, proporciona "+valor+" en ventas.";
            new MessageWindow("Razón activo fijo", texto).Show();
        }

        private void btn_ActivoTotal_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Rotación_ActivoTotal", bunifuDatePicker1.Value);
            string texto = "Al dividir las ventas entre la inversión concentrada en los activos totales se determina <br>"+
                           "que cada córdoba invertido en activos, es capaz de generar "+valor+ "centavos de ingresos por ventas";
            new MessageWindow("Razón activo total", texto).Show();
        }

        private void btn_UtilidadBruta_Click (object sender, EventArgs e)
        {

        }

        private void btn_UtilidadOper_Click (object sender, EventArgs e)
        {

        }

        private void btn_UtilidadNeta_Click (object sender, EventArgs e)
        {

        }

        private void btn_PeriCobro_Click (object sender, EventArgs e)
        {

        }

        private void btn_PasivoCap_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Razon_PasivoCapital", bunifuDatePicker1.Value);
            string texto = "El índice explica que el " + (valor * 100) + " % de nuestro capital social representa <br>" +
                           "el pasivo a largo plazo.";
            new MessageWindow("Razón pasivo/capital", texto).Show();
        }
    }
}
