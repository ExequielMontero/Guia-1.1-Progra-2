namespace Ejercicio_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbResultados = new ListBox();
            btnRegistrar = new Button();
            btnResumen = new Button();
            SuspendLayout();
            // 
            // lbResultados
            // 
            lbResultados.FormattingEnabled = true;
            lbResultados.ItemHeight = 17;
            lbResultados.Location = new Point(14, 33);
            lbResultados.Name = "lbResultados";
            lbResultados.Size = new Size(601, 463);
            lbResultados.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(642, 43);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(120, 49);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar Viaje";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(642, 112);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(120, 49);
            btnResumen.TabIndex = 2;
            btnResumen.Text = "Ver Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 510);
            Controls.Add(btnResumen);
            Controls.Add(btnRegistrar);
            Controls.Add(lbResultados);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Peaje";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbResultados;
        private Button btnRegistrar;
        private Button btnResumen;
    }
}
