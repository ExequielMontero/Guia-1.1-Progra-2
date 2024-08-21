namespace ejercicio_1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nuModelo = new System.Windows.Forms.NumericUpDown();
            this.nuAño = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFabricacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVida = new System.Windows.Forms.TextBox();
            this.tbDepreciacion = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuAño)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(110, 257);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 41);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Costo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(110, 37);
            this.tbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(148, 22);
            this.tbMarca.TabIndex = 2;
            this.tbMarca.TextChanged += new System.EventHandler(this.tbMarca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca:";
            // 
            // nuModelo
            // 
            this.nuModelo.Location = new System.Drawing.Point(153, 85);
            this.nuModelo.Margin = new System.Windows.Forms.Padding(4);
            this.nuModelo.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nuModelo.Minimum = new decimal(new int[] {
            1956,
            0,
            0,
            0});
            this.nuModelo.Name = "nuModelo";
            this.nuModelo.Size = new System.Drawing.Size(102, 22);
            this.nuModelo.TabIndex = 5;
            this.nuModelo.Value = new decimal(new int[] {
            1975,
            0,
            0,
            0});
            // 
            // nuAño
            // 
            this.nuAño.Location = new System.Drawing.Point(152, 128);
            this.nuAño.Margin = new System.Windows.Forms.Padding(4);
            this.nuAño.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nuAño.Minimum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nuAño.Name = "nuAño";
            this.nuAño.Size = new System.Drawing.Size(104, 22);
            this.nuAño.TabIndex = 6;
            this.nuAño.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Año a calcular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modelo(año):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor de fabricacion $:";
            // 
            // tbFabricacion
            // 
            this.tbFabricacion.Location = new System.Drawing.Point(198, 174);
            this.tbFabricacion.Margin = new System.Windows.Forms.Padding(4);
            this.tbFabricacion.Name = "tbFabricacion";
            this.tbFabricacion.Size = new System.Drawing.Size(148, 22);
            this.tbFabricacion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tasa de depreciacion:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vida Util (años):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbVida
            // 
            this.tbVida.Location = new System.Drawing.Point(418, 122);
            this.tbVida.Margin = new System.Windows.Forms.Padding(4);
            this.tbVida.Name = "tbVida";
            this.tbVida.Size = new System.Drawing.Size(148, 22);
            this.tbVida.TabIndex = 14;
            // 
            // tbDepreciacion
            // 
            this.tbDepreciacion.Location = new System.Drawing.Point(451, 76);
            this.tbDepreciacion.Margin = new System.Windows.Forms.Padding(4);
            this.tbDepreciacion.Name = "tbDepreciacion";
            this.tbDepreciacion.Size = new System.Drawing.Size(148, 22);
            this.tbDepreciacion.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(355, 257);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 41);
            this.button3.TabIndex = 16;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 311);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbDepreciacion);
            this.Controls.Add(this.tbVida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFabricacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nuAño);
            this.Controls.Add(this.nuModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.btnCalcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calcular";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nuModelo;
        private System.Windows.Forms.NumericUpDown nuAño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFabricacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVida;
        private System.Windows.Forms.TextBox tbDepreciacion;
        private System.Windows.Forms.Button button3;
    }
}

