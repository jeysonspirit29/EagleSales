using BusinessLogic.Maestro;
using BusinessLogic.Sunat;
using Common.Helper;
using Common.Helper.KeyValues;
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
        IEnumerable<MSTt01_medio_pago> _mediosDePago = null;
        decimal _mtoTotal = 1;

        public FormMedioDePagoDtl(decimal mtoTotal)
        {
            _mtoTotal = mtoTotal;
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
            #region Label
            //lblMtoTotal.AutoSize = false;
            //lblMtoTotal.TextAlign = ContentAlignment.MiddleRight;
            //lblMtoTotal.Anchor = AnchorStyles.Left;


            #endregion

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

            #region Layout
            panel1.AutoScroll = true;
            panel1.AutoSize = false;

            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.AutoScroll = false;

            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            #endregion



            #region Combos

            cboMoneda.DropDownWidth = 250;
            cboMedioDePago.DropDownWidth = 250;

            cboMoneda.DropDownHeight = 400;
            cboMedioDePago.DropDownHeight = 400;
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
            //Indepencia de data
            ConfigurarControles();
            //Dependencia débil
            txtMtoTotalMedioPago.Text = _mtoTotal.ToString();
            lblMtoTotal.Text = $"Total: S/ {_mtoTotal}";
            //Cargar data
            _mediosDePago = new MedioPagoBL().ListMedioPago(Estado.Activo);
            //Dependencia de data
            RenderMediosDePagoRapido();
            CargarCombos();
            //liberando memoria
            _mediosDePago = null;

        }

        void CargarCombos()
        {
            try
            {
                cboMedioDePago.DisplayMember = "txt_desc";
                cboMedioDePago.ValueMember = "id_medio_pago";
                cboMedioDePago.DataSource = _mediosDePago;

                cboMoneda.DisplayMember = "txt_desc";
                cboMoneda.ValueMember = "id_tipo_moneda";
                cboMoneda.DataSource = new MonedaBL().ListMoneda(Estado.Activo);

                //VER LOS QUERYS ENVIADOS POR SQLPROFILER

                /*
                 008	008	EFECTIVO, POR OPERACIONES EN LAS QUE NO EXISTE OBLIGACIÓN DE UTILIZAR MEDIO DE PAGO
                009	009	EFECTIVO, EN LOS DEMÁS CASOS
                 */

            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo cargar los combos. Excepción: " + e.Message, "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddMtoMedioPago_Click(object sender, EventArgs e)
        {

        }

        private void FormMedioDePagoDtl_Load(object sender, EventArgs e)
        {
            SetInicio();

        }

        void RenderMediosDePagoRapido()
        {
            var medios = _mediosDePago.Where(x => x.cod_medio_pago != "0").ToList();

            int rowCount = 1, columnCount = 4;
            if (medios.Count > columnCount)
                rowCount = (int)Math.Ceiling((decimal)medios.Count / columnCount);

            tableLayoutPanel1.ColumnCount = columnCount;
            tableLayoutPanel1.RowCount = rowCount;

            for (int i = 0; i < columnCount; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columnCount != 0 ? columnCount : 1));
            }
            for (int i = 0; i < rowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rowCount != 0 ? columnCount : 1));
            }

            if (medios != null)
                foreach (var m in medios)
                {
                    var b = new MetroButton()
                    {
                        Height = 50,
                        Font = new Font("Segoe UI", 20.0f),
                        Text = m.txt_desc,
                        Name = $"btn{m.txt_desc.Substring(0, m.txt_desc.Length > 10 ? 10 : m.txt_desc.Length)}_{m.id_medio_pago}"
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
            {
                //b.Enabled = false; panel
                MessageBox.Show($"{b.Name.Substring(b.Name.LastIndexOf("_") + 1)}");
            }
        }
    }
}
