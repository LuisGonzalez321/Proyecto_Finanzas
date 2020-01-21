﻿using Finanzas.Controlador;
using System;
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
            double valor = CRazónCuenta.Razon_cuenta("Razón_deuda", bunifuDatePicker1.Value);
            string texto = "El " + valor + "% de los bienes de la empresa las debe a los acreedores.<br>"+
                            "Es decir del total de los activos de la empresa se debe el " + valor +"%";
            new MessageWindow("Razón de deuda", texto).Show();
        }

        private void btn_cnt_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Capital_Trabajo", bunifuDatePicker1.Value);

            string texto = "El Capital neto de trabajo es de " + valor + ", esto quiere decir cuenta <br> "+
                            "con ese dinero una vez habiendo cancelado con todas las <br> " + 
                            "obligaciones  a corto plazo.";

            new MessageWindow("Capital Neto Trabajo", texto).Show();
        }

        private void btn_pa_Click (object sender, EventArgs e)
        {

            double valor = CRazónCuenta.Razon_cuenta("Razon_ácida", bunifuDatePicker1.Value);
            string texto = "La razón para el año, significa que por cada córdoba de deuda <br> "+
                            "de la empresa esta en capacidad de responder con " + valor + " <br> " +
                            "centavos si esta decidiera no entregar sus inventarios.";

            new MessageWindow("Razón de prueba ácida", texto).Show();
        }

        private void btn_RotInt_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Rotacion_Interes", bunifuDatePicker1.Value);

            string texto = "" + valor;

            new MessageWindow("Rotación de interes a utilidad", texto).Show();
        }

        private void btn_rotaciónInventario_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Rotación_Inventario", bunifuDatePicker1.Value);
            string texto = "La razón para el año, significa que por cada córdoba de deuda de la <br> " + 
                           "empresa esta en capacidad de responder con " + valor + " centavos <br>" +
                           "si esta decidiera no entregar sus inventarios.";

            new MessageWindow("Rotación de inventario", texto).Show();
        }

        private void btn_CuentasCobrar_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Rotación_Cuentas_por_cobrar", bunifuDatePicker1.Value);
            double veces = (12 / valor) * 100;
            string texto = "Significa que la compañía esta realizando la cobranza " + valor + " veces <br>" +
                            "por año osea que cobra " + veces + " por año.";

            new MessageWindow("Rotación cuentas por cobrar ", texto).Show();
        }

        private void btn_ActivoFijo_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Rotación_ActivoFijo", bunifuDatePicker1.Value);
            string texto = "EL índice indica que por cada córdoba invertido en activos fijos netos <br>"+
                           "proporciona "+valor+" en ventas.";
            new MessageWindow("Razón activo fijo", texto).Show();
        }

        private void btn_ActivoTotal_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Rotación_ActivoTotal", bunifuDatePicker1.Value);
            string texto = "Al dividir las ventas entre la inversión concentrada en los activos <br> " + 
                           "totales se determina que cada córdoba invertido en activos es <br> " + 
                           "capaz de generar "+valor+ " centavos de ingresos por ventas";

            new MessageWindow("Razón activo total", texto).Show();
        }

        private void btn_UtilidadBruta_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("MUB", bunifuDatePicker1.Value);

            string texto = "Indica que por cada dólar de venta se obtiene un MUB de " + valor + " <br> centavos de dolar ";
            new MessageWindow("Margen de utilidad bruta", texto).Show();
        }

        private void btn_UtilidadOper_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("MUO", bunifuDatePicker1.Value);

            string texto = "La utilidad de operación representa el " + valor + " de las ventas; es decir <br> "
                            + valor  + " centavos por cada dólar en venta.";
            new MessageWindow("Margen de utilidad operativa", texto).Show();
        }

        private void btn_UtilidadNeta_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("MUN", bunifuDatePicker1.Value);

            string texto = "El margen de utilidad neta es de " + valor + " centavos por cada dólar <br> en venta.";

            new MessageWindow("Margen de utilidad neta", texto).Show();
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

        private void btn_minimizar_Click (object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
