﻿namespace EagleSales.Buscadores
{
    partial class FormBuscarProducto
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
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.checkActivos = new MetroFramework.Controls.MetroCheckBox();
            this.checkInactivos = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtDescripcionProd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCodigo02 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVerTodos.FlatAppearance.BorderSize = 0;
            this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.Color.White;
            this.btnVerTodos.Location = new System.Drawing.Point(658, 71);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(87, 25);
            this.btnVerTodos.TabIndex = 10;
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
            this.btnSeleccionar.Location = new System.Drawing.Point(658, 102);
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
            this.checkActivos.Location = new System.Drawing.Point(557, 105);
            this.checkActivos.Name = "checkActivos";
            this.checkActivos.Size = new System.Drawing.Size(69, 19);
            this.checkActivos.TabIndex = 8;
            this.checkActivos.Text = "Activos";
            this.checkActivos.UseSelectable = true;
            this.checkActivos.CheckedChanged += new System.EventHandler(this.checkActivos_CheckedChanged);
            // 
            // checkInactivos
            // 
            this.checkInactivos.AutoSize = true;
            this.checkInactivos.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkInactivos.Location = new System.Drawing.Point(557, 76);
            this.checkInactivos.Name = "checkInactivos";
            this.checkInactivos.Size = new System.Drawing.Size(79, 19);
            this.checkInactivos.TabIndex = 9;
            this.checkInactivos.Text = "Inactivos";
            this.checkInactivos.UseSelectable = true;
            this.checkInactivos.CheckedChanged += new System.EventHandler(this.checkInactivos_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(35, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Descripción:";
            // 
            // txtDescripcionProd
            // 
            // 
            // 
            // 
            this.txtDescripcionProd.CustomButton.Image = null;
            this.txtDescripcionProd.CustomButton.Location = new System.Drawing.Point(385, 1);
            this.txtDescripcionProd.CustomButton.Name = "";
            this.txtDescripcionProd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescripcionProd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcionProd.CustomButton.TabIndex = 1;
            this.txtDescripcionProd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcionProd.CustomButton.UseSelectable = true;
            this.txtDescripcionProd.CustomButton.Visible = false;
            this.txtDescripcionProd.Lines = new string[0];
            this.txtDescripcionProd.Location = new System.Drawing.Point(120, 103);
            this.txtDescripcionProd.MaxLength = 32767;
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.PasswordChar = '\0';
            this.txtDescripcionProd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcionProd.SelectedText = "";
            this.txtDescripcionProd.SelectionLength = 0;
            this.txtDescripcionProd.SelectionStart = 0;
            this.txtDescripcionProd.ShortcutsEnabled = true;
            this.txtDescripcionProd.Size = new System.Drawing.Size(407, 23);
            this.txtDescripcionProd.TabIndex = 5;
            this.txtDescripcionProd.UseSelectable = true;
            this.txtDescripcionProd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcionProd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcionProd.TextChanged += new System.EventHandler(this.txtDescripcionProd_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(310, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Código 02:";
            // 
            // txtCodigo02
            // 
            // 
            // 
            // 
            this.txtCodigo02.CustomButton.Image = null;
            this.txtCodigo02.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtCodigo02.CustomButton.Name = "";
            this.txtCodigo02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo02.CustomButton.TabIndex = 1;
            this.txtCodigo02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo02.CustomButton.UseSelectable = true;
            this.txtCodigo02.CustomButton.Visible = false;
            this.txtCodigo02.Lines = new string[0];
            this.txtCodigo02.Location = new System.Drawing.Point(390, 73);
            this.txtCodigo02.MaxLength = 32767;
            this.txtCodigo02.Name = "txtCodigo02";
            this.txtCodigo02.PasswordChar = '\0';
            this.txtCodigo02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo02.SelectedText = "";
            this.txtCodigo02.SelectionLength = 0;
            this.txtCodigo02.SelectionStart = 0;
            this.txtCodigo02.ShortcutsEnabled = true;
            this.txtCodigo02.Size = new System.Drawing.Size(137, 23);
            this.txtCodigo02.TabIndex = 7;
            this.txtCodigo02.UseSelectable = true;
            this.txtCodigo02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo02.TextChanged += new System.EventHandler(this.txtCodigo02_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Código:";
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(120, 74);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(137, 23);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(35, 150);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(710, 287);
            this.dgvProd.TabIndex = 0;
            this.dgvProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellDoubleClick);
            this.dgvProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProd_KeyDown);
            // 
            // FormBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 460);
            this.Controls.Add(this.btnVerTodos);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.checkActivos);
            this.Controls.Add(this.checkInactivos);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtDescripcionProd);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtCodigo02);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dgvProd);
            this.Name = "FormBuscarProducto";
            this.Text = "Seleccionar Producto";
            this.Load += new System.EventHandler(this.FormBuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnSeleccionar;
        private MetroFramework.Controls.MetroCheckBox checkActivos;
        private MetroFramework.Controls.MetroCheckBox checkInactivos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDescripcionProd;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCodigo02;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvProd;
    }
}