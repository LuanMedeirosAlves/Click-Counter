namespace Contador_Click
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        int contadorCliques = 0;

        private void button1_Click(object sender, EventArgs e)
        {         
            contadorCliques += 1;

            button1.Text = "Clicado " + contadorCliques + " vezes!";
        }
    }
}