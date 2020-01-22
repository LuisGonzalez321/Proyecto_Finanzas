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
    public partial class Razones_años: Form
    {

        int año1 = 0, año2 = 0;

        public Razones_años ()
        {
            InitializeComponent();
        }

        private void btn_salir_Click (object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_minimizar_Click (object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_salir_Click_1 (object sender, EventArgs e)
        {
            this.Hide();
        }


        private void btn_is_Click (object sender, EventArgs e)
        {
            double valor1 = CRazónCuenta.Razon_cuenta("Indice_solvencia", bunifuDatePicker1.Value);
            double valor2 = CRazónCuenta.Razon_cuenta("Indice_solvencia", bunifuDatePicker2.Value);

            string texto = "Por cada córdoba o dólar de deuda a corto plazo se cuenta <br> " +
                            "con " + valor1 + " de activo circulante para responder a esta obligación.<br>"+
                            Mensaje_razón(valor1, valor2) + " en el " + bunifuDatePicker2.Value.Year ;

            new MessageWindow("Indice de solvencia", texto).Show();
        }

        private void btn_deuda_Click (object sender, EventArgs e)
        {
            double valor = CRazónCuenta.Razon_cuenta("Razón_deuda", bunifuDatePicker1.Value);
            string texto = "El " + valor + "% de los bienes de la empresa las debe a los acreedores.<br>" +
                            "Es decir del total de los activos de la empresa se debe el " + valor + "%";
            new MessageWindow("Razón de deuda", texto).Show();
        }

        private void btn_cnt_Click (object sender, EventArgs e)
        {
            double valor1 = CRazónCuenta.Razon_cuenta("Capital_Trabajo", bunifuDatePicker1.Value);
            double valor2 = CRazónCuenta.Razon_cuenta("Capital_Trabajo", bunifuDatePicker2.Value);

            string texto = "El Capital neto de trabajo es de " + valor1 + ", esto quiere decir cuenta <br> " +
                            "con ese dinero una vez habiendo cancelado con todas las <br> " +
                            "obligaciones  a corto plazo." + Mensaje_razón(valor1, valor2) + " en el " + bunifuDatePicker2.Value.Year;

            new MessageWindow("Capital Neto Trabajo", texto).Show();
        }

        private void btn_pa_Click (object sender, EventArgs e)
        {

            double valor1 = CRazónCuenta.Razon_cuenta("Razon_ácida", bunifuDatePicker1.Value);
            double valor2 = CRazónCuenta.Razon_cuenta("Razon_ácida", bunifuDatePicker2.Value);

            string texto = "La razón para el año, significa que por cada córdoba de deuda <br> " +
                            "de la empresa esta en capacidad de responder con " + valor1 + " <br> " +
                            "centavos si esta decidiera no entregar sus inventarios.<br>" + 
                            Mensaje_razón(valor1, valor2) + " en el " + bunifuDatePicker2.Value.Year;

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
            double valor1 = CRazónCuenta.Razon_cuenta("Rotación_Inventario", bunifuDatePicker1.Value);
            double valor2 = CRazónCuenta.Razon_cuenta("Rotación_Inventario", bunifuDatePicker2.Value);

            string texto = "La razón para el año, significa que por cada córdoba de deuda de la <br> " +
                           "empresa esta en capacidad de responder con " + valor1 + " centavos <br>" +
                           "si esta decidiera no entregar sus inventarios." + Mensaje_razón(valor1, valor2) + " en el " + bunifuDatePicker2.Value.Year;

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
            double valor1 = CRazónCuenta.Razon_cuenta("Rotación_ActivoFijo", bunifuDatePicker1.Value);
            double valor2 = CRazónCuenta.Razon_cuenta("Rotación_ActivoFijo", bunifuDatePicker2.Value);

            string texto = "EL índice indica que por cada córdoba invertido en activos fijos netos <br>" +
                           "proporciona " + valor1 + " en ventas." + Mensaje_razón(valor1, valor2) + " en el " + bunifuDatePicker2.Value.Year;



            new MessageWindow("Razón activo fijo", texto).Show();
        }

        private void btn_ActivoTotal_Click (object sender, EventArgs e)
        {
            double valor1 = CRazónCuenta.Razon_cuenta("Rotación_ActivoTotal", bunifuDatePicker1.Value);
            double valor2 = CRazónCuenta.Razon_cuenta("Rotación_ActivoTotal", bunifuDatePicker2.Value);

            string texto = "Al dividir las ventas entre la inversión concentrada en los activos <br> " +
                           "totales se determina que cada córdoba invertido en activos es <br> " +
                           "capaz de generar " + valor1 + " centavos de ingresos por ventas.<br>" + 
                            Mensaje_razón(valor1, valor2) + " en el " + bunifuDatePicker2.Value.Year;

            new MessageWindow("Razón activo total", texto).Show();
        }

        private void btn_UtilidadBruta_Click (object sender, EventArgs e)
        {
            double valor1 = CRazónCuenta.Razon_cuenta("MUB", bunifuDatePicker1.Value);
            double valor2 = CRazónCuenta.Razon_cuenta("MUB", bunifuDatePicker2.Value);

            string texto = "Indica que por cada dólar de venta se obtiene un MUB de " + valor1 + " <br> centavos de dolar." +
                            Mensaje_razón(valor1, valor2) + " en el " + bunifuDatePicker2.Value.Year;
            new MessageWindow("Margen de utilidad bruta", texto).Show();
        }

        private void btn_UtilidadOper_Click (object sender, EventArgs e)
        {
            double valor1 = CRazónCuenta.Razon_cuenta("MUO", bunifuDatePicker1.Value);
            double valor2 = CRazónCuenta.Razon_cuenta("MUO", bunifuDatePicker2.Value);

            string texto = "La utilidad de operación representa el " + valor1 + " de las ventas; es decir <br> "
                            + valor1 + " centavos por cada dólar en venta." + Mensaje_razón(valor1, valor2) + "en el " + bunifuDatePicker2.Value.Year;

            new MessageWindow("Margen de utilidad operativa", texto).Show();
        }

        private void btn_UtilidadNeta_Click (object sender, EventArgs e)
        {
            double valor1 = CRazónCuenta.Razon_cuenta("MUN", bunifuDatePicker1.Value);
            double valor2 = CRazónCuenta.Razon_cuenta("MUN", bunifuDatePicker2.Value);

            string texto = "El margen de utilidad neta es de " + valor1 + " centavos por cada dólar <br> en venta." + 
                            Mensaje_razón(valor1, valor2) + "en el " + bunifuDatePicker2.Value.Year;

            new MessageWindow("Margen de utilidad neta", texto).Show();
        }

        private void btn_PeriCobro_Click (object sender, EventArgs e)
        {

        }

        private void btn_PasivoCap_Click (object sender, EventArgs e)
        {
            double valor1 = CRazónCuenta.Razon_cuenta("Razon_PasivoCapital", bunifuDatePicker1.Value) * 100;
            double valor2 = CRazónCuenta.Razon_cuenta("Razon_PasivoCapital", bunifuDatePicker2.Value) * 100;

            string texto = "El índice explica que el " + (valor1) + " % de nuestro capital social representa <br>" +
                           "el pasivo a largo plazo." + Mensaje_razón(valor1, valor2) + "% en el " + bunifuDatePicker2.Value.Year;
            new MessageWindow("Razón pasivo/capital ", texto).Show();
        }

        public string Mensaje_razón (double valor1, double valor2)
        {
            if (valor1 > valor2 )
            {
                return "Hubo una disminicion de " + valor2 ;
            }
            else if (valor1 < valor2)
            {
                return "Hubo un aumento de " + valor2;
            }
            else
            {
                return "No hubo cambio";
            }
        }


    }
}
