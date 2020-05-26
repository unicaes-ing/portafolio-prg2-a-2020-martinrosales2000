namespace Practica_11
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCirculo = new System.Windows.Forms.RadioButton();
            this.rdoCuadrado = new System.Windows.Forms.RadioButton();
            this.rdoTriangulo = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTriangulo);
            this.groupBox1.Controls.Add(this.rdoCuadrado);
            this.groupBox1.Controls.Add(this.rdoCirculo);
            this.groupBox1.Location = new System.Drawing.Point(58, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione:";
            // 
            // rdoCirculo
            // 
            this.rdoCirculo.AutoSize = true;
            this.rdoCirculo.Location = new System.Drawing.Point(37, 47);
            this.rdoCirculo.Name = "rdoCirculo";
            this.rdoCirculo.Size = new System.Drawing.Size(57, 17);
            this.rdoCirculo.TabIndex = 0;
            this.rdoCirculo.Text = "Circulo";
            this.rdoCirculo.UseVisualStyleBackColor = true;
            this.rdoCirculo.CheckedChanged += new System.EventHandler(this.rdoCirculo_CheckedChanged);
            // 
            // rdoCuadrado
            // 
            this.rdoCuadrado.AutoSize = true;
            this.rdoCuadrado.Location = new System.Drawing.Point(37, 82);
            this.rdoCuadrado.Name = "rdoCuadrado";
            this.rdoCuadrado.Size = new System.Drawing.Size(71, 17);
            this.rdoCuadrado.TabIndex = 1;
            this.rdoCuadrado.Text = "Cuadrado";
            this.rdoCuadrado.UseVisualStyleBackColor = true;
            this.rdoCuadrado.CheckedChanged += new System.EventHandler(this.rdoCuadrado_CheckedChanged);
            // 
            // rdoTriangulo
            // 
            this.rdoTriangulo.AutoSize = true;
            this.rdoTriangulo.Location = new System.Drawing.Point(37, 117);
            this.rdoTriangulo.Name = "rdoTriangulo";
            this.rdoTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rdoTriangulo.TabIndex = 2;
            this.rdoTriangulo.Text = "Triangulo";
            this.rdoTriangulo.UseVisualStyleBackColor = true;
            this.rdoTriangulo.CheckedChanged += new System.EventHandler(this.rdoTriangulo_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(89, 238);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "El área es:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(299, 213);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ReadOnly = true;
            this.txtRespuesta.Size = new System.Drawing.Size(104, 20);
            this.txtRespuesta.TabIndex = 3;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(303, 73);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.ShortcutsEnabled = false;
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 0;
            this.txtValor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor1_KeyPress);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(303, 104);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.ShortcutsEnabled = false;
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 1;
            this.txtValor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 294);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTriangulo;
        private System.Windows.Forms.RadioButton rdoCuadrado;
        private System.Windows.Forms.RadioButton rdoCirculo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

