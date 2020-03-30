namespace Practica_6
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoLimpiar = new System.Windows.Forms.RadioButton();
            this.rdoOrdenar = new System.Windows.Forms.RadioButton();
            this.rdoQuitar = new System.Windows.Forms.RadioButton();
            this.rdoInsertar = new System.Windows.Forms.RadioButton();
            this.rdoBuscar = new System.Windows.Forms.RadioButton();
            this.rdoAgregar = new System.Windows.Forms.RadioButton();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(35, 91);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(120, 199);
            this.lstLista.TabIndex = 1;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(35, 55);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtEmpleado.TabIndex = 2;
            this.txtEmpleado.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmpleado_Validating);
            this.txtEmpleado.Validated += new System.EventHandler(this.txtEmpleado_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoLimpiar);
            this.groupBox1.Controls.Add(this.rdoOrdenar);
            this.groupBox1.Controls.Add(this.rdoQuitar);
            this.groupBox1.Controls.Add(this.rdoInsertar);
            this.groupBox1.Controls.Add(this.rdoBuscar);
            this.groupBox1.Controls.Add(this.rdoAgregar);
            this.groupBox1.Location = new System.Drawing.Point(194, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 220);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acción";
            // 
            // rdoLimpiar
            // 
            this.rdoLimpiar.AutoSize = true;
            this.rdoLimpiar.Location = new System.Drawing.Point(22, 194);
            this.rdoLimpiar.Name = "rdoLimpiar";
            this.rdoLimpiar.Size = new System.Drawing.Size(58, 17);
            this.rdoLimpiar.TabIndex = 5;
            this.rdoLimpiar.Text = "Limpiar";
            this.rdoLimpiar.UseVisualStyleBackColor = true;
            // 
            // rdoOrdenar
            // 
            this.rdoOrdenar.AutoSize = true;
            this.rdoOrdenar.Location = new System.Drawing.Point(22, 159);
            this.rdoOrdenar.Name = "rdoOrdenar";
            this.rdoOrdenar.Size = new System.Drawing.Size(63, 17);
            this.rdoOrdenar.TabIndex = 4;
            this.rdoOrdenar.Text = "Ordenar";
            this.rdoOrdenar.UseVisualStyleBackColor = true;
            // 
            // rdoQuitar
            // 
            this.rdoQuitar.AutoSize = true;
            this.rdoQuitar.Location = new System.Drawing.Point(22, 124);
            this.rdoQuitar.Name = "rdoQuitar";
            this.rdoQuitar.Size = new System.Drawing.Size(53, 17);
            this.rdoQuitar.TabIndex = 3;
            this.rdoQuitar.Text = "Quitar";
            this.rdoQuitar.UseVisualStyleBackColor = true;
            // 
            // rdoInsertar
            // 
            this.rdoInsertar.AutoSize = true;
            this.rdoInsertar.Location = new System.Drawing.Point(22, 89);
            this.rdoInsertar.Name = "rdoInsertar";
            this.rdoInsertar.Size = new System.Drawing.Size(60, 17);
            this.rdoInsertar.TabIndex = 2;
            this.rdoInsertar.Text = "Insertar";
            this.rdoInsertar.UseVisualStyleBackColor = true;
            // 
            // rdoBuscar
            // 
            this.rdoBuscar.AutoSize = true;
            this.rdoBuscar.Location = new System.Drawing.Point(22, 54);
            this.rdoBuscar.Name = "rdoBuscar";
            this.rdoBuscar.Size = new System.Drawing.Size(58, 17);
            this.rdoBuscar.TabIndex = 1;
            this.rdoBuscar.Text = "Buscar";
            this.rdoBuscar.UseVisualStyleBackColor = true;
            // 
            // rdoAgregar
            // 
            this.rdoAgregar.AutoSize = true;
            this.rdoAgregar.Checked = true;
            this.rdoAgregar.Location = new System.Drawing.Point(22, 19);
            this.rdoAgregar.Name = "rdoAgregar";
            this.rdoAgregar.Size = new System.Drawing.Size(62, 17);
            this.rdoAgregar.TabIndex = 0;
            this.rdoAgregar.TabStop = true;
            this.rdoAgregar.Text = "Agregar";
            this.rdoAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(194, 322);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 4;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(274, 393);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoLimpiar;
        private System.Windows.Forms.RadioButton rdoOrdenar;
        private System.Windows.Forms.RadioButton rdoQuitar;
        private System.Windows.Forms.RadioButton rdoInsertar;
        private System.Windows.Forms.RadioButton rdoBuscar;
        private System.Windows.Forms.RadioButton rdoAgregar;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

