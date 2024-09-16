namespace WinFormsApp1
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
            botao = new Button();
            SuspendLayout();
            // 
            // entrada
            // 
            entrada.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entrada.Location = new Point(132, 77);
            entrada.Multiline = true;
            entrada.Name = "entrada";
            entrada.ScrollBars = ScrollBars.Vertical;
            entrada.Size = new Size(213, 119);
            entrada.TabIndex = 0;
            // 
            // saida
            // 
            saida.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saida.Location = new Point(525, 77);
            saida.Multiline = true;
            saida.Name = "saida";
            saida.ReadOnly = true;
            saida.ScrollBars = ScrollBars.Vertical;
            saida.Size = new Size(213, 119);
            saida.TabIndex = 1;
            // 
            // texto1
            // 
            texto1.AutoSize = true;
            texto1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texto1.Location = new Point(3, 98);
            texto1.Name = "texto1";
            texto1.Size = new Size(123, 32);
            texto1.TabIndex = 2;
            texto1.Text = "Entradas";
            // 
            // texto2
            // 
            texto2.AutoSize = true;
            texto2.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texto2.Location = new Point(370, 98);
            texto2.Name = "texto2";
            texto2.Size = new Size(149, 32);
            texto2.TabIndex = 3;
            texto2.Text = "N° de Leds";
            // 
            // botao
            // 
            botao.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botao.Location = new Point(356, 271);
            botao.Name = "botao";
            botao.Size = new Size(119, 73);
            botao.TabIndex = 4;
            botao.Text = "Enviar";
            botao.UseVisualStyleBackColor = true;
            botao.Click += botao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botao);
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
        private Button botao;
    }
}
