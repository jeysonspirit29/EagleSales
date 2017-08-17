using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Common.Helper
{
    public static class ControlHelper
    {
        public static void ValidarTxtDecimal(object sender, KeyPressEventArgs e)
        {
            MetroTextBox txt = (MetroTextBox)sender;
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                if (e.KeyChar == '.')
                    e.Handled = txt.Text.Contains(".") || txt.Text.Equals("") ? true : false;
                else
                    e.Handled = true;
            }
        }

        public static void ConfigurarGrilla(DataGridView dgv, float fontSize = 9.75F, FontStyle fontStyle = FontStyle.Regular, Color? colorLetter = null)
        {

            #region Configuración grilla

            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.BorderStyle = BorderStyle.None;
            dgv.ReadOnly = true;

            dgv.ColumnHeadersHeight = 30;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.EnableHeadersVisualStyles = false;//Para que no sobreescriba la cabecera

            #endregion

            #region Estilo grilla
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;
            dgv.ForeColor = colorLetter ?? Color.Black;
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#446CB3");
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#03C9A9");
            dgv.Font = new Font("Segoe UI", fontSize, fontStyle);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            #endregion

        }
    }
}
