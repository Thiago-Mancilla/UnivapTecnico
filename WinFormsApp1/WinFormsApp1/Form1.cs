namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao_Click(object sender, EventArgs e)
        {
            long quantidadeValores = long.Parse(entrada.Lines[0]);
            int index = 1;
            int soma = 0;
            int paraVazio = 1;
            saida.Text = "";
            /*for (i = 0; i < entrada.Lines.Length; i++)
            {
                string linhas = entrada.Lines[i].ToString();
                for (c = 0; c < linhas.Length; c++)
                {
                    if (linhas[c] == '0' || linhas[c] == '6' || linhas[c] == '9')
                        n += 6;
                    else if (linhas[c] == '1')
                        n += 2;
                    else if (linhas[c] == '2' || linhas[c] == '3' || linhas[c] == '5')
                        n += 5;
                    else if (linhas[c] == '4')
                        n += 4;
                    else if (linhas[c] == '7')
                        n += 3;
                    else if (linhas[c] == '8')
                        n += 7;
                }
                if(linhas != "")
                    saida.AppendText(n.ToString());
                saida.AppendText(Environment.NewLine);
                n = 0;

            }
            */
            if ((quantidadeValores <= 2000) && (quantidadeValores >= 1))
            {
                while (index <= quantidadeValores)
                {
                    string linhas = entrada.Lines[paraVazio].ToString();
                    if (linhas != "")
                    {
                        for (int c = 0; c < linhas.Length; c++)
                        {
                            if (linhas[c] == '0' || linhas[c] == '6' || linhas[c] == '9')
                                soma += 6;
                            else if (linhas[c] == '1')
                                soma += 2;
                            else if (linhas[c] == '2' || linhas[c] == '3' || linhas[c] == '5')
                                soma += 5;
                            else if (linhas[c] == '4')
                                soma += 4;
                            else if (linhas[c] == '7')
                                soma += 3;
                            else if (linhas[c] == '8')
                                soma += 7;
                        }
                        if(!(long.Parse(linhas) > 100000 || long.Parse(linhas) < 1))
                            saida.AppendText(soma + " Leds");
                        soma = 0;
                        index++;
                    }
                    paraVazio++;
                    if (index <= quantidadeValores && index != 1)
                        saida.AppendText(Environment.NewLine);
                }
                saida.AppendText(Environment.NewLine);
            }
        }
    }
}
