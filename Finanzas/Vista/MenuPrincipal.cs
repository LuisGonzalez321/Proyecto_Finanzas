using Finanzas.Controlador;
using Finanzas.Vista;
using System;

using System.Drawing;

using System.Windows.Forms;

namespace Finazas.Vista
{
    public partial class MenuPrincipal: Form
    {

        public MenuPrincipal ()
        {
            InitializeComponent();
            lbl_BG.Text = "BALANCE GENERAL :" + Convert.ToInt32(CRazónCuenta.Razon_cuenta("Total_Activo", datepicker.Value));
            lbl_utilidad.Text = "ESTADO DE RESULTADOS :" + CCuenta.Mostrar_utilidad("dbo.Mostrar_UtilidadNeta", datepicker.Value.Year);

            int valor = Convert.ToInt32(CRazónCuenta.Razon_cuenta("Razón_deuda", datepicker.Value));
            radial_gauge.Value = valor;
            lbl_estado.Text = Finanzas.Controlador.Herramientas.Toolkit.Estado_Empresa(valor);
        }


        private const int cGrip = 16;
        private const int cCaption = 32;


        /*
         * Metodo para poder mover la ventana
         */
        protected override void WndProc (ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.gradiente_panel2.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr) 2;
                    return;
                }
                if (pos.X >= this.gradiente_panel2.ClientSize.Width - cGrip && pos.Y >= this.gradiente_panel2.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr) 17;
                    return;
                }
            }
            base.WndProc(ref m);
        }



        private void bunifuImageButton1_Click (object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_spiner_Click (object sender, EventArgs e)
        {
            if (gradiente_panel1.Visible == true)
            {
                gradiente_panel1.Visible = false;
            }
            else
            {
                gradiente_panel1.Visible = true;
            }
        }


        private void btn_ef_Click (object sender, EventArgs e)
        {
            EstadosFinancieros ef = new EstadosFinancieros(); 
            bool flag = Finanzas.Controlador.Herramientas.Toolkit.validar_existencia_formulario(ef.Name);
            if (!flag)
            {
                ef.Show();
            }
        }

        private void btn_af_Click (object sender, EventArgs e)
        {
            OA oa = new OA();
            oa.Show();
        }

        private void btn_rf_Click (object sender, EventArgs e)
        {
            RazonesFinancieras rf = new RazonesFinancieras();
            bool flag = Finanzas.Controlador.Herramientas.Toolkit.validar_existencia_formulario(rf.Name);
            if (!flag)
            {
                rf.Show();
            }
        }

        private void btn_minimizar_Click (object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_info_MouseEnter (object sender, EventArgs e)
        {
            string información = "Es un sistema que realiza el análisis financiero de la empresa FERRISIS (Ferretería) <br>" +
                                 "1 - Realiza análsis vertical y horizontal <br>" +
                                 "2 - Elabora las razones financieras <br>" +
                                 "3 - Elabora estado de origen y aplicación de fondo y fljo neto de efectivo <br>" +
                                 "4 - Realiza apalancamiento <br>";
            bunifuToolTip1.SetToolTip(btn_info, información);
        }

        private void btn_palanca_Click (object sender, EventArgs e)
        {
            Apalancamiento palanca = new Apalancamiento();
            bool flag = Finanzas.Controlador.Herramientas.Toolkit.validar_existencia_formulario(palanca.Name);
            if (!flag)
            {
                palanca.Show();
            }
        }

        private void btn_verEFE_Click (object sender, EventArgs e)
        {
            Entrada_Salida entrada_salida = new Entrada_Salida();
            bool flag = Finanzas.Controlador.Herramientas.Toolkit.validar_existencia_formulario(entrada_salida.Name);
            if (!flag)
            {
                entrada_salida.Show();
            }
        }

        private void btn_inicio_Click (object sender, EventArgs e)
        {
            pages_opciones.SelectedIndex = 0;
        }

        private void btn_configuración_Click (object sender, EventArgs e)
        {
            pages_opciones.SelectedIndex = 1;
        }

        private void btn_usuario_Click (object sender, EventArgs e)
        {
            AgregarUsuario agregar = new AgregarUsuario();
            bool flag = Finanzas.Controlador.Herramientas.Toolkit.validar_existencia_formulario(agregar.Name);
            if (!flag)
            {
                agregar.Show();
            }
        }

        private void btn_presupuesto_Click (object sender, EventArgs e)
        {
            Pronóstico pronostico = new Pronóstico();
            pronostico.Show();
        }
    }
}
