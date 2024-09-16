namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(entrada.Text);
            int c2 = 0;
            int c3 = 0;
            int c5 = 0;
            int c7 = 0;
            int i = 0;
            saida.Text = "";
            if (!(n < 1 || n > 1000))
            {
                
                
                while (n%2 == 0 && n != 2)
                {
                    n /= 2;
                    c2++;
                }
                while (n%3 == 0 && n != 3)
                {
                    n /= 3;
                    c3++;
                }
                while (n%5 == 0 && n != 5)
                {
                    n /= 5;
                    c5++;
                }
                while (n % 7 == 0 && n != 7)
                {
                    n /= 7;
                    c7++;
                }
                saida.AppendText(n + Environment.NewLine);
                for (i=1; i<= c7; i++)
                {
                    n *= 7;
                    saida.AppendText(n + Environment.NewLine);
                }
                for (i = 1; i <= c5; i++)
                {
                    n *= 5;
                    saida.AppendText(n + Environment.NewLine);
                }
                for (i = 1; i <= c3; i++)
                {
                    n *= 3;
                    saida.AppendText(n + Environment.NewLine);
                }
                for (i = 1; i <= c2; i++)
                {
                    n *= 2;
                    saida.AppendText(n + Environment.NewLine);
                }
            }
        }
    }
}
