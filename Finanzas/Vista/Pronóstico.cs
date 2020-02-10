﻿using System;
using System.Windows.Forms;

namespace Finanzas.Vista
{
    public partial class Pronóstico: Form
    {
        public Pronóstico ()
        {
            InitializeComponent();
            cargar_elementos();
        }

        public void cargar_elementos ()
        {
            string [] datos = { "Ventas al contado(0.3)", "Cobro de cuentas pendientes", "plazo(0.5)", "plazo(0.3)", "Otras entradas de efectivo", "Entradas de efectivos totales" };
            foreach (string i in datos)
            {
                tabla_ingresos.Rows.Add(i);
            }

            string [] datos2 = {"Compras ", "Compras efectivo", "Pago cuentas", "plazo un mes (0.7)", "Plazo un mes (0.2)", "Dividendos en efectivo", "Gastos de arriendo", "Sueldos y salarios"
                                ,"Pago de impuestos", "Desembolso de activo fijo", "Pago de interes", "Pagos sobre prestamos","Desembolso de efectivos totales"};

            foreach (string i in datos2)
            {
                tabla_egresos.Rows.Add(i);
            }

            string [] datos3 = {"Entradas de efectivos totales","(-) Desembolso de efectivos", "Flujo neto de efectivo", "(+) Efectivo inicial", "Efectivo final", "(-) Saldo mínimo de efectivo"
                                ,"Financiamiento total requirido", "Saldo de efectivo en exceso"};

            foreach (string i in datos3)
            {
                tabla_caja.Rows.Add(i);
            }
        }

        private void Tabla_EditingControlShowing (object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl) e.Control;

            dText.KeyPress -= new KeyPressEventHandler(Finanzas.Controlador.Herramientas.Toolkit.ValidarNumeros_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(Finanzas.Controlador.Herramientas.Toolkit.ValidarNumeros_KeyPress);
        }
        

        private void btn_salir_Click (object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_minimizar_Click (object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
