using Common.Helper;
using Common.Model;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EagleSales.Transaccion.MedioDePagoDtl
{
    public partial class FormMedioDePagoDtl : MetroForm
    {
        public FormMedioDePagoDtl()
        {
            InitializeComponent();
        }

        void DefinirCabeceraGridMedioPago()
        {
            try
            {
                dgvMedioPago.Columns["ID_MED_PAGO"].Visible = false;

                dgvMedioPago.Columns["MONTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvMedioPago.Columns["MONTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvMedioPago.Columns["TIPO_CAMBIO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvMedioPago.Columns["TIPO_CAMBIO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvMedioPago.Columns["CONVERSION"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvMedioPago.Columns["CONVERSION"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvMedioPago.Columns["DESC"].HeaderText = "MEDIO DE PAGO";
                dgvMedioPago.Columns["TIPO_CAMBIO"].HeaderText = "CAMBIO";
                dgvMedioPago.Columns["CONVERSION"].HeaderText = "CONVERSIÓN";

                //dgvMedioPago.Columns["MONTO"].Width = 100;
                dgvMedioPago.Columns["DESC"].Width = 200;

            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla de productos. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ConfigurarControles()
        {

            #region Grilla
            var medioDePagoDtlHeader = new List<TNSt07_medio_pago_dtl>();
            dgvMedioPago.DataSource = medioDePagoDtlHeader.Select(x => new
            {
                ID_MED_PAGO = "",
                DESC = "",
                MONTO = "",
                MONEDA = "",
                TIPO_CAMBIO = "",
                CONVERSION = ""
            }).ToList();
            DefinirCabeceraGridMedioPago();
            ControlHelper.ConfigurarGrilla(dgvMedioPago);

            #endregion

            #region Pestaña Medio de Pago

            txtMtoActualMedioPago.ReadOnly = true;
            txtMtoTotalMedioPago.ReadOnly = true;
            txtMtoRestanteMedioPago.ReadOnly = true;

            txtMtoMedioPago.TextAlign = HorizontalAlignment.Right;
            txtTipoDeCambio.TextAlign = HorizontalAlignment.Right;
            txtMtoActualMedioPago.TextAlign = HorizontalAlignment.Right;
            txtMtoTotalMedioPago.TextAlign = HorizontalAlignment.Right;
            txtMtoRestanteMedioPago.TextAlign = HorizontalAlignment.Right;


            txtMtoMedioPago.WaterMark = "0.00";
            txtTipoDeCambio.WaterMark = "0.00";
            txtMtoActualMedioPago.WaterMark = "0.00";
            txtMtoTotalMedioPago.WaterMark = "0.00";
            txtMtoRestanteMedioPago.WaterMark = "0.00";

            #endregion
        }

        void SetInicio()
        {
            ConfigurarControles();
        }

        private void btnAddMtoMedioPago_Click(object sender, EventArgs e)
        {

        }

        class CommonItem
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        private void FormMedioDePagoDtl_Load(object sender, EventArgs e)
        {
            SetInicio();

            var medios = new List<CommonItem>()
            {
                new CommonItem(){ Value=1, Text="EFECTIVO" },
                new CommonItem(){ Value=2, Text="VISA" },
                new CommonItem(){ Value=3, Text="MASTERCAD" },
                new CommonItem(){ Value=4, Text= "DÉBITO BCP" },
                new CommonItem(){ Value=5, Text="CRÉDITO BCP" },
                new CommonItem(){ Value=6, Text= "TARJETA RIPLEY" },
                new CommonItem(){ Value=7, Text=  "TARJETA OH" },
                new CommonItem(){ Value=8, Text= "TARJETA CON UN NOMBRE QUE DEBERÍA SER DEMASIADO LARGO COMO PARA MOSTRARSE POR COMPLETO EN EL BOTÓN" },
                new CommonItem(){ Value=9, Text="TARJETA GHOST" },
                new CommonItem(){ Value=10, Text="TARJETA VISA PLATINO" },
                    new CommonItem(){ Value=11, Text="TARJETA VISA PLATINO 2" }
            };

            int rowCount = 1, columnCount = 4;
            if (medios.Count > columnCount)
                rowCount = (int)Math.Ceiling((decimal)medios.Count / columnCount);

            tableLayoutPanel1.ColumnCount = columnCount;
            tableLayoutPanel1.RowCount = rowCount;

            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rowCount));
            }

            if (medios != null)
                foreach (var m in medios)
                {
                    var b = new MetroButton()
                    {
                        Text = m.Text,
                        Name = $"btn{m.Text.Substring(0, m.Text.Length > 10 ? 10 : m.Text.Length)}_{m.Value}"
                    };
                    b.Click += b_Click;
                    b.Dock = DockStyle.Fill;
                    tableLayoutPanel1.Controls.Add(b);
                }
        }

        void b_Click(object sender, EventArgs e)
        {
            var b = sender as MetroButton;
            if (b != null)
                MessageBox.Show($"{b.Name.Substring(b.Name.LastIndexOf("_") + 1)}");
        }
    }
}
