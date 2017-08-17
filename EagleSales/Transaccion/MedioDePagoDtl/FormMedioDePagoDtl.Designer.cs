namespace EagleSales.Transaccion.MedioDePagoDtl
{
    partial class FormMedioDePagoDtl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMedioDePagoDtl = new MetroFramework.Controls.MetroTabControl();
            this.tabPagPrincipal = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPagOtros = new MetroFramework.Controls.MetroTabPage();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblTipoDeCambio = new MetroFramework.Controls.MetroLabel();
            this.txtTipoDeCambio = new MetroFramework.Controls.MetroTextBox();
            this.cboMoneda = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.txtMtoActualMedioPago = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.txtMtoRestanteMedioPago = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.txtMtoTotalMedioPago = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.btnDeleteMtoMedioPago = new System.Windows.Forms.Button();
            this.btnAddMtoMedioPago = new System.Windows.Forms.Button();
            this.dgvMedioPago = new System.Windows.Forms.DataGridView();
            this.txtMtoMedioPago = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.cboMedioDePago = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.lblMtoTotal = new System.Windows.Forms.Label();
            this.tabMedioDePagoDtl.SuspendLayout();
            this.tabPagPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPagOtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedioPago)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMedioDePagoDtl
            // 
            this.tabMedioDePagoDtl.Controls.Add(this.tabPagPrincipal);
            this.tabMedioDePagoDtl.Controls.Add(this.tabPagOtros);
            this.tabMedioDePagoDtl.Location = new System.Drawing.Point(23, 63);
            this.tabMedioDePagoDtl.Name = "tabMedioDePagoDtl";
            this.tabMedioDePagoDtl.SelectedIndex = 0;
            this.tabMedioDePagoDtl.Size = new System.Drawing.Size(835, 310);
            this.tabMedioDePagoDtl.TabIndex = 56;
            this.tabMedioDePagoDtl.UseSelectable = true;
            // 
            // tabPagPrincipal
            // 
            this.tabPagPrincipal.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPagPrincipal.Controls.Add(this.panel1);
            this.tabPagPrincipal.HorizontalScrollbarBarColor = true;
            this.tabPagPrincipal.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagPrincipal.HorizontalScrollbarSize = 10;
            this.tabPagPrincipal.Location = new System.Drawing.Point(4, 38);
            this.tabPagPrincipal.Name = "tabPagPrincipal";
            this.tabPagPrincipal.Size = new System.Drawing.Size(827, 268);
            this.tabPagPrincipal.TabIndex = 0;
            this.tabPagPrincipal.Text = "Medios de pago rápido";
            this.tabPagPrincipal.UseCustomBackColor = true;
            this.tabPagPrincipal.VerticalScrollbarBarColor = true;
            this.tabPagPrincipal.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagPrincipal.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 240);
            this.panel1.TabIndex = 57;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(281, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(198, 92);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tabPagOtros
            // 
            this.tabPagOtros.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPagOtros.Controls.Add(this.btnCargar);
            this.tabPagOtros.Controls.Add(this.lblTipoDeCambio);
            this.tabPagOtros.Controls.Add(this.txtTipoDeCambio);
            this.tabPagOtros.Controls.Add(this.cboMoneda);
            this.tabPagOtros.Controls.Add(this.metroLabel25);
            this.tabPagOtros.Controls.Add(this.txtMtoActualMedioPago);
            this.tabPagOtros.Controls.Add(this.metroLabel18);
            this.tabPagOtros.Controls.Add(this.txtMtoRestanteMedioPago);
            this.tabPagOtros.Controls.Add(this.metroLabel17);
            this.tabPagOtros.Controls.Add(this.txtMtoTotalMedioPago);
            this.tabPagOtros.Controls.Add(this.metroLabel16);
            this.tabPagOtros.Controls.Add(this.btnDeleteMtoMedioPago);
            this.tabPagOtros.Controls.Add(this.btnAddMtoMedioPago);
            this.tabPagOtros.Controls.Add(this.dgvMedioPago);
            this.tabPagOtros.Controls.Add(this.txtMtoMedioPago);
            this.tabPagOtros.Controls.Add(this.metroLabel14);
            this.tabPagOtros.Controls.Add(this.cboMedioDePago);
            this.tabPagOtros.Controls.Add(this.metroLabel13);
            this.tabPagOtros.HorizontalScrollbarBarColor = true;
            this.tabPagOtros.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagOtros.HorizontalScrollbarSize = 10;
            this.tabPagOtros.Location = new System.Drawing.Point(4, 38);
            this.tabPagOtros.Name = "tabPagOtros";
            this.tabPagOtros.Size = new System.Drawing.Size(827, 268);
            this.tabPagOtros.TabIndex = 1;
            this.tabPagOtros.Text = "Otros medios";
            this.tabPagOtros.UseCustomBackColor = true;
            this.tabPagOtros.VerticalScrollbarBarColor = true;
            this.tabPagOtros.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagOtros.VerticalScrollbarSize = 10;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(629, 224);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(182, 32);
            this.btnCargar.TabIndex = 81;
            this.btnCargar.Text = "Grabar";
            this.btnCargar.UseVisualStyleBackColor = false;
            // 
            // lblTipoDeCambio
            // 
            this.lblTipoDeCambio.AutoSize = true;
            this.lblTipoDeCambio.Location = new System.Drawing.Point(497, 10);
            this.lblTipoDeCambio.Name = "lblTipoDeCambio";
            this.lblTipoDeCambio.Size = new System.Drawing.Size(102, 19);
            this.lblTipoDeCambio.TabIndex = 80;
            this.lblTipoDeCambio.Text = "Tipo de cambio";
            this.lblTipoDeCambio.UseCustomBackColor = true;
            // 
            // txtTipoDeCambio
            // 
            // 
            // 
            // 
            this.txtTipoDeCambio.CustomButton.Image = null;
            this.txtTipoDeCambio.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.txtTipoDeCambio.CustomButton.Name = "";
            this.txtTipoDeCambio.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTipoDeCambio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTipoDeCambio.CustomButton.TabIndex = 1;
            this.txtTipoDeCambio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTipoDeCambio.CustomButton.UseSelectable = true;
            this.txtTipoDeCambio.CustomButton.Visible = false;
            this.txtTipoDeCambio.Lines = new string[0];
            this.txtTipoDeCambio.Location = new System.Drawing.Point(497, 32);
            this.txtTipoDeCambio.MaxLength = 32767;
            this.txtTipoDeCambio.Name = "txtTipoDeCambio";
            this.txtTipoDeCambio.PasswordChar = '\0';
            this.txtTipoDeCambio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTipoDeCambio.SelectedText = "";
            this.txtTipoDeCambio.SelectionLength = 0;
            this.txtTipoDeCambio.SelectionStart = 0;
            this.txtTipoDeCambio.ShortcutsEnabled = true;
            this.txtTipoDeCambio.Size = new System.Drawing.Size(117, 25);
            this.txtTipoDeCambio.TabIndex = 79;
            this.txtTipoDeCambio.UseSelectable = true;
            this.txtTipoDeCambio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTipoDeCambio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboMoneda
            // 
            this.cboMoneda.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.ItemHeight = 19;
            this.cboMoneda.Location = new System.Drawing.Point(337, 32);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(154, 25);
            this.cboMoneda.TabIndex = 78;
            this.cboMoneda.UseSelectable = true;
            this.cboMoneda.UseStyleColors = true;
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel25.Location = new System.Drawing.Point(629, 101);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(179, 19);
            this.metroLabel25.TabIndex = 77;
            this.metroLabel25.Text = "Montos del comprobante";
            this.metroLabel25.UseCustomBackColor = true;
            // 
            // txtMtoActualMedioPago
            // 
            // 
            // 
            // 
            this.txtMtoActualMedioPago.CustomButton.Image = null;
            this.txtMtoActualMedioPago.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtMtoActualMedioPago.CustomButton.Name = "";
            this.txtMtoActualMedioPago.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMtoActualMedioPago.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMtoActualMedioPago.CustomButton.TabIndex = 1;
            this.txtMtoActualMedioPago.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMtoActualMedioPago.CustomButton.UseSelectable = true;
            this.txtMtoActualMedioPago.CustomButton.Visible = false;
            this.txtMtoActualMedioPago.Lines = new string[0];
            this.txtMtoActualMedioPago.Location = new System.Drawing.Point(693, 128);
            this.txtMtoActualMedioPago.MaxLength = 32767;
            this.txtMtoActualMedioPago.Name = "txtMtoActualMedioPago";
            this.txtMtoActualMedioPago.PasswordChar = '\0';
            this.txtMtoActualMedioPago.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMtoActualMedioPago.SelectedText = "";
            this.txtMtoActualMedioPago.SelectionLength = 0;
            this.txtMtoActualMedioPago.SelectionStart = 0;
            this.txtMtoActualMedioPago.ShortcutsEnabled = true;
            this.txtMtoActualMedioPago.Size = new System.Drawing.Size(118, 23);
            this.txtMtoActualMedioPago.TabIndex = 7;
            this.txtMtoActualMedioPago.UseSelectable = true;
            this.txtMtoActualMedioPago.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMtoActualMedioPago.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(629, 130);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(48, 19);
            this.metroLabel18.TabIndex = 75;
            this.metroLabel18.Text = "Actual:";
            this.metroLabel18.UseCustomBackColor = true;
            // 
            // txtMtoRestanteMedioPago
            // 
            // 
            // 
            // 
            this.txtMtoRestanteMedioPago.CustomButton.Image = null;
            this.txtMtoRestanteMedioPago.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtMtoRestanteMedioPago.CustomButton.Name = "";
            this.txtMtoRestanteMedioPago.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMtoRestanteMedioPago.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMtoRestanteMedioPago.CustomButton.TabIndex = 1;
            this.txtMtoRestanteMedioPago.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMtoRestanteMedioPago.CustomButton.UseSelectable = true;
            this.txtMtoRestanteMedioPago.CustomButton.Visible = false;
            this.txtMtoRestanteMedioPago.Lines = new string[0];
            this.txtMtoRestanteMedioPago.Location = new System.Drawing.Point(693, 157);
            this.txtMtoRestanteMedioPago.MaxLength = 32767;
            this.txtMtoRestanteMedioPago.Name = "txtMtoRestanteMedioPago";
            this.txtMtoRestanteMedioPago.PasswordChar = '\0';
            this.txtMtoRestanteMedioPago.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMtoRestanteMedioPago.SelectedText = "";
            this.txtMtoRestanteMedioPago.SelectionLength = 0;
            this.txtMtoRestanteMedioPago.SelectionStart = 0;
            this.txtMtoRestanteMedioPago.ShortcutsEnabled = true;
            this.txtMtoRestanteMedioPago.Size = new System.Drawing.Size(118, 23);
            this.txtMtoRestanteMedioPago.TabIndex = 8;
            this.txtMtoRestanteMedioPago.UseSelectable = true;
            this.txtMtoRestanteMedioPago.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMtoRestanteMedioPago.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(629, 159);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(61, 19);
            this.metroLabel17.TabIndex = 73;
            this.metroLabel17.Text = "Restante:";
            this.metroLabel17.UseCustomBackColor = true;
            // 
            // txtMtoTotalMedioPago
            // 
            // 
            // 
            // 
            this.txtMtoTotalMedioPago.CustomButton.Image = null;
            this.txtMtoTotalMedioPago.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtMtoTotalMedioPago.CustomButton.Name = "";
            this.txtMtoTotalMedioPago.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMtoTotalMedioPago.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMtoTotalMedioPago.CustomButton.TabIndex = 1;
            this.txtMtoTotalMedioPago.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMtoTotalMedioPago.CustomButton.UseSelectable = true;
            this.txtMtoTotalMedioPago.CustomButton.Visible = false;
            this.txtMtoTotalMedioPago.Lines = new string[0];
            this.txtMtoTotalMedioPago.Location = new System.Drawing.Point(693, 186);
            this.txtMtoTotalMedioPago.MaxLength = 32767;
            this.txtMtoTotalMedioPago.Name = "txtMtoTotalMedioPago";
            this.txtMtoTotalMedioPago.PasswordChar = '\0';
            this.txtMtoTotalMedioPago.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMtoTotalMedioPago.SelectedText = "";
            this.txtMtoTotalMedioPago.SelectionLength = 0;
            this.txtMtoTotalMedioPago.SelectionStart = 0;
            this.txtMtoTotalMedioPago.ShortcutsEnabled = true;
            this.txtMtoTotalMedioPago.Size = new System.Drawing.Size(118, 23);
            this.txtMtoTotalMedioPago.TabIndex = 9;
            this.txtMtoTotalMedioPago.UseSelectable = true;
            this.txtMtoTotalMedioPago.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMtoTotalMedioPago.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(629, 188);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(39, 19);
            this.metroLabel16.TabIndex = 71;
            this.metroLabel16.Text = "Total:";
            this.metroLabel16.UseCustomBackColor = true;
            // 
            // btnDeleteMtoMedioPago
            // 
            this.btnDeleteMtoMedioPago.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteMtoMedioPago.FlatAppearance.BorderSize = 0;
            this.btnDeleteMtoMedioPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMtoMedioPago.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMtoMedioPago.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMtoMedioPago.Image = global::EagleSales.Properties.Resources.delete_white_x24;
            this.btnDeleteMtoMedioPago.Location = new System.Drawing.Point(679, 18);
            this.btnDeleteMtoMedioPago.Name = "btnDeleteMtoMedioPago";
            this.btnDeleteMtoMedioPago.Size = new System.Drawing.Size(44, 39);
            this.btnDeleteMtoMedioPago.TabIndex = 6;
            this.btnDeleteMtoMedioPago.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteMtoMedioPago.UseVisualStyleBackColor = false;
            // 
            // btnAddMtoMedioPago
            // 
            this.btnAddMtoMedioPago.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddMtoMedioPago.FlatAppearance.BorderSize = 0;
            this.btnAddMtoMedioPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMtoMedioPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMtoMedioPago.ForeColor = System.Drawing.Color.White;
            this.btnAddMtoMedioPago.Image = global::EagleSales.Properties.Resources.plus_circle_white_x24;
            this.btnAddMtoMedioPago.Location = new System.Drawing.Point(629, 18);
            this.btnAddMtoMedioPago.Name = "btnAddMtoMedioPago";
            this.btnAddMtoMedioPago.Size = new System.Drawing.Size(44, 39);
            this.btnAddMtoMedioPago.TabIndex = 5;
            this.btnAddMtoMedioPago.UseVisualStyleBackColor = false;
            this.btnAddMtoMedioPago.Click += new System.EventHandler(this.btnAddMtoMedioPago_Click);
            // 
            // dgvMedioPago
            // 
            this.dgvMedioPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedioPago.Location = new System.Drawing.Point(13, 75);
            this.dgvMedioPago.Name = "dgvMedioPago";
            this.dgvMedioPago.Size = new System.Drawing.Size(601, 181);
            this.dgvMedioPago.TabIndex = 2;
            // 
            // txtMtoMedioPago
            // 
            // 
            // 
            // 
            this.txtMtoMedioPago.CustomButton.Image = null;
            this.txtMtoMedioPago.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtMtoMedioPago.CustomButton.Name = "";
            this.txtMtoMedioPago.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMtoMedioPago.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMtoMedioPago.CustomButton.TabIndex = 1;
            this.txtMtoMedioPago.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMtoMedioPago.CustomButton.UseSelectable = true;
            this.txtMtoMedioPago.CustomButton.Visible = false;
            this.txtMtoMedioPago.Lines = new string[0];
            this.txtMtoMedioPago.Location = new System.Drawing.Point(210, 32);
            this.txtMtoMedioPago.MaxLength = 32767;
            this.txtMtoMedioPago.Name = "txtMtoMedioPago";
            this.txtMtoMedioPago.PasswordChar = '\0';
            this.txtMtoMedioPago.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMtoMedioPago.SelectedText = "";
            this.txtMtoMedioPago.SelectionLength = 0;
            this.txtMtoMedioPago.SelectionStart = 0;
            this.txtMtoMedioPago.ShortcutsEnabled = true;
            this.txtMtoMedioPago.Size = new System.Drawing.Size(128, 25);
            this.txtMtoMedioPago.TabIndex = 4;
            this.txtMtoMedioPago.UseSelectable = true;
            this.txtMtoMedioPago.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMtoMedioPago.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(210, 10);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(48, 19);
            this.metroLabel14.TabIndex = 3;
            this.metroLabel14.Text = "Monto";
            this.metroLabel14.UseCustomBackColor = true;
            // 
            // cboMedioDePago
            // 
            this.cboMedioDePago.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboMedioDePago.FormattingEnabled = true;
            this.cboMedioDePago.ItemHeight = 19;
            this.cboMedioDePago.Location = new System.Drawing.Point(13, 32);
            this.cboMedioDePago.Name = "cboMedioDePago";
            this.cboMedioDePago.Size = new System.Drawing.Size(191, 25);
            this.cboMedioDePago.TabIndex = 2;
            this.cboMedioDePago.UseSelectable = true;
            this.cboMedioDePago.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(13, 10);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(82, 19);
            this.metroLabel13.TabIndex = 1;
            this.metroLabel13.Text = "Medio pago";
            this.metroLabel13.UseCustomBackColor = true;
            // 
            // lblMtoTotal
            // 
            this.lblMtoTotal.AutoSize = true;
            this.lblMtoTotal.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMtoTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMtoTotal.Location = new System.Drawing.Point(343, 23);
            this.lblMtoTotal.Name = "lblMtoTotal";
            this.lblMtoTotal.Size = new System.Drawing.Size(120, 50);
            this.lblMtoTotal.TabIndex = 57;
            this.lblMtoTotal.Text = "label1";
            this.lblMtoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMedioDePagoDtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 396);
            this.Controls.Add(this.lblMtoTotal);
            this.Controls.Add(this.tabMedioDePagoDtl);
            this.Name = "FormMedioDePagoDtl";
            this.Text = "Medio de pago detalle";
            this.Load += new System.EventHandler(this.FormMedioDePagoDtl_Load);
            this.tabMedioDePagoDtl.ResumeLayout(false);
            this.tabPagPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPagOtros.ResumeLayout(false);
            this.tabPagOtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedioPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabMedioDePagoDtl;
        private MetroFramework.Controls.MetroTabPage tabPagPrincipal;
        private MetroFramework.Controls.MetroTabPage tabPagOtros;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroTextBox txtMtoActualMedioPago;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTextBox txtMtoRestanteMedioPago;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox txtMtoTotalMedioPago;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.Button btnDeleteMtoMedioPago;
        private System.Windows.Forms.Button btnAddMtoMedioPago;
        private System.Windows.Forms.DataGridView dgvMedioPago;
        private MetroFramework.Controls.MetroTextBox txtMtoMedioPago;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroComboBox cboMedioDePago;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel lblTipoDeCambio;
        private MetroFramework.Controls.MetroTextBox txtTipoDeCambio;
        private MetroFramework.Controls.MetroComboBox cboMoneda;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMtoTotal;
    }
}