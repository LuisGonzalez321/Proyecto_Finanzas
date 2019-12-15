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
        int contador = 1;

        public MenuPrincipal ()
        {
            InitializeComponent();
            Panel [] panel = null;//{ panel_Inicio, panel_EF, panel_RF, panel_AF,panel_configuración};
            Insertar_MouseEnter(panel);
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

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

        public void Insertar_MouseEnter (Panel [] numero)
        {
            /*foreach (Panel i in numero)
            {
                //i.MouseEnter += new EventHandler(panel_MouseEnter);
                i.MouseEnter += new EventHandler((sender, e)=>{
                    i.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (49)))), ((int) (((byte) (86)))), ((int) (((byte) (196)))));
                });

                i.MouseLeave += new EventHandler((sender, e) => {
                    i.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (98)))), ((int) (((byte) (207)))));
                });
            }*/
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
            }else
            {
                gradiente_panel1.Visible = true;
            }
           
        }

        private void gradiente_panel1_Paint (object sender, PaintEventArgs e)
        {

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
    }
}
