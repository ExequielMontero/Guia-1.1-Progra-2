namespace Ejercicio_3__Solo_una_clase_
{
    partial class Resultados
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
            label3 = new Label();
            button2 = new Button();
            btnAceptar = new Button();
            tbAutos = new TextBox();
            nuDias = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nuDias).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 101);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 17);
            label3.TabIndex = 11;
            label3.Text = "Cantidad Autos:";
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(196, 204);
            button2.Margin = new Padding(5, 3, 5, 3);
            button2.Name = "button2";
            button2.Size = new Size(86, 27);
            button2.TabIndex = 10;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(18, 204);
            btnAceptar.Margin = new Padding(5, 3, 5, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 27);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // tbAutos
            // 
            tbAutos.Location = new Point(142, 101);
            tbAutos.Margin = new Padding(5, 3, 5, 3);
            tbAutos.Name = "tbAutos";
            tbAutos.Size = new Size(114, 25);
            tbAutos.TabIndex = 8;
            // 
            // nuDias
            // 
            nuDias.Location = new Point(66, 25);
            nuDias.Margin = new Padding(5, 3, 5, 3);
            nuDias.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nuDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nuDias.Name = "nuDias";
            nuDias.Size = new Size(137, 25);
            nuDias.TabIndex = 7;
            nuDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 27);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 6;
            label2.Text = "Dias:";
            // 
            // Resultados
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 257);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(btnAceptar);
            Controls.Add(tbAutos);
            Controls.Add(nuDias);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Resultados";
            Text = "Resultados";
            ((System.ComponentModel.ISupportInitialize)nuDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button2;
        private Button btnAceptar;
        public TextBox tbAutos;
        public NumericUpDown nuDias;
        private Label label2;
    }
}