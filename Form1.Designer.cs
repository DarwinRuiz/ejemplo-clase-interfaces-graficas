namespace EjemploExploracion
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
            btnOperacion = new Button();
            textValor1 = new TextBox();
            textValor2 = new TextBox();
            valor1 = new Label();
            valor2 = new Label();
            resultado = new Label();
            resultOperacion = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnOperacion
            // 
            btnOperacion.Location = new Point(91, 223);
            btnOperacion.Name = "btnOperacion";
            btnOperacion.Size = new Size(160, 53);
            btnOperacion.TabIndex = 0;
            btnOperacion.Text = "Operar";
            btnOperacion.UseVisualStyleBackColor = true;
            btnOperacion.Click += btnOperacion_Click;
            // 
            // textValor1
            // 
            textValor1.Location = new Point(91, 97);
            textValor1.Name = "textValor1";
            textValor1.Size = new Size(160, 23);
            textValor1.TabIndex = 1;
            // 
            // textValor2
            // 
            textValor2.Location = new Point(91, 163);
            textValor2.Name = "textValor2";
            textValor2.Size = new Size(160, 23);
            textValor2.TabIndex = 2;
            // 
            // valor1
            // 
            valor1.AutoSize = true;
            valor1.CausesValidation = false;
            valor1.Font = new Font("Nirmala UI", 15F);
            valor1.Location = new Point(91, 66);
            valor1.Name = "valor1";
            valor1.Size = new Size(73, 28);
            valor1.TabIndex = 3;
            valor1.Text = "Valor 1";
            valor1.Click += label1_Click;
            // 
            // valor2
            // 
            valor2.AutoSize = true;
            valor2.CausesValidation = false;
            valor2.Font = new Font("Nirmala UI", 15F);
            valor2.Location = new Point(91, 132);
            valor2.Name = "valor2";
            valor2.Size = new Size(73, 28);
            valor2.TabIndex = 4;
            valor2.Text = "Valor 2";
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(332, 105);
            resultado.Name = "resultado";
            resultado.Size = new Size(0, 15);
            resultado.TabIndex = 5;
            // 
            // resultOperacion
            // 
            resultOperacion.AutoSize = true;
            resultOperacion.Font = new Font("Segoe UI", 20F);
            resultOperacion.Location = new Point(271, 82);
            resultOperacion.Name = "resultOperacion";
            resultOperacion.Size = new Size(147, 37);
            resultOperacion.TabIndex = 6;
            resultOperacion.Text = "Resultado: ";
            resultOperacion.Click += resultOperacion_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(497, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(264, 364);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(resultOperacion);
            Controls.Add(resultado);
            Controls.Add(valor2);
            Controls.Add(valor1);
            Controls.Add(textValor2);
            Controls.Add(textValor1);
            Controls.Add(btnOperacion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperacion;
        private TextBox textValor1;
        private TextBox textValor2;
        private Label valor1;
        private Label valor2;
        private Label resultado;
        private Label resultOperacion;
        private ListBox listBox1;
    }
}
