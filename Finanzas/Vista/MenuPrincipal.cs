using Finanzas.Controlador;
using Finanzas.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finazas.Vista
{
    public partial class MenuPrincipal: Form
    {

        public MenuPrincipal ()
        {
            InitializeComponent();
            lbl_BG.Text = "BALANCE GENERAL :" + Convert.ToInt32(CRazónCuenta.Razon_cuenta("Total_Activo",datepicker.Value) );
            int valor = Convert.ToInt32(CRazónCuenta.Razon_cuenta("Razón_deuda", datepicker.Value));
            radial_gauge.Value = valor;
            lbl_estado.Text = Finanzas.Modelo.Herramientas.Toolkit.Estado_Empresa(valor);
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
            ef.Show();
        }

        private void btn_info_Click (object sender, EventArgs e)
        {
            Informacion informacion = new Informacion();
            informacion.ShowDialog();
        }

        private void btn_af_Click (object sender, EventArgs e)
        {
           
        }

        private void btn_rf_Click (object sender, EventArgs e)
        {
            RazonesFinancieras rf = new RazonesFinancieras();
            rf.Show();
        }

        private void btn_minimizar_Click (object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
