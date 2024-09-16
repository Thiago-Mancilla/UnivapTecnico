namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            int eixoX = 0;
            int eixoY = 0;
            int peso = 0;
            saida.Text = "";
            for (int c = 0; c < entrada.Lines.Length; c++)
            {
                if (c == 0)
                    n = int.Parse(entrada.Lines[c]);
                else if (c == 1)                    
                    eixoX = int.Parse(entrada.Lines[c]);  
                else if (c == 2)
                    eixoY = int.Parse(entrada.Lines[c]);
                else
                {
                    string linha = entrada.Lines[c];
                    int linhaNumerica = int.Parse(linha);
                    string algarismoString = linhaNumerica.ToString();
                    int algorismoInt = (int) algarismoString[eixoX - 1];
                    if (algorismoInt == 48)
                        algorismoInt = 0;
                    else if (algorismoInt == 49)
                        algorismoInt = 1;
                    else if (algorismoInt == 50)
                        algorismoInt = 2;
                    else if (algorismoInt == 51)
                        algorismoInt = 3;
                    else if (algorismoInt == 52)
                        algorismoInt = 4;
                    else if (algorismoInt == 53)
                        algorismoInt = 5;
                    else if (algorismoInt == 54)
                        algorismoInt = 6;
                    else if (algorismoInt == 55)
                        algorismoInt = 7;
                    else if (algorismoInt == 56)
                        algorismoInt = 8;
                    else if (algorismoInt == 57)
                        algorismoInt = 9;
                    if (c - 3 != eixoX - 1)
                        peso += algorismoInt;
                    saida.AppendText(peso + Environment.NewLine);

                }
                //saida.Text = peso.ToString();
            }
            
            
        }
    }
}
