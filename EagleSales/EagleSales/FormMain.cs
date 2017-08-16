using Common.Helper.KeyValues;
using EagleSales.Transaccion.Comprobante;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace EagleSales
{
    public partial class FormMain : MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region Métodos

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {

                if (MessageBox.Show("¿Estás seguro de salir de EagleSales?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Hide();
                    Close();
                    Dispose();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ConfigurarControles()
        {

            #region botones (Tiles)

            btnHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            btnFecha.Text = DateTime.Now.ToLongDateString();

            #endregion

            #region timer

            timerHoraFecha.Interval = 1000;
            timerHoraFecha.Start();

            #endregion
        }

        #endregion

        #region Eventos

        private void FormMain_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
        }

        private void linkSalir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Estás seguro de salir de EagleSales?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hide();
                Close();
                Dispose();
            }
        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            new FormAddEditCompEmitido(FormAction.Add).ShowDialog();
        }

        private void timerHoraFecha_Tick(object sender, EventArgs e)
        {
            btnHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            btnFecha.Text = DateTime.Now.ToLongDateString();
        }

        #endregion

    }
}
