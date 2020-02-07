using Finazas.Controlador;
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
    public partial class AgregarUsuario: Form
    {
        private int id;

        public AgregarUsuario ()
        {
            InitializeComponent();
            this.Cargar_datos();
        }

        public void Cargar_datos ()
        {
            tabla_usuario.DataSource = CUsuario.Mostrar();
            btn_actualizar.Enabled = false;
            btn_agregar.Enabled = true;

            txt_usuario.Text = "";
            txt_contraseña.Text = "";
            combox_rol.selectedIndex = 0;
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
                pos = this.panel1.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr) 2;
                    return;
                }
                if (pos.X >= this.panel1.ClientSize.Width - cGrip && pos.Y >= this.panel1.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr) 17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void btn_agregar_Click (object sender, EventArgs e)
        {
            string nombre_usuario = txt_usuario.Text;
            string contraseña = txt_contraseña.Text;
            string rol = combox_rol.selectedValue;
            int i = combox_rol.selectedIndex;

            var flag2 = (txt_usuario.Text != null && txt_contraseña.Text != null && i != 0) ? true : false;

            if (flag2)
            {
                var flag = CUsuario.Insertar_usuario(nombre_usuario, contraseña, rol);
                if (flag)
                {
                    MessageBox.Show("¡Usuario agregado con éxito!", "Completo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Cargar_datos();
                }
                else
                {
                    MessageBox.Show("¡Usuario no agregado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("¡Verifique los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show("¡Desea salir!", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btn_salir_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show("¡Desea salir!", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btn_actualizar_Click (object sender, EventArgs e)
        {
            string nombre_usuario = txt_usuario.Text;
            string contraseña = txt_contraseña.Text;
            string rol = combox_rol.selectedValue;
            int i = combox_rol.selectedIndex;

            var flag2 = (txt_usuario.Text != null && txt_contraseña.Text != null && i != 0) ? true : false;
        
            if (flag2)
            {
                var flag = CUsuario.Editar(id, nombre_usuario, contraseña, rol);
                if (flag != null)
                {
                    MessageBox.Show("¡Usuario actualizado con éxito!", "Completo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Cargar_datos();
                }
                else
                {
                    MessageBox.Show("¡Usuario no agregado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("¡Verifique los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tabla_usuario_CellDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.ColumnIndex > 0)
            {
                id = int.Parse(tabla_usuario.Rows [i].Cells [1].Value.ToString());
                txt_usuario.Text = tabla_usuario.Rows [i].Cells [2].Value.ToString();
                txt_contraseña.Text = tabla_usuario.Rows [i].Cells [3].Value.ToString();
                btn_agregar.Enabled = false;
                btn_actualizar.Enabled = true;
            }
        }

        private void tabla_usuario_CellClick (object sender, DataGridViewCellEventArgs e)
        {
            int i = e.ColumnIndex;
            if (i == 0)
            {
                id = int.Parse(tabla_usuario.Rows [e.RowIndex].Cells [1].Value.ToString());
                if (MessageBox.Show("¿Desea eliminar este usuario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CUsuario.Eliminar(id);
                    MessageBox.Show("¡Usuario eliminado con éxito!", "Completo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Cargar_datos();
                }
            }
        }
    }
}
