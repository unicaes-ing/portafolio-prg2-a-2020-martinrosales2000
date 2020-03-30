namespace Segundo_Periodo
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
            this.lstVendedores = new System.Windows.Forms.ListBox();
            this.btnOrdenar1 = new System.Windows.Forms.Button();
            this.btnOrdenar2 = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVendedores
            // 
            this.lstVendedores.FormattingEnabled = true;
            this.lstVendedores.Items.AddRange(new object[] {
            "Jorge",
            "María",
            "Daniel",
            "Pedro",
            "José ",
            "Lucila",
            "Juana",
            "Francisca",
            "Ivan",
            "Sofia "});
            this.lstVendedores.Location = new System.Drawing.Point(70, 55);
            this.lstVendedores.Name = "lstVendedores";
            this.lstVendedores.Size = new System.Drawing.Size(182, 290);
            this.lstVendedores.TabIndex = 0;
            // 
            // btnOrdenar1
            // 
            this.btnOrdenar1.Location = new System.Drawing.Point(292, 64);
            this.btnOrdenar1.Name = "btnOrdenar1";
            this.btnOrdenar1.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar1.TabIndex = 1;
            this.btnOrdenar1.Text = "Ordenar A-Z";
            this.btnOrdenar1.UseVisualStyleBackColor = true;
            this.btnOrdenar1.Click += new System.EventHandler(this.btnOrdenar1_Click);
            // 
            // btnOrdenar2
            // 
            this.btnOrdenar2.Location = new System.Drawing.Point(292, 129);
            this.btnOrdenar2.Name = "btnOrdenar2";
            this.btnOrdenar2.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar2.TabIndex = 2;
            this.btnOrdenar2.Text = "Ordenar Z-A";
            this.btnOrdenar2.UseVisualStyleBackColor = true;
            this.btnOrdenar2.Click += new System.EventHandler(this.btnOrdenar2_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(292, 186);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(292, 292);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(306, 329);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 389);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnOrdenar2);
            this.Controls.Add(this.btnOrdenar1);
            this.Controls.Add(this.lstVendedores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVendedores;
        private System.Windows.Forms.Button btnOrdenar1;
        private System.Windows.Forms.Button btnOrdenar2;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
    }
}

