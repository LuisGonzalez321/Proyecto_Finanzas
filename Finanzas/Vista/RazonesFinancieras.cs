using Finanzas.Controlador;
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
            this.Dispose();
        }

        private void btn_is_Click (object sender, EventArgs e)
        {

            double valor = CRazónCuenta.Razon_cuenta("Indice_solvencia", bunifuDatePicker1.Value);
            string texto = "Por cada córdoba o dólar de deuda a corto plazo se cuenta <br> "+
                            "con " + valor + " de activo circulante para responder a esta obligación.";
            if (valor != 0)
            {
                string formula = "Fórmula <br>" + 
                                 "Activo Circ. / Pasivo Circ.";

                MessageWindow ms = new MessageWindow("Indice de solvencia", texto, formula);
                ms.Show();
            }
            else
            {
                MessageBox.Show("Verifique la fecha");
            }

        }

        private void btn_deuda_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Razón_deuda", bunifuDatePicker1.Value);
            string texto = "El " + valor + "% de los bienes de la empresa las debe a los acreedores.<br>" +
                            "Es decir del total de los activos de la empresa se debe el " + valor + "%";

            if (valor != 0)
            {
                string formula = "Fórmula <br>" +
                                 "Total Pasivo / Total Activo";
                new MessageWindow("Razón de deuda", texto, formula).Show();
            }
            else
            { 
            MessageBox.Show("Verifique la fecha");
            }
        }

        private void btn_cnt_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Capital_Trabajo", bunifuDatePicker1.Value);

            string texto = "El Capital neto de trabajo es de " + valor + ", esto quiere decir cuenta <br> " +
                            "con ese dinero una vez habiendo cancelado con todas las <br> " +
                            "obligaciones  a corto plazo.";
            if (valor != 0)
            {
                string formula = "Fórmula <br>" +
                                 "Activo Circ. - Pasivo Circ.";
                new MessageWindow("Capital Neto Trabajo", texto, formula).Show();
            }
            else
            {
                MessageBox.Show("Verifique la fecha");
            }
        }

        private void btn_pa_Click (object sender, EventArgs e)
        {

            double valor = CRazónCuenta.Razon_cuenta("Razon_ácida", bunifuDatePicker1.Value);
            string texto = "La razón para el año, significa que por cada córdoba de deuda <br> "+
                            "de la empresa esta en capacidad de responder con " + valor + " <br> " +
                            "centavos si esta decidiera no entregar sus inventarios.";
            if (valor != 0)
            {
                string formula = "Fórmula <br>" +
                                 "Costo de venta / Inventario";
                new MessageWindow("Razón de prueba ácida", texto, formula).Show();
            }
            else
                MessageBox.Show("Verifique la fecha");
        }

        private void btn_RotInt_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Rotacion_Interes", bunifuDatePicker1.Value);

            string texto = "" + valor;
            if (valor != 0)
            {
                string formula = "Fórmula <br>" +
                                 "UAII / cargos por interes";
                new MessageWindow("Rotación de interes a utilidad", texto, formula).Show();
            }
            else
                MessageBox.Show("Verifique la fecha");
        }

        private void btn_rotaciónInventario_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Rotación_Inventario", bunifuDatePicker1.Value);
            string texto = "La razón para el año, significa que por cada córdoba de deuda de la <br> " + 
                           "empresa esta en capacidad de responder con " + valor + " centavos <br>" +
                           "si esta decidiera no entregar sus inventarios.";
            if (valor != 0)
            { 
                string formula = "Fórmula <br>" +
                                 "(Activo Circ. - Inventario) / Pasivo Circ.";
                new MessageWindow("Rotación de inventario", texto, formula).Show();
            }
            else
                MessageBox.Show("Verifique la fecha");
        }

        private void btn_CuentasCobrar_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Rotación_Cuentas_por_cobrar", bunifuDatePicker1.Value);
            double veces = (12 / valor) * 100;
            string texto = "Significa que la compañía esta realizando la cobranza " + valor + " veces <br>" +
                            "por año osea que cobra " + veces + " por año.";
            if (valor != 0)
            {
                string formula = "Fórmula <br>" +
                                 "Ventas / Cuentas por cobrar";
                new MessageWindow("Rotación cuentas por cobrar ", texto, formula).Show();
            }
            else
                MessageBox.Show("Verifique la fecha");
        }

        private void btn_ActivoFijo_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Rotación_ActivoFijo", bunifuDatePicker1.Value);
            string texto = "EL índice indica que por cada córdoba invertido en activos fijos netos <br>"+
                           "proporciona "+valor+" en ventas.";
            if (valor != 0)
            {
                string formula = "Fórmula <br>" +
                                 "Ventas / Activo fijo";
                new MessageWindow("Razón activo fijo", texto, formula).Show();
            }
            else
                MessageBox.Show("Verifique la fecha");
        }

        private void btn_ActivoTotal_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Rotación_ActivoTotal", bunifuDatePicker1.Value);
            string texto = "Al dividir las ventas entre la inversión concentrada en los activos <br> " + 
                           "totales se determina que cada córdoba invertido en activos es <br> " + 
                           "capaz de generar "+valor+ " centavos de ingresos por ventas";
            if (valor != 0)
            {
                string formula = "Fórmula <br>" +
                                 "Ventas / activo total";
                new MessageWindow("Razón activo total", texto, formula).Show();
            }
            else
                MessageBox.Show("Verifique la fecha");
        }

        private void btn_UtilidadBruta_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("MUB", bunifuDatePicker1.Value);

            string texto = "Indica que por cada dólar de venta se obtiene un MUB de " + valor + " <br> centavos de dolar ";
            if (valor != 0)
            {
                string formula = "Fórmula <br>" +
                                 "Utilidad Bruta / Ventas";
                new MessageWindow("Margen de utilidad bruta", texto, formula).Show();
            }
            else
                MessageBox.Show("Verifique la fecha");
        }

        private void btn_UtilidadOper_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("MUO", bunifuDatePicker1.Value);

            string texto = "La utilidad de operación representa el " + valor + " de las ventas; es decir <br> "
                            + valor  + " centavos por cada dólar en venta.";

            if (valor != 0)
            {
                string formula = "Fórmula <br>" +
                                 "Utilidad Operativa / ventas";
                new MessageWindow("Margen de utilidad operativa", texto, formula).Show();
            }
            else
                MessageBox.Show("Verifique la fecha");
        }

        private void btn_UtilidadNeta_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("MUN", bunifuDatePicker1.Value);

            string texto = "El margen de utilidad neta es de " + valor + " centavos por cada dólar <br> en venta.";


            if (valor != 0)
            {
                string formula = "Fórmula <br>" +
                                 "Utilidad Neta / Ventas";
                new MessageWindow("Margen de utilidad neta", texto, formula).Show();
            }
            else
                MessageBox.Show("Verifique la fecha");
        }

        private void btn_PeriCobro_Click (object sender, EventArgs e)
        {
            double valor = 0;
            string texto  = null;

            if (valor != 0)
            {
                string formula = "Fórmula <br>" +
                                 "Costo de ventas / Proveedores";
                new MessageWindow("Capital Neto Trabajo", texto, formula).Show();
            }
            else
                MessageBox.Show("Verifique la fecha");
        }

        private void btn_PasivoCap_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Razon_PasivoCapital", bunifuDatePicker1.Value);
            string texto = "El índice explica que el " + (valor * 100) + " % de nuestro capital social representa <br>" +
                           "el pasivo a largo plazo.";
            if (valor != 0)
            {
                string formula = "Fórmula <br>" +
                                 "Pasivo a LP / Capital Social";
                new MessageWindow("Razón pasivo/capital", texto, formula).Show();
            }
            else
                MessageBox.Show("Verifique la fecha");
        }

        private void btn_minimizar_Click (object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_análisis_años_Click (object sender, EventArgs e)
        {
            Razones_años razones_años = new Razones_años();
            razones_años.Show();
            this.Dispose();
        }
    }
}
