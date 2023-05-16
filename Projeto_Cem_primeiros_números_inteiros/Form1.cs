namespace Projeto_Cem_primeiros_números_inteiros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //limpa o ListBox
            istNumeros.Items.Clear();

            //declara e inicializa a variável controladora do laço
            int i = 1;

            do
            {
                //acrescenta o valor da variável i no ListBox
                istNumeros.Items.Add(i);

                //incrementa a variável controladora
                i++;

            } while (i <= 100);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //limpar os itens do ListBox
            istNumeros.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //limpa o ListBox
            istNumeros.Items.Clear();

            //declara e inicializa a variável controladora do laço
            int i = 1;

            while (i <= 100)
            {
                //acrescenta o valor da variável i no ListBox
                istNumeros.Items.Add(i);

                //incrementa a variável controladora
                i++;
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            //limpa o ListBox
            istNumeros.Items.Clear();

            //declaração da variável controladora do laço
            int i;

            for (i = 0; i <= 100; i++)
            {
                //acrescenta o valor da variável i no ListBox
                istNumeros.Items.Add(i);
            }

        }
    }
}