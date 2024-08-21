namespace Ejercicio_3__Solo_una_clase_
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
            btnResumen = new Button();
            btnRegistrar = new Button();
            lbResultados = new ListBox();
            SuspendLayout();
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(731, 103);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(137, 56);
            btnResumen.TabIndex = 5;
            btnResumen.Text = "Ver Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(731, 25);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(137, 56);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar Viaje";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lbResultados
            // 
            lbResultados.FormattingEnabled = true;
            lbResultados.ItemHeight = 17;
            lbResultados.Location = new Point(14, 14);
            lbResultados.Name = "lbResultados";
            lbResultados.Size = new Size(686, 514);
            lbResultados.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 532);
            Controls.Add(btnResumen);
            Controls.Add(btnRegistrar);
            Controls.Add(lbResultados);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Peaje";
            ResumeLayout(false);
        }

        #endregion

        private Button btnResumen;
        private Button btnRegistrar;
        private ListBox lbResultados;
    }
}
