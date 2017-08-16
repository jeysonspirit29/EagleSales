namespace EagleSales
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.linkSalir = new MetroFramework.Controls.MetroLink();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnNuevaOrden = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timerHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.btnHora = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkSalir
            // 
            this.linkSalir.Image = global::EagleSales.Properties.Resources.on_off_power_x32;
            this.linkSalir.ImageSize = 32;
            this.linkSalir.Location = new System.Drawing.Point(737, 5);
            this.linkSalir.Name = "linkSalir";
            this.linkSalir.Size = new System.Drawing.Size(88, 58);
            this.linkSalir.TabIndex = 5;
            this.linkSalir.UseSelectable = true;
            this.linkSalir.Click += new System.EventHandler(this.linkSalir_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::EagleSales.Properties.Resources.new_sale_01_x32;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(157, 261);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.button4.Size = new System.Drawing.Size(128, 87);
            this.button4.TabIndex = 4;
            this.button4.Text = "Editar Boleta";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::EagleSales.Properties.Resources.new_sale_01_x32;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(157, 168);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.button5.Size = new System.Drawing.Size(128, 87);
            this.button5.TabIndex = 3;
            this.button5.Text = "Editar Factura";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnNuevaOrden
            // 
            this.btnNuevaOrden.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNuevaOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaOrden.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaOrden.ForeColor = System.Drawing.Color.White;
            this.btnNuevaOrden.Image = global::EagleSales.Properties.Resources.new_sale_01_x32;
            this.btnNuevaOrden.Location = new System.Drawing.Point(23, 75);
            this.btnNuevaOrden.Name = "btnNuevaOrden";
            this.btnNuevaOrden.Size = new System.Drawing.Size(262, 87);
            this.btnNuevaOrden.TabIndex = 2;
            this.btnNuevaOrden.Text = "   Nueva Orden";
            this.btnNuevaOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaOrden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaOrden.UseVisualStyleBackColor = false;
            this.btnNuevaOrden.Click += new System.EventHandler(this.btnNuevaOrden_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::EagleSales.Properties.Resources.new_sale_01_x32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(23, 261);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.button2.Size = new System.Drawing.Size(128, 87);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nueva Boleta";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::EagleSales.Properties.Resources.new_sale_01_x32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(23, 168);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.button1.Size = new System.Drawing.Size(128, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nueva Factura";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // timerHoraFecha
            // 
            this.timerHoraFecha.Tick += new System.EventHandler(this.timerHoraFecha_Tick);
            // 
            // btnHora
            // 
            this.btnHora.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHora.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHora.ForeColor = System.Drawing.Color.White;
            this.btnHora.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHora.Location = new System.Drawing.Point(594, 168);
            this.btnHora.Name = "btnHora";
            this.btnHora.Size = new System.Drawing.Size(207, 87);
            this.btnHora.TabIndex = 7;
            this.btnHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHora.UseVisualStyleBackColor = false;
            // 
            // btnFecha
            // 
            this.btnFecha.BackColor = System.Drawing.Color.LightCoral;
            this.btnFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecha.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecha.ForeColor = System.Drawing.Color.White;
            this.btnFecha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFecha.Location = new System.Drawing.Point(594, 261);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(207, 87);
            this.btnFecha.TabIndex = 8;
            this.btnFecha.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(594, 75);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.button3.Size = new System.Drawing.Size(207, 87);
            this.button3.TabIndex = 6;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(308, 168);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.button8.Size = new System.Drawing.Size(262, 87);
            this.button8.TabIndex = 9;
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightGreen;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(442, 261);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.button9.Size = new System.Drawing.Size(128, 87);
            this.button9.TabIndex = 11;
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.Location = new System.Drawing.Point(308, 261);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.button10.Size = new System.Drawing.Size(128, 87);
            this.button10.TabIndex = 10;
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.Location = new System.Drawing.Point(442, 75);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.button11.Size = new System.Drawing.Size(128, 87);
            this.button11.TabIndex = 13;
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DarkGray;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.Location = new System.Drawing.Point(308, 75);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.button12.Size = new System.Drawing.Size(128, 87);
            this.button12.TabIndex = 12;
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 387);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnHora);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnNuevaOrden);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkSalir);
            this.Name = "FormMain";
            this.Text = "Eagle Sales";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNuevaOrden;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private MetroFramework.Controls.MetroLink linkSalir;
        private System.Windows.Forms.Timer timerHoraFecha;
        private System.Windows.Forms.Button btnHora;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

