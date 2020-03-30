namespace WindowsFormsApplication1
{
    partial class Ejercicio3
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtInvercionista1 = new System.Windows.Forms.TextBox();
            this.txtInvercionista2 = new System.Windows.Forms.TextBox();
            this.txtInvercionista3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPorcentaje1 = new System.Windows.Forms.TextBox();
            this.txtPorcentaje2 = new System.Windows.Forms.TextBox();
            this.txtPorcentaje3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Location = new System.Drawing.Point(49, 313);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Location = new System.Drawing.Point(369, 313);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.Location = new System.Drawing.Point(219, 313);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Inversionistas ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "total de inversión:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(57, 260);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 23;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtInvercionista1
            // 
            this.txtInvercionista1.Location = new System.Drawing.Point(70, 111);
            this.txtInvercionista1.Name = "txtInvercionista1";
            this.txtInvercionista1.Size = new System.Drawing.Size(100, 20);
            this.txtInvercionista1.TabIndex = 24;
            // 
            // txtInvercionista2
            // 
            this.txtInvercionista2.Location = new System.Drawing.Point(70, 151);
            this.txtInvercionista2.Name = "txtInvercionista2";
            this.txtInvercionista2.Size = new System.Drawing.Size(100, 20);
            this.txtInvercionista2.TabIndex = 25;
            // 
            // txtInvercionista3
            // 
            this.txtInvercionista3.Location = new System.Drawing.Point(70, 190);
            this.txtInvercionista3.Name = "txtInvercionista3";
            this.txtInvercionista3.Size = new System.Drawing.Size(100, 20);
            this.txtInvercionista3.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Porcentaje:";
            // 
            // txtPorcentaje1
            // 
            this.txtPorcentaje1.Location = new System.Drawing.Point(320, 111);
            this.txtPorcentaje1.Name = "txtPorcentaje1";
            this.txtPorcentaje1.ReadOnly = true;
            this.txtPorcentaje1.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentaje1.TabIndex = 28;
            // 
            // txtPorcentaje2
            // 
            this.txtPorcentaje2.Location = new System.Drawing.Point(320, 151);
            this.txtPorcentaje2.Name = "txtPorcentaje2";
            this.txtPorcentaje2.ReadOnly = true;
            this.txtPorcentaje2.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentaje2.TabIndex = 29;
            // 
            // txtPorcentaje3
            // 
            this.txtPorcentaje3.Location = new System.Drawing.Point(320, 190);
            this.txtPorcentaje3.Name = "txtPorcentaje3";
            this.txtPorcentaje3.ReadOnly = true;
            this.txtPorcentaje3.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentaje3.TabIndex = 30;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 365);
            this.Controls.Add(this.txtPorcentaje3);
            this.Controls.Add(this.txtPorcentaje2);
            this.Controls.Add(this.txtPorcentaje1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInvercionista3);
            this.Controls.Add(this.txtInvercionista2);
            this.Controls.Add(this.txtInvercionista1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "Ejercicio3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtInvercionista1;
        private System.Windows.Forms.TextBox txtInvercionista2;
        private System.Windows.Forms.TextBox txtInvercionista3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPorcentaje1;
        private System.Windows.Forms.TextBox txtPorcentaje2;
        private System.Windows.Forms.TextBox txtPorcentaje3;
    }
}