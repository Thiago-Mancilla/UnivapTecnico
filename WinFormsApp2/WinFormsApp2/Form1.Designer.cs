namespace WinFormsApp2
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
            texto2 = new Label();
            texto1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // entrada
            // 
            entrada.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entrada.Location = new Point(121, 88);
            entrada.Multiline = true;
            entrada.Name = "entrada";
            entrada.ScrollBars = ScrollBars.Both;
            entrada.Size = new Size(236, 140);
            entrada.TabIndex = 0;
            // 
            // saida
            // 
            saida.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saida.Location = new Point(595, 88);
            saida.Multiline = true;
            saida.Name = "saida";
            saida.ReadOnly = true;
            saida.ScrollBars = ScrollBars.Vertical;
            saida.Size = new Size(100, 140);
            saida.TabIndex = 1;
            // 
            // texto2
            // 
            texto2.AutoSize = true;
            texto2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texto2.Location = new Point(431, 86);
            texto2.Name = "texto2";
            texto2.Size = new Size(158, 22);
            texto2.TabIndex = 2;
            texto2.Text = "Peso da posição:";
            // 
            // texto1
            // 
            texto1.AutoSize = true;
            texto1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texto1.Location = new Point(40, 88);
            texto1.Name = "texto1";
            texto1.Size = new Size(75, 22);
            texto1.TabIndex = 3;
            texto1.Text = "Entrada";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(359, 300);
            button1.Name = "button1";
            button1.Size = new Size(95, 39);
            button1.TabIndex = 4;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(texto1);
            Controls.Add(texto2);
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
        private Label texto2;
        private Label texto1;
        private Button button1;
    }
}
