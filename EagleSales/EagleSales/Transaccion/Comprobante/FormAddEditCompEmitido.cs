using BusinessLogic.Maestro;
using BusinessLogic.Producto;
using BusinessLogic.Sunat;
using Common.Helper;
using Common.Helper.KeyValues;
using Common.Model;
using EagleSales.Buscadores;
using EagleSales.Transaccion.MedioDePagoDtl;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EagleSales.Transaccion.Comprobante
{
    public partial class FormAddEditCompEmitido : MetroForm
    {

        #region Variables

        enum InputCalculo
        {
            PorcDescuento, PorcRecargo, MtoDescuento, MtoRecargo
        }

        private int formAction = 0;

        private long idCliente = 0;
        private PROt09_producto prod = null;
        private string codTipoSujeto = "";

        private List<TNSt05_comp_emitido_dtl> details = null;
        private List<TNSt07_medio_pago_dtl> listMedioPago = null;

        private int numDec = 2;

        //CARGADOS
        int porcImpuesto = 18;
        int maxNumItems = 5;

        #endregion

        public FormAddEditCompEmitido(int formAction)
        {
            InitializeComponent();
            Opacity = 0;
            timerFade.Start();
            timerFade.Interval = 1;
            this.formAction = formAction;
        }

        #region Métodos

        private void AddHandlers()
        {
            var txts = new[] { txtCantidad, txtDsctoItem, txtPeso, txtPrecio, txtPorcRecargo, txtPorcDescuento, txtRecargo, txtDescuento, txtMtoMedioPago };
            foreach (var txt in txts)
            {
                txt.KeyPress += ControlHelper.ValidarTxtDecimal;

            }
        }

        private void ConfigurarControles()
        {
            #region Form
            MaximizeBox = false;
            Resizable = false;
            #endregion

            #region TextBox

            #region Pestaña Principal
            txtNombreCliente.ReadOnly = true;
            txtNroDoc.ReadOnly = true;
            txtRuc.ReadOnly = true;
            txtDirec.ReadOnly = true;

            txtDescripcionProd.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            txtPeso.ReadOnly = true;

            txtSubtotal.ReadOnly = true;
            txtImpuesto.ReadOnly = true;
            txtMtoTotal.ReadOnly = true;
            ReadOnlyDescuentoRecargo(true);

            txtCantidad.TextAlign = HorizontalAlignment.Right;
            txtDsctoItem.TextAlign = HorizontalAlignment.Right;
            txtPeso.TextAlign = HorizontalAlignment.Right;
            txtPrecio.TextAlign = HorizontalAlignment.Right;

            txtSubtotal.TextAlign = HorizontalAlignment.Right;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            txtRecargo.TextAlign = HorizontalAlignment.Right;
            txtImpuesto.TextAlign = HorizontalAlignment.Right;
            txtMtoTotal.TextAlign = HorizontalAlignment.Right;
            txtPorcDescuento.TextAlign = HorizontalAlignment.Right;
            txtPorcRecargo.TextAlign = HorizontalAlignment.Right;


            txtCantidad.WaterMark = "0.00";
            txtDsctoItem.WaterMark = "0.00";
            txtPeso.WaterMark = "0.00";
            txtPrecio.WaterMark = "0.00";

            txtSubtotal.WaterMark = "0.00";
            txtDescuento.WaterMark = "0.00";
            txtRecargo.WaterMark = "0.00";
            txtImpuesto.WaterMark = "0.00";
            txtMtoTotal.WaterMark = "0.00";
            txtPorcDescuento.WaterMark = "0.00";
            txtPorcRecargo.WaterMark = "0.00";

            #endregion

            #region Pestaña Medio de Pago

            txtMtoActualMedioPago.ReadOnly = true;
            txtMtoTotalMedioPago.ReadOnly = true;
            txtMtoRestanteMedioPago.ReadOnly = true;

            txtMtoMedioPago.TextAlign = HorizontalAlignment.Right;
            txtMtoActualMedioPago.TextAlign = HorizontalAlignment.Right;
            txtMtoTotalMedioPago.TextAlign = HorizontalAlignment.Right;
            txtMtoRestanteMedioPago.TextAlign = HorizontalAlignment.Right;

            txtMtoMedioPago.WaterMark = "0.00";
            txtMtoActualMedioPago.WaterMark = "0.00";
            txtMtoTotalMedioPago.WaterMark = "0.00";
            txtMtoRestanteMedioPago.WaterMark = "0.00";

            #endregion

            #endregion

            #region ComboBox

            cboUm.Enabled = false;
            cboUm.DropDownWidth = 200;
            cboUm.DropDownHeight = 400;

            cboMedioPago.DropDownWidth = 300;

            #endregion

            #region Grilla
            var detailHeader = new List<TNSt05_comp_emitido_dtl>();
            dgvDetail.DataSource = detailHeader.Select(x => new
            {
                ID_PROD = "",
                PRODUCTO = "",
                CANTIDAD = "",
                PRECIO_UNIT = "",
                DSCTO = "",
                IMPORTE = "",
                OBSERV = ""
            }).ToList();
            DefinirCabeceraGridDetail();
            ControlHelper.ConfigurarGrilla(dgvDetail, 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.Color.DimGray);

            var medioPagoHeader = new List<TNSt07_medio_pago_dtl>();
            dgvMedioPago.DataSource = medioPagoHeader.Select(x => new
            {
                ID_MED_PAGO = "",
                DESC = "",
                MONTO = ""
            }).ToList();
            DefinirCabeceraGridMedioPago();
            ControlHelper.ConfigurarGrilla(dgvMedioPago);

            #endregion

            #region Label

            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");

            #endregion

            #region Check's y Toggle's

            tglPagarTodoPorEfectivo.Checked = true;

            #endregion

            #region Métodos Control

            FechaHora();
            EstablishAction();

            #endregion
        }

        private void CleanCliente()
        {
            txtNombreCliente.Clear();
            txtDirec.Clear();
            txtNroDoc.Clear();
            txtRuc.Clear();
        }

        private void CleanProducto()
        {
            txtCodProd.Clear();
            txtDescripcionProd.Clear();
            txtCantidad.Clear();
            txtDsctoItem.Clear();
            txtPeso.Clear();
            txtPrecio.Clear();
            txtObservItem.Clear();
            cboUm.SelectedIndex = -1;

        }

        private void CleanMtos()
        {
            txtSubtotal.Clear();
            txtImpuesto.Clear();
            txtRecargo.Clear();
            txtDescuento.Clear();
            txtMtoTotal.Clear();
            txtPorcDescuento.Clear();
            txtPorcRecargo.Clear();
        }

        private void CleanMedioPago(bool limpiarListMedioPago = false)
        {
            if (limpiarListMedioPago)
            {
                listMedioPago = null;
                CargarGridMedioPago(listMedioPago);
            }

            txtMtoTotalMedioPago.Clear();
            txtMtoRestanteMedioPago.Clear();
            txtMtoActualMedioPago.Clear();
            txtMtoMedioPago.Clear();
            cboMedioPago.SelectedIndex = cboMedioPago.Items.Count > 0 ? 0 : -1;
        }

        private void CleanAll()
        {
            CleanCliente();
            CleanProducto();
            CleanMedioPago();
        }

        private void ReadOnlyDescuentoRecargo(bool enabled)
        {
            txtPorcDescuento.ReadOnly = enabled;
            txtDescuento.ReadOnly = enabled;
            txtPorcRecargo.ReadOnly = enabled;
            txtRecargo.ReadOnly = enabled;
        }

        private void CargarCombos()
        {
            try
            {
                cboUm.DisplayMember = "txt_desc";
                cboUm.ValueMember = "id_um";
                cboUm.DataSource = new UnidadMedidaBL().ListUnidadMedida(Estado.Activo);

                cboMedioPago.DisplayMember = "txt_desc";
                cboMedioPago.ValueMember = "id_medio_pago";
                cboMedioPago.DataSource = new MedioPagoBL().ListMedioPago(Estado.Activo);

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

        private void EstablishAction()
        {
            if (formAction == FormAction.Edit)
            {
                btnGuardar.Text = "Editar";
                Text = "Editar Comprobante";
            }
        }

        private void FechaHora()
        {
            timerHoraActual.Start();
            timerHoraActual.Interval = 1000;
            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        private void AddMtoMedioPago()
        {
            //validar restante y demás observ
            if (ValidarMtoMedioPago())
            {
                var medioPago = new TNSt07_medio_pago_dtl()
                {
                    id_medio_pago = int.Parse(cboMedioPago.SelectedValue.ToString()),
                    txt_observ = cboMedioPago.GetItemText(cboMedioPago.SelectedItem),
                    monto = decimal.Parse(txtMtoMedioPago.Text)
                };
                if (listMedioPago == null) listMedioPago = new List<TNSt07_medio_pago_dtl>();
                listMedioPago.Add(medioPago);
                CargarGridMedioPago(listMedioPago);
                CalcularMtosMedioDePago();
            }
        }

        private void RemoveMtoMedioPago()
        {

        }


        private void CalcularMontos()
        {
            try
            {
                if (details != null)
                {
                    decimal? subtotal = 0, impuesto = 0, mtoTotal = 0;
                    foreach (var i in details)
                    {
                        subtotal += i.mto_vta_con_igv == 0 ? i.mto_vta_sin_igv : i.mto_vta_con_igv;
                    }
                    impuesto = subtotal * (porcImpuesto / 100.0m);

                    mtoTotal = subtotal + impuesto;

                    if (txtRecargo.Text.Trim() != "" && decimal.TryParse(txtRecargo.Text.Trim(), out decimal recargo))
                        mtoTotal += recargo;

                    if (txtDescuento.Text.Trim() != "" && decimal.TryParse(txtDescuento.Text.Trim(), out decimal descuento))
                        mtoTotal -= descuento;

                    txtSubtotal.Text = subtotal.RoundOut(numDec);
                    txtImpuesto.Text = impuesto.RoundOut(numDec);
                    txtMtoTotal.Text = mtoTotal.RoundOut(numDec);
                    //medio de pago
                    CalcularMtosMedioDePago();
                }
                else
                {
                    CleanMtos();
                    ReadOnlyDescuentoRecargo(true);
                    //medio de pago
                    CleanMedioPago(true);
                    txtMtoMedioPago.Focus();
                }

            }

            catch (Exception e)
            {
                MessageBox.Show("No se pudo calcular los montos. Excepción: " + e.Message, "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CalcularDescuentoRecargo(InputCalculo input)
        {
            decimal mto = 0, impuesto = 0;
            if (txtSubtotal.Text.Trim() != "" && decimal.TryParse(txtSubtotal.Text.Trim(), out decimal subtotal))
            {
                mto = subtotal;
                if (txtImpuesto.Text.Trim() != "" && decimal.TryParse(txtImpuesto.Text.Trim(), out impuesto))
                    mto += impuesto;

                #region Definiendo los txt's y el caso

                bool isPorcentaje = false;
                string estampa = "";
                MetroTextBox txtPorc = new MetroTextBox(), txtMto = new MetroTextBox();
                try
                {
                    switch (input)
                    {
                        case InputCalculo.PorcDescuento:
                            {
                                txtPorc = txtPorcDescuento;
                                txtMto = txtDescuento;
                                isPorcentaje = true;
                                estampa = "descuento";
                            }
                            break;
                        case InputCalculo.PorcRecargo:
                            {
                                txtPorc = txtPorcRecargo;
                                txtMto = txtRecargo;
                                isPorcentaje = true;
                                estampa = "recargo";
                            }
                            break;
                        case InputCalculo.MtoDescuento:
                            {
                                txtPorc = txtPorcDescuento;
                                txtMto = txtDescuento;
                                estampa = "descuento";
                            }
                            break;
                        case InputCalculo.MtoRecargo:
                            {
                                txtPorc = txtPorcRecargo;
                                txtMto = txtRecargo;
                                estampa = "recargo";
                            }
                            break;
                    }
                    #endregion

                    //CÁLCULO POR PORCENTAJE
                    if (isPorcentaje)
                    {
                        decimal porc = 0;
                        if (txtPorc.Text.Trim() == "")
                            txtMto.Clear();
                        else if (decimal.TryParse(txtPorc.Text.Trim(), out porc))
                        {
                            if (porc < 0)
                            {
                                MessageBox.Show($"Ingrese un valor positivo al porcentaje del {estampa}.", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtMto.Clear();
                                txtPorc.SelectAll();
                            }
                            else
                            {
                                decimal mtoCalculado = 0;
                                mtoCalculado = mto * (porc / 100.0m);
                                if (input == InputCalculo.PorcDescuento && mtoCalculado >= mto)
                                {
                                    MessageBox.Show($"El descuento ({mtoCalculado}) no puede ser mayor o igual al monto del subtotal más el impuesto ({mto}).", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtMto.Clear();
                                    txtPorc.SelectAll();
                                }
                                else
                                {
                                    txtMto.Text = mtoCalculado.RoundOut(numDec);
                                    CalcularMontos();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Ingrese un valor numérico en el porcentaje del {estampa}.", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMto.Clear();
                            txtPorc.SelectAll();
                        }

                    }
                    else//CÁLCULO POR MONTO
                    {
                        decimal mtoPropuesto = 0;
                        if (txtMto.Text.Trim() == "")
                            txtPorc.Clear();
                        else if ((decimal.TryParse(txtMto.Text.Trim(), out mtoPropuesto)))
                        {
                            if (mtoPropuesto < 0)
                            {
                                MessageBox.Show($"Ingrese un valor positivo al monto del {estampa}.", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtPorc.Clear();
                                txtMto.SelectAll();
                            }
                            else
                            {
                                decimal porcCalculado = (mtoPropuesto / mto) * 100.0m;
                                if (input == InputCalculo.MtoDescuento && mtoPropuesto >= mto)
                                {
                                    MessageBox.Show($"El descuento ({mtoPropuesto}) no puede ser mayor o igual al monto del subtotal más el impuesto ({mto}).", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtPorc.Clear();
                                    txtMto.Clear();
                                    txtMto.Focus();
                                }
                                else
                                {
                                    txtPorc.Text = porcCalculado.RoundOut(numDec);
                                    CalcularMontos();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Ingrese un valor numérico en el monto del {estampa}.", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPorc.Clear();
                            txtMto.SelectAll();
                        }
                    }
                }
                catch (Exception e)
                {
                    if (isPorcentaje) txtMto.Clear();
                    else
                        txtPorc.Clear();
                    MessageBox.Show($"No se pudo calcular el {estampa}. Excepción: " + e.Message, "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarGridProd(IEnumerable<TNSt05_comp_emitido_dtl> list)
        {
            if (list != null)
            {
                dgvDetail.DataSource = list.Select(x => new
                {
                    ID_PROD = x.id_producto,
                    PRODUCTO = x.txt_producto,
                    CANTIDAD = x.qt_venta.RoundOut(numDec),
                    PRECIO_UNIT = x.punit_con_igv == 0 ? x.punit_sin_igv.RoundOut(numDec) : x.punit_con_igv.RoundOut(numDec),
                    DSCTO = x.punit_dscto_con_igv == 0 ? x.punit_dscto_sin_igv.RoundOut(numDec) : x.punit_dscto_con_igv.RoundOut(numDec),
                    IMPORTE = x.mto_vta_con_igv == 0 ? x.mto_vta_sin_igv.RoundOut(numDec) : x.mto_vta_con_igv.RoundOut(numDec),
                    OBSERV = x.txt_observ
                }).ToList();

            }
            else
            {
                var detailHeader = new List<TNSt05_comp_emitido_dtl>();
                dgvDetail.DataSource = detailHeader.Select(x => new
                {
                    ID_PROD = "",
                    PRODUCTO = "",
                    CANTIDAD = "",
                    PRECIO_UNIT = "",
                    DSCTO = "",
                    IMPORTE = "",
                    OBSERV = ""
                }).ToList();
            }
            DefinirCabeceraGridDetail();
        }

        private void CargarGridMedioPago(IEnumerable<TNSt07_medio_pago_dtl> list)
        {
            if (list != null)
            {
                dgvMedioPago.DataSource = list.Select(x => new
                {
                    ID_MED_PAGO = x.id_medio_pago,
                    DESC = x.txt_observ,
                    MONTO = x.monto
                }).ToList();

            }
            else
            {
                var medioPagoHeader = new List<TNSt07_medio_pago_dtl>();
                dgvMedioPago.DataSource = medioPagoHeader.Select(x => new
                {
                    ID_MED_PAGO = "",
                    DESC = "",
                    MONTO = ""
                }).ToList();
            }
            DefinirCabeceraGridMedioPago();
        }

        private void SetProducto(PROt09_producto producto)
        {
            try
            {
                prod = new PROt09_producto();
                prod = producto;

                txtCodProd.Text = producto.cod_producto;
                txtDescripcionProd.Text = producto.txt_desc;
                txtPeso.Text = producto.peso_prod;
                if (producto.mto_pvpu_con_igv != null)
                    txtPrecio.Text = producto.mto_pvpu_con_igv.RoundOut(numDec);
                else
                {
                    if (producto.mto_pvpu_sin_igv != null)
                        txtPrecio.Text = producto.mto_pvpu_sin_igv.RoundOut(numDec);
                    else txtPrecio.Text = "";
                }
                cboUm.SelectedValue = producto.id_um ?? -1;
                txtCantidad.Focus();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo setear el producto. Excepción: " + e.Message, "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetCliente(PERt02_cliente cliente, string codTipoSujeto)
        {
            idCliente = cliente.id_cliente;
            this.codTipoSujeto = codTipoSujeto;
            txtNombreCliente.Text = cliente.txt_pri_nom;
            txtNroDoc.Text = cliente.nro_doc;
            txtRuc.Text = cliente.nro_ruc;
            txtDirec.Text = PersonHelper.GetDireccion(cliente.txt_direccion1, cliente.txt_direccion2);
        }

        private TNSt05_comp_emitido_dtl GetProducto()
        {
            try
            {
                var detailItem = new TNSt05_comp_emitido_dtl()
                {
                    id_producto = prod.id_producto,
                    txt_producto = txtDescripcionProd.Text.Trim(),
                    txt_observ = txtObservItem.Text.Trim()
                };
                if (cboUm.SelectedValue != null) detailItem.id_um = int.Parse(cboUm.SelectedValue.ToString());

                detailItem.qt_venta = decimal.Parse(txtCantidad.Text.Trim());
                detailItem.peso = (txtPeso.Text.Trim() == "") ? 0 : decimal.Parse(txtPeso.Text.Trim());

                //producto sin IGV
                if (prod.mto_pvpu_con_igv == null && prod.mto_pvpu_sin_igv != null)
                {
                    detailItem.punit_sin_igv = decimal.Parse(prod.mto_pvpu_sin_igv.ToString());
                    detailItem.punit_dscto_sin_igv = (txtDsctoItem.Text.Trim() == "") ? 0 : decimal.Parse(txtDsctoItem.Text.Trim());
                }
                //Producto con IGV
                else if (prod.por_impto != null && prod.mto_pvpu_con_igv != null && prod.mto_pvpu_sin_igv != null)
                {
                    detailItem.punit_con_igv = decimal.Parse(prod.mto_pvpu_con_igv.ToString());
                    detailItem.punit_dscto_con_igv = (txtDsctoItem.Text.Trim() == "") ? 0 : decimal.Parse(txtDsctoItem.Text.Trim());

                    detailItem.punit_sin_igv = decimal.Parse(prod.mto_pvpu_sin_igv.ToString());
                    detailItem.punit_dscto_sin_igv = detailItem.punit_dscto_con_igv / (1 + ((decimal)prod.por_impto / 100));
                }

                detailItem.mto_vta_con_igv = (detailItem.punit_con_igv * detailItem.qt_venta) - detailItem.punit_dscto_con_igv;
                detailItem.mto_vta_sin_igv = (detailItem.punit_sin_igv * detailItem.qt_venta) - detailItem.punit_dscto_sin_igv;

                return detailItem;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo obtener el producto. Excepción: " + e.Message, "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private bool BuscarProducto()
        {
            string codProd = txtCodProd.Text.Trim();
            //Si está vació el txt -> abre el form
            if (codProd == "")
                return false;

            //De lo contrario hace la búsqueda del producto
            var list = new ProductoBL().BuscarProducto(codProd, "", "", Estado.Activo, 99, Estado.Activo);
            //Si solo hay un producto con ese filtro
            if (list != null && list.Count() == 1)
            {
                foreach (var i in list)
                {
                    //Si el prouducto encontrado es distinto al prouducto ya cargado -> carga prod y no abre form
                    if (prod == null || i.id_producto != prod.id_producto)
                    {
                        CleanProducto();
                        SetProducto(i);
                        return true;
                    }
                }
                //Si el producto encontrado es el mismo que el que ya estaba cargado -> abre from
                return false;
            }
            //si no hay ningún producto con esa característica o hay más de uno -> abre form
            else
                return false;
        }

        private bool ValidarProducto()
        {
            decimal dscto = -1;

            if ((prod != null && prod.id_producto > 0) &&
                (decimal.TryParse(txtCantidad.Text.Trim(), out decimal cantidad)) &&
                (txtDsctoItem.Text.Trim() == "" || decimal.TryParse(txtDsctoItem.Text.Trim(), out dscto)) &&
                (txtPeso.Text.Trim() == "" || decimal.TryParse(txtPeso.Text.Trim(), out decimal x)) &&
                (decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio)) &&
                (txtDescripcionProd.Text.Trim().Length > 0))
            {
                //Si no hay descuento
                if (dscto == -1)
                    return true;
                else
                {
                    //Si existe descuento, asegurarse de que no sea mayor o igual al importe
                    if (cantidad * precio > 0 && cantidad * precio > dscto)
                        return true;
                    else return false;

                }

            }
            else return false;
        }

        private bool ValidarMtoMedioPago()
        {
            if (decimal.TryParse(txtMtoTotal.Text, out decimal mtoTotal) && mtoTotal > 0)
            {
                if (cboMedioPago.SelectedValue != null && int.TryParse(cboMedioPago.SelectedValue.ToString(), out int id))
                {
                    if (decimal.TryParse(txtMtoMedioPago.Text.Trim(), out decimal mtoMedioPago) && mtoMedioPago > 0)
                    {
                        //si el monto restante es "" o 0 (significa que ya completó el monto total)
                        if (txtMtoRestanteMedioPago.Text.Trim() != "" &&
    decimal.TryParse(txtMtoRestanteMedioPago.Text, out decimal mtoRestante) &&
    mtoRestante > 0)
                        {
                            if (mtoMedioPago <= mtoRestante)
                                return true;
                            else
                                MessageBox.Show($"El monto ingresado ({mtoMedioPago}) no puede mayor al monto restante ({mtoRestante}).", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("No puede agregar más montos. Ya se completó el monto total.", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show("El monto debe ser un número positivo.", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (txtMtoMedioPago.Text.Length > 0)
                    { txtMtoMedioPago.SelectAll(); txtMtoMedioPago.Focus(); }
                    else
                        txtMtoMedioPago.Focus();
                    return false;

                }
                else
                {
                    MessageBox.Show("Seleccione un medio pago.", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMedioPago.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No hay ningún monto por el cual realizar pagos.", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtMtoMedioPago.Text.Length > 0)
                { txtMtoMedioPago.SelectAll(); txtMtoMedioPago.Focus(); }
                else
                    txtMtoMedioPago.Focus();
                return false;
            }
        }

        private void RemoveItem()
        {
            int id = 0;
            try
            {
                //comprobante y obteniendo el id del producto
                if (dgvDetail.CurrentRow != null &&
                dgvDetail.SelectedRows.Count > 0 &&
                details != null &&
                int.TryParse(dgvDetail.SelectedRows[0].Cells[0].Value.ToString(), out id))
                {
                    string item = dgvDetail.SelectedRows[0].Cells[1].Value != null ? dgvDetail.SelectedRows[0].Cells[1].Value.ToString() : "";

                    if (MessageBox.Show($"¿Está seguro eliminar el item '{item}'?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        int index = details.FindIndex(x => x.id_producto == id);
                        if (index != -1)
                        {
                            details.RemoveAt(index);
                            if (details.Count == 0) details = null;
                            CargarGridProd(details);
                            CalcularMontos();
                            CalcularDescuentoRecargo(InputCalculo.PorcDescuento);
                            CalcularDescuentoRecargo(InputCalculo.PorcRecargo);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo eliminar el item correctamente. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvDetail.Focus();
            }

        }

        private void AddItem()
        {
            if (details == null || details.Count < maxNumItems)
            {
                if (ValidarProducto())
                {
                    var item = GetProducto();
                    if (item != null)
                    {
                        if (details == null) details = new List<TNSt05_comp_emitido_dtl>();
                        if (details != null)
                        {

                            try
                            {
                                var index = details.FindIndex(x => x.id_producto == item.id_producto);
                                //Si el producto ya existe en el detalle -> edita item
                                if (index != -1)
                                {
                                    var oldItem = details[index];

                                    item.qt_venta += oldItem.qt_venta;

                                    item.punit_dscto_con_igv += oldItem.punit_dscto_con_igv;
                                    item.punit_dscto_sin_igv += oldItem.punit_dscto_sin_igv;

                                    item.mto_vta_con_igv += oldItem.mto_vta_con_igv;
                                    item.mto_vta_sin_igv += oldItem.mto_vta_sin_igv;

                                    item.txt_observ = oldItem.txt_observ == "" ? item.txt_observ : string.Format("{0} | {1}", item.txt_observ, oldItem.txt_observ);

                                    details[index] = item;
                                }
                                //Si el producto no existe en el detalle -> agrega item
                                else
                                    details.Add(item);

                                CargarGridProd(details);
                                if (dgvDetail.Rows.Count > 0) ReadOnlyDescuentoRecargo(false);
                                CalcularMontos();
                                CalcularDescuentoRecargo(InputCalculo.PorcDescuento);
                                CalcularDescuentoRecargo(InputCalculo.PorcRecargo);
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show($"No se pudo agregar el item correctamente. Excepción: {e}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                prod = null;
                                CleanProducto();
                                txtCodProd.Focus();
                            }

                        }

                    }
                }
                else
                    MessageBox.Show("Ingrese valores válidos para el producto.", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show($"No puede agregar más items. Ha alcanzado el número máximo de items({maxNumItems}).", "Mensaje Eagle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DefinirCabeceraGridDetail()
        {
            try
            {
                dgvDetail.Columns["ID_PROD"].Visible = false;

                dgvDetail.Columns["CANTIDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetail.Columns["CANTIDAD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvDetail.Columns["PRECIO_UNIT"].HeaderText = "P. UNIT.";
                dgvDetail.Columns["PRECIO_UNIT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetail.Columns["PRECIO_UNIT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvDetail.Columns["DSCTO"].HeaderText = "DSCTO.";
                dgvDetail.Columns["DSCTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetail.Columns["DSCTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


                dgvDetail.Columns["IMPORTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDetail.Columns["IMPORTE"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvDetail.Columns["OBSERV"].HeaderText = "OBSERVACIÓN";

                dgvDetail.Columns["PRODUCTO"].Width = 250;
                dgvDetail.Columns["OBSERV"].Width = 250;
            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla de productos. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DefinirCabeceraGridMedioPago()
        {
            try
            {
                dgvMedioPago.Columns["ID_MED_PAGO"].Visible = false;

                dgvMedioPago.Columns["MONTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvMedioPago.Columns["MONTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvMedioPago.Columns["DESC"].HeaderText = "MEDIO DE PAGO";

                dgvMedioPago.Columns["MONTO"].Width = 100;
                dgvMedioPago.Columns["DESC"].Width = 199;

            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla de productos. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToggleTodoPorEfectivo()
        {
            if (tglPagarTodoPorEfectivo.Checked)
            {
                cboMedioPago.Enabled = false;
                txtMtoMedioPago.Enabled = false;
                btnAddMtoMedioPago.Enabled = false;
                btnDeleteMtoMedioPago.Enabled = false;
                dgvMedioPago.Enabled = false;
                cboMedioPago.Focus();
            }
            else
            {
                cboMedioPago.Enabled = true;
                txtMtoMedioPago.Enabled = true;
                btnAddMtoMedioPago.Enabled = true;
                btnDeleteMtoMedioPago.Enabled = true;
                dgvMedioPago.Enabled = true;
            }
        }

        private void CalcularMtosMedioDePago()
        {
            if (decimal.TryParse(txtMtoTotal.Text, out decimal mtoTotal) && mtoTotal > 0)
            {
                decimal? mtoActual = 0;
                //Calculando el mto de actual
                if (listMedioPago != null && listMedioPago.Count > 0)
                {
                    mtoActual = listMedioPago.Sum(x => x.monto);
                }
                mtoActual = (mtoActual ?? 0);
                decimal mtoRestante = mtoTotal - (decimal)mtoActual;

                //El mto Restante será negativo cuando se haya llenado el medio de pago y después se haya eliminado
                //algunos items de la venta, en esta situación el mto actual será mayor que el total. En este caso:
                /*
                 Opción 1: Resetear la grilla de medio de pago para su llenado.
                 Opción 2: Quedarán los montos con la incosistencia pero no dejará grabar hasta que se el usuario corrija
                            (Se le mostrará un mensaje para que corrija)
                 */
                if (mtoRestante < 0)
                {
                    listMedioPago = null;
                    CargarGridMedioPago(listMedioPago);
                    txtMtoRestanteMedioPago.Text = mtoTotal.RoundOut(numDec);
                    txtMtoActualMedioPago.Text = "";
                }
                else
                {
                    txtMtoActualMedioPago.Text = mtoActual > 0 ? mtoActual.RoundOut(numDec) : "";
                    txtMtoRestanteMedioPago.Text = mtoRestante > 0 ? mtoRestante.RoundOut(numDec) : "";
                }
                txtMtoTotalMedioPago.Text = mtoTotal.RoundOut(numDec);
            }
            //En caso no sea texto número positivo limpiará los demás txt's porque de este depende los demás (actual y restante)
            else
            {
                txtMtoTotalMedioPago.Clear();
                txtMtoRestanteMedioPago.Clear();
                txtMtoActualMedioPago.Clear();
            }
        }

        private void SetInicio()
        {
            ConfigurarControles();
            AddHandlers();
            CargarCombos();

            cboUm.SelectedIndex = -1;
            cboMedioPago.SelectedIndex = cboMedioPago.Items.Count > 0 ? 0 : -1;
            cboTipoComprobante.SelectedIndex = cboTipoComprobante.Items.Count > 0 ? 0 : -1;
            txtNombreCliente.Focus();
        }

        #endregion

        #region Eventos

        #region General
        private void FormAddEditCompEmitido_Load(object sender, EventArgs e)
        {
            SetInicio();
        }

        #region Descuento y recargo

        private void txtPorcDescuento_TextChanged(object sender, EventArgs e)
        {

            txtDescuento.TextChanged -= txtDescuento_TextChanged;
            txtPorcDescuento.TextChanged -= txtPorcDescuento_TextChanged;
            CalcularDescuentoRecargo(InputCalculo.PorcDescuento);
            txtPorcDescuento.TextChanged += txtPorcDescuento_TextChanged;
            txtDescuento.TextChanged += txtDescuento_TextChanged;
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            txtPorcDescuento.TextChanged -= txtPorcDescuento_TextChanged;
            txtDescuento.TextChanged -= txtDescuento_TextChanged;
            CalcularDescuentoRecargo(InputCalculo.MtoDescuento);
            txtDescuento.TextChanged += txtDescuento_TextChanged;
            txtPorcDescuento.TextChanged += txtPorcDescuento_TextChanged;
        }

        private void txtPorcRecargo_TextChanged(object sender, EventArgs e)
        {
            txtRecargo.TextChanged -= txtRecargo_TextChanged;
            txtPorcRecargo.TextChanged -= txtPorcRecargo_TextChanged;
            CalcularDescuentoRecargo(InputCalculo.PorcRecargo);
            txtPorcRecargo.TextChanged += txtPorcRecargo_TextChanged;
            txtRecargo.TextChanged += txtRecargo_TextChanged;
        }

        private void txtRecargo_TextChanged(object sender, EventArgs e)
        {
            txtPorcRecargo.TextChanged -= txtPorcRecargo_TextChanged;
            txtRecargo.TextChanged -= txtRecargo_TextChanged;
            CalcularDescuentoRecargo(InputCalculo.MtoRecargo);
            txtRecargo.TextChanged += txtRecargo_TextChanged;
            txtPorcRecargo.TextChanged += txtPorcRecargo_TextChanged;
        }
        #endregion

        private void timerHoraActual_Tick(object sender, EventArgs e)
        {
            lblFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
                Opacity += 0.25;
            else
                timerFade.Tick -= timerFade_Tick;
        }
        #endregion

        #region Pestaña principal

        private void txtCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                if (!BuscarProducto())
                {
                    var form = new FormBuscarProducto();
                    form.ShowDialog();
                    if (form.producto != null)
                    {
                        CleanProducto();
                        SetProducto(form.producto);
                    }

                }

            }
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                var form = new FormBuscarCliente();
                form.ShowDialog();
                if (form.cliente != null)
                {
                    CleanCliente();
                    SetCliente(form.cliente, form.codTipoSujeto);
                    txtCodProd.Focus();
                }

            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void dgvDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.E)
            {
                RemoveItem();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                AddItem();
            }

        }

        private void txtDsctoItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                AddItem();
            }
        }

        private void txtObservItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                AddItem();
            }
        }

        #endregion

        #region Pestaña medio de pago

        private void tglPagarTodoPorEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            ToggleTodoPorEfectivo();
        }

        private void btnAddMtoMedioPago_Click(object sender, EventArgs e)
        {
            AddMtoMedioPago();
        }

        private void btnDeleteMtoMedioPago_Click(object sender, EventArgs e)
        {

        }

        private void txtMtoMedioPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                AddMtoMedioPago();
            }
        }

        #endregion

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMtoTotal.Text, out decimal mto) && mto > 0)
                new FormMedioDePagoDtl(mto).ShowDialog();
            else
                MessageBox.Show("Al menos debe agregar un item", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}

