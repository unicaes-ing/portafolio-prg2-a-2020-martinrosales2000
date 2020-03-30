namespace Practica_2
{
    partial class Form2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDescuento1 = new System.Windows.Forms.RadioButton();
            this.rdoDescuento5 = new System.Windows.Forms.RadioButton();
            this.rdoDescuento4 = new System.Windows.Forms.RadioButton();
            this.rdoDescuento3 = new System.Windows.Forms.RadioButton();
            this.rdoDescuento2 = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDescuento1);
            this.groupBox1.Controls.Add(this.rdoDescuento5);
            this.groupBox1.Controls.Add(this.rdoDescuento4);
            this.groupBox1.Controls.Add(this.rdoDescuento3);
            this.groupBox1.Controls.Add(this.rdoDescuento2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(392, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descuentos ";
            // 
            // rdoDescuento1
            // 
            this.rdoDescuento1.AutoSize = true;
            this.rdoDescuento1.Checked = true;
            this.rdoDescuento1.Location = new System.Drawing.Point(34, 34);
            this.rdoDescuento1.Name = "rdoDescuento1";
            this.rdoDescuento1.Size = new System.Drawing.Size(39, 17);
            this.rdoDescuento1.TabIndex = 4;
            this.rdoDescuento1.TabStop = true;
            this.rdoDescuento1.Text = "0%";
            this.rdoDescuento1.UseVisualStyleBackColor = true;
            this.rdoDescuento1.CheckedChanged += new System.EventHandler(this.rdoDescuento1_CheckedChanged);
            // 
            // rdoDescuento5
            // 
            this.rdoDescuento5.AutoSize = true;
            this.rdoDescuento5.Location = new System.Drawing.Point(34, 137);
            this.rdoDescuento5.Name = "rdoDescuento5";
            this.rdoDescuento5.Size = new System.Drawing.Size(45, 17);
            this.rdoDescuento5.TabIndex = 3;
            this.rdoDescuento5.Text = "20%";
            this.rdoDescuento5.UseVisualStyleBackColor = true;
            // 
            // rdoDescuento4
            // 
            this.rdoDescuento4.AutoSize = true;
            this.rdoDescuento4.Location = new System.Drawing.Point(34, 107);
            this.rdoDescuento4.Name = "rdoDescuento4";
            this.rdoDescuento4.Size = new System.Drawing.Size(45, 17);
            this.rdoDescuento4.TabIndex = 2;
            this.rdoDescuento4.Text = "15%";
            this.rdoDescuento4.UseVisualStyleBackColor = true;
            // 
            // rdoDescuento3
            // 
            this.rdoDescuento3.AutoSize = true;
            this.rdoDescuento3.Location = new System.Drawing.Point(34, 84);
            this.rdoDescuento3.Name = "rdoDescuento3";
            this.rdoDescuento3.Size = new System.Drawing.Size(45, 17);
            this.rdoDescuento3.TabIndex = 1;
            this.rdoDescuento3.Text = "10%";
            this.rdoDescuento3.UseVisualStyleBackColor = true;
            // 
            // rdoDescuento2
            // 
            this.rdoDescuento2.AutoSize = true;
            this.rdoDescuento2.Location = new System.Drawing.Point(34, 57);
            this.rdoDescuento2.Name = "rdoDescuento2";
            this.rdoDescuento2.Size = new System.Drawing.Size(39, 17);
            this.rdoDescuento2.TabIndex = 0;
            this.rdoDescuento2.Text = "5%";
            this.rdoDescuento2.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Location = new System.Drawing.Point(200, 176);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Location = new System.Drawing.Point(340, 387);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.Location = new System.Drawing.Point(200, 387);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(76, 87);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad \r\n";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(91, 130);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(69, 219);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(59, 13);
            this.lblDescuento.TabIndex = 17;
            this.lblDescuento.Text = "Descuento";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(97, 268);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(175, 84);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 19;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(175, 123);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 20;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(175, 219);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 21;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(175, 261);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDescuento1;
        private System.Windows.Forms.RadioButton rdoDescuento5;
        private System.Windows.Forms.RadioButton rdoDescuento4;
        private System.Windows.Forms.RadioButton rdoDescuento3;
        private System.Windows.Forms.RadioButton rdoDescuento2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

