namespace Practica_9
{
    partial class Form3
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
            this.Cancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nudPasajeros = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.mtxMatricula = new System.Windows.Forms.MaskedTextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(132, 251);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(56, 19);
            this.Cancelar.TabIndex = 42;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(54, 251);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 19);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // nudPasajeros
            // 
            this.nudPasajeros.Location = new System.Drawing.Point(131, 194);
            this.nudPasajeros.Margin = new System.Windows.Forms.Padding(2);
            this.nudPasajeros.Name = "nudPasajeros";
            this.nudPasajeros.Size = new System.Drawing.Size(57, 20);
            this.nudPasajeros.TabIndex = 39;
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(131, 161);
            this.nudYear.Margin = new System.Windows.Forms.Padding(2);
            this.nudYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(57, 20);
            this.nudYear.TabIndex = 37;
            // 
            // cboColor
            // 
            this.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Items.AddRange(new object[] {
            "Negro",
            "Blanco",
            "Azúl",
            "Rojo ",
            "Gris",
            "Amarillo"});
            this.cboColor.Location = new System.Drawing.Point(131, 127);
            this.cboColor.Margin = new System.Windows.Forms.Padding(2);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(92, 21);
            this.cboColor.TabIndex = 35;
            // 
            // mtxMatricula
            // 
            this.mtxMatricula.Location = new System.Drawing.Point(131, 28);
            this.mtxMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.mtxMatricula.Mask = ">P000-000";
            this.mtxMatricula.Name = "mtxMatricula";
            this.mtxMatricula.Size = new System.Drawing.Size(92, 20);
            this.mtxMatricula.TabIndex = 29;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(131, 94);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(92, 20);
            this.txtModelo.TabIndex = 33;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(131, 61);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(92, 20);
            this.txtMarca.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Pasajeros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Matrícula";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 315);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.nudPasajeros);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.mtxMatricula);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.nudPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown nudPasajeros;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.MaskedTextBox mtxMatricula;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}