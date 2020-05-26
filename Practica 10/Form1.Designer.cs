namespace Practica_10
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoCarro = new System.Windows.Forms.RadioButton();
            this.rdoCamion = new System.Windows.Forms.RadioButton();
            this.rdoMicrobus = new System.Windows.Forms.RadioButton();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.nudMillaje = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Millas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puertas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPuertas = new System.Windows.Forms.TextBox();
            this.txtCapacidadCarga = new System.Windows.Forms.TextBox();
            this.txtTanqueCombustible = new System.Windows.Forms.TextBox();
            this.txtPasajeros = new System.Windows.Forms.TextBox();
            this.lblPuertas = new System.Windows.Forms.Label();
            this.lblCapacidadCarga = new System.Windows.Forms.Label();
            this.lblTanqueCombustible = new System.Windows.Forms.Label();
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.lblKilos = new System.Windows.Forms.Label();
            this.lblGalones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMillaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Millaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // rdoCarro
            // 
            this.rdoCarro.AutoSize = true;
            this.rdoCarro.Location = new System.Drawing.Point(122, 194);
            this.rdoCarro.Name = "rdoCarro";
            this.rdoCarro.Size = new System.Drawing.Size(50, 17);
            this.rdoCarro.TabIndex = 5;
            this.rdoCarro.Text = "Carro";
            this.rdoCarro.UseVisualStyleBackColor = true;
            this.rdoCarro.CheckedChanged += new System.EventHandler(this.rdoCarro_CheckedChanged);
            // 
            // rdoCamion
            // 
            this.rdoCamion.AutoSize = true;
            this.rdoCamion.Location = new System.Drawing.Point(178, 194);
            this.rdoCamion.Name = "rdoCamion";
            this.rdoCamion.Size = new System.Drawing.Size(60, 17);
            this.rdoCamion.TabIndex = 6;
            this.rdoCamion.Text = "Camion";
            this.rdoCamion.UseVisualStyleBackColor = true;
            this.rdoCamion.CheckedChanged += new System.EventHandler(this.rdoCamion_CheckedChanged);
            // 
            // rdoMicrobus
            // 
            this.rdoMicrobus.AutoSize = true;
            this.rdoMicrobus.Location = new System.Drawing.Point(244, 194);
            this.rdoMicrobus.Name = "rdoMicrobus";
            this.rdoMicrobus.Size = new System.Drawing.Size(68, 17);
            this.rdoMicrobus.TabIndex = 7;
            this.rdoMicrobus.Text = "Microbus";
            this.rdoMicrobus.UseVisualStyleBackColor = true;
            this.rdoMicrobus.CheckedChanged += new System.EventHandler(this.rdoMicrobus_CheckedChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(138, 51);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(137, 20);
            this.txtMarca.TabIndex = 8;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(138, 86);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(137, 20);
            this.txtModelo.TabIndex = 9;
            // 
            // nudMillaje
            // 
            this.nudMillaje.Location = new System.Drawing.Point(138, 122);
            this.nudMillaje.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudMillaje.Name = "nudMillaje";
            this.nudMillaje.Size = new System.Drawing.Size(58, 20);
            this.nudMillaje.TabIndex = 10;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(138, 157);
            this.nudPrecio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(58, 20);
            this.nudPrecio.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(334, 189);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marca,
            this.Modelo,
            this.Millas,
            this.Precio,
            this.Tipo,
            this.Puertas,
            this.Capacidad,
            this.Combustible,
            this.Pasajeros});
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(672, 218);
            this.dataGridView1.TabIndex = 13;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Millas
            // 
            this.Millas.HeaderText = "Millas";
            this.Millas.Name = "Millas";
            this.Millas.ReadOnly = true;
            this.Millas.Width = 60;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 60;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Puertas
            // 
            this.Puertas.HeaderText = "Puertas";
            this.Puertas.Name = "Puertas";
            this.Puertas.ReadOnly = true;
            this.Puertas.Width = 50;
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.ReadOnly = true;
            this.Capacidad.Width = 70;
            // 
            // Combustible
            // 
            this.Combustible.HeaderText = "Combustible";
            this.Combustible.Name = "Combustible";
            this.Combustible.ReadOnly = true;
            this.Combustible.Width = 70;
            // 
            // Pasajeros
            // 
            this.Pasajeros.HeaderText = "Pasajeros";
            this.Pasajeros.Name = "Pasajeros";
            this.Pasajeros.ReadOnly = true;
            this.Pasajeros.Width = 55;
            // 
            // txtPuertas
            // 
            this.txtPuertas.Location = new System.Drawing.Point(390, 51);
            this.txtPuertas.Name = "txtPuertas";
            this.txtPuertas.Size = new System.Drawing.Size(100, 20);
            this.txtPuertas.TabIndex = 14;
            // 
            // txtCapacidadCarga
            // 
            this.txtCapacidadCarga.Location = new System.Drawing.Point(390, 86);
            this.txtCapacidadCarga.Name = "txtCapacidadCarga";
            this.txtCapacidadCarga.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidadCarga.TabIndex = 15;
            // 
            // txtTanqueCombustible
            // 
            this.txtTanqueCombustible.Location = new System.Drawing.Point(390, 121);
            this.txtTanqueCombustible.Name = "txtTanqueCombustible";
            this.txtTanqueCombustible.Size = new System.Drawing.Size(100, 20);
            this.txtTanqueCombustible.TabIndex = 16;
            // 
            // txtPasajeros
            // 
            this.txtPasajeros.Location = new System.Drawing.Point(390, 152);
            this.txtPasajeros.Name = "txtPasajeros";
            this.txtPasajeros.Size = new System.Drawing.Size(100, 20);
            this.txtPasajeros.TabIndex = 17;
            // 
            // lblPuertas
            // 
            this.lblPuertas.AutoSize = true;
            this.lblPuertas.Location = new System.Drawing.Point(341, 54);
            this.lblPuertas.Name = "lblPuertas";
            this.lblPuertas.Size = new System.Drawing.Size(43, 13);
            this.lblPuertas.TabIndex = 18;
            this.lblPuertas.Text = "Puertas";
            // 
            // lblCapacidadCarga
            // 
            this.lblCapacidadCarga.AutoSize = true;
            this.lblCapacidadCarga.Location = new System.Drawing.Point(296, 89);
            this.lblCapacidadCarga.Name = "lblCapacidadCarga";
            this.lblCapacidadCarga.Size = new System.Drawing.Size(88, 13);
            this.lblCapacidadCarga.TabIndex = 19;
            this.lblCapacidadCarga.Text = "Capacidad carga";
            // 
            // lblTanqueCombustible
            // 
            this.lblTanqueCombustible.AutoSize = true;
            this.lblTanqueCombustible.Location = new System.Drawing.Point(281, 124);
            this.lblTanqueCombustible.Name = "lblTanqueCombustible";
            this.lblTanqueCombustible.Size = new System.Drawing.Size(103, 13);
            this.lblTanqueCombustible.TabIndex = 20;
            this.lblTanqueCombustible.Text = "Tanque combustible";
            // 
            // lblPasajeros
            // 
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Location = new System.Drawing.Point(331, 155);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(53, 13);
            this.lblPasajeros.TabIndex = 21;
            this.lblPasajeros.Text = "Pasajeros";
            // 
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(505, 89);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(29, 13);
            this.lblKilos.TabIndex = 22;
            this.lblKilos.Text = "Kilos";
            // 
            // lblGalones
            // 
            this.lblGalones.AutoSize = true;
            this.lblGalones.Location = new System.Drawing.Point(505, 124);
            this.lblGalones.Name = "lblGalones";
            this.lblGalones.Size = new System.Drawing.Size(46, 13);
            this.lblGalones.TabIndex = 23;
            this.lblGalones.Text = "Galones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 509);
            this.Controls.Add(this.lblGalones);
            this.Controls.Add(this.lblKilos);
            this.Controls.Add(this.lblPasajeros);
            this.Controls.Add(this.lblTanqueCombustible);
            this.Controls.Add(this.lblCapacidadCarga);
            this.Controls.Add(this.lblPuertas);
            this.Controls.Add(this.txtPasajeros);
            this.Controls.Add(this.txtTanqueCombustible);
            this.Controls.Add(this.txtCapacidadCarga);
            this.Controls.Add(this.txtPuertas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.nudMillaje);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.rdoMicrobus);
            this.Controls.Add(this.rdoCamion);
            this.Controls.Add(this.rdoCarro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Autos nuevos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMillaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoCarro;
        private System.Windows.Forms.RadioButton rdoCamion;
        private System.Windows.Forms.RadioButton rdoMicrobus;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.NumericUpDown nudMillaje;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Millas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasajeros;
        private System.Windows.Forms.TextBox txtPuertas;
        private System.Windows.Forms.TextBox txtCapacidadCarga;
        private System.Windows.Forms.TextBox txtTanqueCombustible;
        private System.Windows.Forms.TextBox txtPasajeros;
        private System.Windows.Forms.Label lblPuertas;
        private System.Windows.Forms.Label lblCapacidadCarga;
        private System.Windows.Forms.Label lblTanqueCombustible;
        private System.Windows.Forms.Label lblPasajeros;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.Label lblGalones;
    }
}

