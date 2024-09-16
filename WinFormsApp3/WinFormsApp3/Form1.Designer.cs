namespace WinFormsApp3
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
            entrada = new TextBox();
            saida = new TextBox();
            texto1 = new Label();
            texto2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // entrada
            // 
            entrada.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entrada.Location = new Point(156, 79);
            entrada.Name = "entrada";
            entrada.Size = new Size(100, 22);
            entrada.TabIndex = 0;
            // 
            // saida
            // 
            saida.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saida.Location = new Point(449, 79);
            saida.Multiline = true;
            saida.Name = "saida";
            saida.ReadOnly = true;
            saida.ScrollBars = ScrollBars.Vertical;
            saida.Size = new Size(192, 92);
            saida.TabIndex = 1;
            // 
            // texto1
            // 
            texto1.AutoSize = true;
            texto1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texto1.Location = new Point(12, 51);
            texto1.Name = "texto1";
            texto1.Size = new Size(181, 25);
            texto1.TabIndex = 2;
            texto1.Text = "N° máximo de pontos";
            texto1.Click += label1_Click;
            // 
            // texto2
            // 
            texto2.AutoSize = true;
            texto2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texto2.Location = new Point(342, 51);
            texto2.Name = "texto2";
            texto2.Size = new Size(147, 25);
            texto2.TabIndex = 3;
            texto2.Text = "Pontos fatorados";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(342, 263);
            button1.Name = "button1";
            button1.Size = new Size(109, 54);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(texto2);
            Controls.Add(texto1);
            Controls.Add(saida);
            Controls.Add(entrada);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox entrada;
        private TextBox saida;
        private Label texto1;
        private Label texto2;
        private Button button1;
    }
}
