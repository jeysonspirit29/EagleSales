namespace EagleSales.Buscadores
{
    partial class FormBuscarCliente
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
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.cboTipoSujeto = new MetroFramework.Controls.MetroComboBox();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.checkActivos = new MetroFramework.Controls.MetroCheckBox();
            this.checkInactivos = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNombreCliente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNroRUC = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNroDocumento = new MetroFramework.Controls.MetroTextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(449, 75);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(48, 19);
            this.metroLabel22.TabIndex = 8;
            this.metroLabel22.Text = "Sujeto:";
            this.metroLabel22.UseCustomBackColor = true;
            // 
            // cboTipoSujeto
            // 
            this.cboTipoSujeto.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboTipoSujeto.FormattingEnabled = true;
            this.cboTipoSujeto.ItemHeight = 19;
            this.cboTipoSujeto.Location = new System.Drawing.Point(503, 71);
            this.cboTipoSujeto.Name = "cboTipoSujeto";
            this.cboTipoSujeto.Size = new System.Drawing.Size(129, 25);
            this.cboTipoSujeto.TabIndex = 9;
            this.cboTipoSujeto.UseSelectable = true;
            this.cboTipoSujeto.UseStyleColors = true;
            this.cboTipoSujeto.SelectedIndexChanged += new System.EventHandler(this.cboTipoSujeto_SelectedIndexChanged);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVerTodos.FlatAppearance.BorderSize = 0;
            this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.Color.White;
            this.btnVerTodos.Location = new System.Drawing.Point(659, 71);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(87, 25);
            this.btnVerTodos.TabIndex = 12;
            this.btnVerTodos.Text = "Ver todos";
            this.btnVerTodos.UseVisualStyleBackColor = false;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(659, 102);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(87, 25);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // checkActivos
            // 
            this.checkActivos.AutoSize = true;
            this.checkActivos.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkActivos.Location = new System.Drawing.Point(449, 105);
            this.checkActivos.Name = "checkActivos";
            this.checkActivos.Size = new System.Drawing.Size(69, 19);
            this.checkActivos.TabIndex = 10;
            this.checkActivos.Text = "Activos";
            this.checkActivos.UseSelectable = true;
            this.checkActivos.CheckedChanged += new System.EventHandler(this.checkActivos_CheckedChanged);
            // 
            // checkInactivos
            // 
            this.checkInactivos.AutoSize = true;
            this.checkInactivos.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkInactivos.Location = new System.Drawing.Point(553, 105);
            this.checkInactivos.Name = "checkInactivos";
            this.checkInactivos.Size = new System.Drawing.Size(79, 19);
            this.checkInactivos.TabIndex = 11;
            this.checkInactivos.Text = "Inactivos";
            this.checkInactivos.UseSelectable = true;
            this.checkInactivos.CheckedChanged += new System.EventHandler(this.checkInactivos_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(36, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Nom/Rzn Soc:";
            // 
            // txtNombreCliente
            // 
            // 
            // 
            // 
            this.txtNombreCliente.CustomButton.Image = null;
            this.txtNombreCliente.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.txtNombreCliente.CustomButton.Name = "";
            this.txtNombreCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreCliente.CustomButton.TabIndex = 1;
            this.txtNombreCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreCliente.CustomButton.UseSelectable = true;
            this.txtNombreCliente.CustomButton.Visible = false;
            this.txtNombreCliente.Lines = new string[0];
            this.txtNombreCliente.Location = new System.Drawing.Point(135, 103);
            this.txtNombreCliente.MaxLength = 32767;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.PasswordChar = '\0';
            this.txtNombreCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreCliente.SelectedText = "";
            this.txtNombreCliente.SelectionLength = 0;
            this.txtNombreCliente.SelectionStart = 0;
            this.txtNombreCliente.ShortcutsEnabled = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(308, 23);
            this.txtNombreCliente.TabIndex = 7;
            this.txtNombreCliente.UseSelectable = true;
            this.txtNombreCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(270, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "RUC:";
            // 
            // txtNroRUC
            // 
            // 
            // 
            // 
            this.txtNroRUC.CustomButton.Image = null;
            this.txtNroRUC.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtNroRUC.CustomButton.Name = "";
            this.txtNroRUC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNroRUC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNroRUC.CustomButton.TabIndex = 1;
            this.txtNroRUC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNroRUC.CustomButton.UseSelectable = true;
            this.txtNroRUC.CustomButton.Visible = false;
            this.txtNroRUC.Lines = new string[0];
            this.txtNroRUC.Location = new System.Drawing.Point(314, 73);
            this.txtNroRUC.MaxLength = 32767;
            this.txtNroRUC.Name = "txtNroRUC";
            this.txtNroRUC.PasswordChar = '\0';
            this.txtNroRUC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNroRUC.SelectedText = "";
            this.txtNroRUC.SelectionLength = 0;
            this.txtNroRUC.SelectionStart = 0;
            this.txtNroRUC.ShortcutsEnabled = true;
            this.txtNroRUC.Size = new System.Drawing.Size(129, 23);
            this.txtNroRUC.TabIndex = 5;
            this.txtNroRUC.UseSelectable = true;
            this.txtNroRUC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNroRUC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNroRUC.TextChanged += new System.EventHandler(this.txtNroRUC_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nro. Doc:";
            // 
            // txtNroDocumento
            // 
            // 
            // 
            // 
            this.txtNroDocumento.CustomButton.Image = null;
            this.txtNroDocumento.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtNroDocumento.CustomButton.Name = "";
            this.txtNroDocumento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNroDocumento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNroDocumento.CustomButton.TabIndex = 1;
            this.txtNroDocumento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNroDocumento.CustomButton.UseSelectable = true;
            this.txtNroDocumento.CustomButton.Visible = false;
            this.txtNroDocumento.Lines = new string[0];
            this.txtNroDocumento.Location = new System.Drawing.Point(135, 73);
            this.txtNroDocumento.MaxLength = 32767;
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.PasswordChar = '\0';
            this.txtNroDocumento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNroDocumento.SelectedText = "";
            this.txtNroDocumento.SelectionLength = 0;
            this.txtNroDocumento.SelectionStart = 0;
            this.txtNroDocumento.ShortcutsEnabled = true;
            this.txtNroDocumento.Size = new System.Drawing.Size(129, 23);
            this.txtNroDocumento.TabIndex = 3;
            this.txtNroDocumento.UseSelectable = true;
            this.txtNroDocumento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNroDocumento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNroDocumento.TextChanged += new System.EventHandler(this.txtNroDocumento_TextChanged);
            // 
            // dgvCliente
            // 
            this.dgvCliente.Location = new System.Drawing.Point(36, 150);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(710, 287);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellDoubleClick);
            this.dgvCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCliente_KeyDown);
            // 
            // FormBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 460);
            this.Controls.Add(this.metroLabel22);
            this.Controls.Add(this.cboTipoSujeto);
            this.Controls.Add(this.btnVerTodos);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.checkActivos);
            this.Controls.Add(this.checkInactivos);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNroRUC);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.dgvCliente);
            this.Name = "FormBuscarCliente";
            this.Text = "Seleccionar Cliente";
            this.Load += new System.EventHandler(this.FormBuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroComboBox cboTipoSujeto;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnSeleccionar;
        private MetroFramework.Controls.MetroCheckBox checkActivos;
        private MetroFramework.Controls.MetroCheckBox checkInactivos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNombreCliente;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNroRUC;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNroDocumento;
        private System.Windows.Forms.DataGridView dgvCliente;
    }
}