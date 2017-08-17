using Common.Helper.KeyValues;
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
using Common.Model;
using Common.Helper;
using BusinessLogic.Persona;

namespace EagleSales.Buscadores
{
    public partial class FormBuscarCliente : MetroForm
    {
        #region Variables
        public PERt02_cliente cliente = null;
        public string codTipoSujeto = "";

        #endregion

        public FormBuscarCliente()
        {
            InitializeComponent();
        }

        #region Métodos

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Hide();
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CargarGrid(IEnumerable<PERt02_cliente> list)
        {
            if (list != null)
            {
                dgvCliente.DataSource = list.Select(x => new
                {
                    ID = x.id_cliente,
                    CODIGO = x.cod_cliente,
                    CLIENTE = PersonHelper.GetNombre(x.txt_ape_pat, x.txt_ape_mat, x.txt_pri_nom, x.txt_seg_nom, x.txt_rzn_social),
                    NRO_DOC = x.nro_doc,
                    RUC = x.nro_ruc,
                    ESTADO = x.txt_estado,
                    DIREC1 = x.txt_direccion1,
                    DIREC2 = x.txt_direccion2
                }).ToList();
            }
            else
            {
                var clientHeader = new List<TNSt05_comp_emitido_dtl>();
                dgvCliente.DataSource = clientHeader.Select(x => new
                {
                    ID = "",
                    CODIGO = "",
                    CLIENTE = "",
                    NRO_DOC = "",
                    RUC = "",
                    ESTADO = "",
                    DIREC1 = "",
                    DIREC2 = ""
                }).ToList();
            }
            DefinirCabeceraGrid();

        }

        private void CargarCombos()
        {
            cboTipoSujeto.DisplayMember = "Text";
            cboTipoSujeto.ValueMember = "Value";

            var items = new[] {
                                new { Text = "CLIENTE", Value = TipoSujeto.Cliente },
                                new { Text = "PROVEEDOR", Value = TipoSujeto.Proveedor }
                            };

            cboTipoSujeto.DataSource = items;
        }

        private void BuscarCliente(bool verTodos = false)
        {
            var nroDoc = ""; var nroRuc = ""; var nombre = "";
            int estado = 99;
            if (!verTodos)
            {
                nroDoc = txtNroDocumento.Text.Trim();
                nroRuc = txtNroRUC.Text.Trim();
                nombre = txtNombreCliente.Text.Trim();
                if (!checkInactivos.Checked && checkActivos.Checked)
                    estado = Estado.Activo;
                else if (checkInactivos.Checked && !checkActivos.Checked)
                    estado = Estado.Inactivo;
                else if (!checkInactivos.Checked && !checkActivos.Checked)
                    estado = 100;
            }

            var codTipoSujeto = cboTipoSujeto.SelectedValue?.ToString();

            var list = new ClienteBL().BuscarCliente(nroDoc, nroRuc, nombre, codTipoSujeto, estado);

            CargarGrid(list);



        }

        private void SetInicio()
        {
            ConfigurarControles();
            CargarCombos();
            BuscarCliente();
        }

        private void DefinirCabeceraGrid()
        {
            try
            {
                dgvCliente.Columns["ID"].Visible = false;
                dgvCliente.Columns["DIREC1"].Visible = false;
                dgvCliente.Columns["DIREC2"].Visible = false;

                dgvCliente.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCliente.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCliente.Columns["CODIGO"].HeaderText = "CÓDIGO";
                dgvCliente.Columns["CODIGO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCliente.Columns["CODIGO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCliente.Columns["NRO_DOC"].HeaderText = "NRO. DOC";
                dgvCliente.Columns["NRO_DOC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCliente.Columns["NRO_DOC"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCliente.Columns["RUC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCliente.Columns["RUC"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCliente.Columns["ESTADO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCliente.Columns["ESTADO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCliente.Columns["CLIENTE"].Width = 305;
            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarControles()
        {
            #region Form
            MaximizeBox = false;
            Resizable = false;
            #endregion

            #region Checks

            checkActivos.Checked = true;
            checkInactivos.Checked = false;

            #endregion

            #region TextBox

            txtNroDocumento.MaxLength = 15;
            txtNroRUC.MaxLength = 15;
            txtNombreCliente.MaxLength = 150;

            #endregion

            #region Grilla
            var clientHeader = new List<TNSt05_comp_emitido_dtl>();
            dgvCliente.DataSource = clientHeader.Select(x => new
            {
                ID = "",
                CODIGO = "",
                CLIENTE = "",
                NRO_DOC = "",
                RUC = "",
                ESTADO = "",
                DIREC1 = "",
                DIREC2 = ""
            }).ToList();
            DefinirCabeceraGrid();
            ControlHelper.ConfigurarGrilla(dgvCliente);

            #endregion

        }

        private void SeleccionarCliente()
        {
            if (dgvCliente.CurrentRow != null)
            {
                try
                {
                    cliente = new PERt02_cliente()
                    {
                        id_cliente = long.Parse(dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells["ID"].Value.ToString()),
                        cod_cliente = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells["CODIGO"].Value.ToString(),
                        txt_pri_nom = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells["CLIENTE"].Value.ToString(),
                        nro_doc = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells["NRO_DOC"].Value.ToString(),
                        nro_ruc = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells["RUC"].Value.ToString(),
                        txt_direccion1 = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells["DIREC1"].Value.ToString(),
                        txt_direccion2 = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells["DIREC2"].Value.ToString()
                    };
                    codTipoSujeto = cboTipoSujeto.SelectedValue?.ToString();

                    Hide();
                    Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Excepción al seleccionar el cliente. EXC: " + e.Message, "Mensaje Eagle");
                }

            }
        }

        #endregion

        #region Eventos

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            SetInicio();
        }

        private void txtNroDocumento_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void checkInactivos_CheckedChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void checkActivos_CheckedChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void cboTipoSujeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            BuscarCliente(true);
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void txtNroRUC_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarCliente();
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarCliente();
        }

        private void dgvCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionarCliente();
            }
        }
        #endregion

    }
}
