using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas.Controlador.Herramientas
{
    public class Toolkit
    {

        public static string Estado_Empresa (int valor)
        {
            if (valor > 0 && valor <= 20)
            {
                return "La empresa está en una excelente posición";
            }
            else if (valor > 21 && valor <= 40)
            {
                return "La empresa está en una buena posición";
            }
            else if (valor > 50 && valor <= 70)
            {
                return "La empresa está en una mala posició";
            }
            else
            {
                return "La empresa está en una pésima posición";
            }
        }

        public static void ValidarNumeros_KeyPress (object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && ((e.KeyChar != ',') && (e.KeyChar != '-')))
            {
                e.Handled = true;
            }
            // solo 1 punto decimal
            if (((e.KeyChar == '-') && (e.KeyChar == ',')) && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 22)
            {
                e.Handled = true;
            }

        }

        public static bool ValidarCampos (DataGridView datagrid)
        {
            for (int i = 0 ;i < datagrid.RowCount ;i++)
            {
                if (datagrid.Rows [i].Cells [0].Value == null)
                {
                    return false;
                }
            }
            return true;
        }

        public static void Formato_tabla (DataGridView [] datagrid)
        {
            foreach (Bunifu.UI.WinForms.BunifuDataGridView tabla in datagrid)
            {
                tabla.Columns ["NombreCuenta"].ReadOnly = true;
                tabla.Columns ["NombreCuenta"].DisplayIndex = 0;
                string nombre_tabla = tabla.Columns [0].Name;
                tabla.Columns [nombre_tabla].DisplayIndex = 1;
            }
        }

        public static bool validar_camposTextbox (string texto)
        {
            return texto != null ? true : false;
        }

        public static bool validar_existencia_formulario (string nombre)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == nombre).SingleOrDefault<Form>();
            return (existe != null) ? true :false;
        }

    }
}
