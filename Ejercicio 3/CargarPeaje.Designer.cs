namespace Ejercicio_3
{
    partial class CargarPeaje
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
            nuDias = new NumericUpDown();
            tbAutos = new TextBox();
            btnAceptar = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nuDias).BeginInit();
            SuspendLayout();
            // 
            // nuDias
            // 
            nuDias.Location = new Point(76, 31);
            nuDias.Margin = new Padding(4, 3, 4, 3);
            nuDias.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nuDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nuDias.Name = "nuDias";
            nuDias.Size = new Size(120, 22);
            nuDias.TabIndex = 1;
            nuDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tbAutos
            // 
            tbAutos.Location = new Point(142, 98);
            tbAutos.Margin = new Padding(4, 3, 4, 3);
            tbAutos.Name = "tbAutos";
            tbAutos.Size = new Size(100, 22);
            tbAutos.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(34, 189);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 24);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(230, 189);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 24);
            button2.TabIndex = 4;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 33);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 16);
            label2.TabIndex = 0;
            label2.Text = "Dias:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 98);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 16);
            label3.TabIndex = 5;
            label3.Text = "Cantidad Autos:";
            // 
            // CargarPeaje
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 238);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(btnAceptar);
            Controls.Add(tbAutos);
            Controls.Add(nuDias);
            Controls.Add(label2);
            Font = new Font("Berlin Sans FB Demi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CargarPeaje";
            Text = "CargarPeaje";
            ((System.ComponentModel.ISupportInitialize)nuDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        private Button button2;
        private Label label2;
        private Label label3;
        public NumericUpDown nuDias;
        public TextBox tbAutos;
    }
}