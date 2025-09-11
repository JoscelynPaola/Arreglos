namespace arreglos_1_
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
            label1 = new Label();
            btnCargarMatriz = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "INGRESA 9 NÚMROS";
            // 
            // btnCargarMatriz
            // 
            btnCargarMatriz.Location = new Point(12, 52);
            btnCargarMatriz.Name = "btnCargarMatriz";
            btnCargarMatriz.Size = new Size(138, 23);
            btnCargarMatriz.TabIndex = 1;
            btnCargarMatriz.Text = "INGRESAR NÚMEROS";
            btnCargarMatriz.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(18, 103);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(73, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "RESULTADO:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCargarMatriz);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCargarMatriz;
        private Label lblResultado;
    }
}
