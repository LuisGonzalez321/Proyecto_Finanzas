using Finazas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas.Controlador
{
    public class CCuenta
    {

        public static DataTable Catalogo_Cuentas (string tipo)
        {
            return new MCuenta().Catalogo_Cuentas(tipo);
        }

        public static bool Insertart_monto (int idCuenta, double monto, DateTime fecha, string concepto)
        {
            return new MCuenta().Insertar_monto(idCuenta, monto, fecha, concepto);
        }

        public static DataTable Mostrar_EstadoResultado ()
        {
            return new MCuenta().Mostrar_EstadoResultado();
        }

        public static void Guardar_activos (Bunifu.UI.WinForms.BunifuDataGridView datagrid, Bunifu.UI.WinForms.BunifuDatePicker datepicker_BG)
        {
            double monto;
            for (int i = 0 ;i < datagrid.RowCount;i++)
            {
                monto = double.Parse(datagrid.Rows [i].Cells [0].Value.ToString());
                if (Insertart_monto(i + 1, monto, datepicker_BG.Value, "D") == false)
                return;
            }
        }

        public static void Guardar_Pasivos (Bunifu.UI.WinForms.BunifuDataGridView datagrid, Bunifu.UI.WinForms.BunifuDatePicker datepicker_BG)
        {
            double monto;
            for (int i = 0 ;i < datagrid.RowCount ;i++)
            {
                monto = double.Parse(datagrid.Rows [i].Cells [0].Value.ToString());
                Insertart_monto(i + 17, monto, datepicker_BG.Value, "H");
            }
        }

        public static void Guardar_Capital (Bunifu.UI.WinForms.BunifuDataGridView datagrid, Bunifu.UI.WinForms.BunifuDatePicker datepicker_BG)
        {
            double monto;
            for (int i = 0 ;i < datagrid.RowCount; i++)
            {
                monto = double.Parse(datagrid.Rows [i].Cells [0].Value.ToString());
                Insertart_monto(i + 25, monto, datepicker_BG.Value, "H");
            }
        }

        public static DataTable Estado_Resultados (int año)
        {
            return new MCuenta().Estado_Resultados(año);
        }

    }
}
