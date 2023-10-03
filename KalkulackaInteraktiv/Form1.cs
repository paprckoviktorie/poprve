namespace KalkulackaInteraktiv
{
    public partial class Form1 : Form
    {
        double prvni;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonScitani_Click(object sender, EventArgs e)
        {
            prvni = Convert.ToDouble(textBox1.Text);
            double druhe = Convert.ToDouble(textBox2.Text);
            double soucet = prvni + druhe;
            textBoxResult.Text = soucet.ToString();
        }

        private void buttonOdcitani_Click(object sender, EventArgs e)
        {
            prvni = Convert.ToDouble(textBox1.Text);
           double druhe = Convert.ToDouble(textBox2.Text);
            double rozdil = prvni - druhe;
            textBoxResult.Text = rozdil.ToString();
        }

        private void buttonNasobeni_Click(object sender, EventArgs e)
        {
            prvni = Convert.ToDouble(textBox1.Text);
            double druhe = Convert.ToDouble(textBox2.Text);
            double soucin = prvni * druhe;
            textBoxResult.Text = soucin.ToString();
        }

        private void buttonDeleni_Click(object sender, EventArgs e)
        {
            prvni = Convert.ToDouble(textBox1.Text);
            double druhe = Convert.ToDouble(textBox2.Text);
            double podil = prvni / druhe;
            textBoxResult.Text = podil.ToString();
        }

        private void buttonMocnina_Click(object sender, EventArgs e)
        {
            prvni = Convert.ToDouble(textBox1.Text);
            double druhe = Convert.ToDouble(textBox2.Text);
            double mocnina = Math.Pow(prvni, druhe); //Matematick� funkce Math.Pow (power) n�m umocn� prvn� ��slo na druh�
            textBoxResult.Text = mocnina.ToString();
        }

        private void buttonOdmocnina_Click(object sender, EventArgs e)
        {
            prvni = Convert.ToDouble(textBox1.Text);
            double odmocnina = Math.Sqrt(prvni);
            textBoxResult.Text = odmocnina.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           //Omyl, ale boj�m se to odstranit, aby se mi nepokazil k�d
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int prvni) && prvni >= 0) //Zde jsem se nau�ila n�co o funkci Parse a TryParse d�ky chatGPT
            {
                string binarniCislo = Convert.ToString(prvni, 2);
                textBoxResult.Text = binarniCislo.ToString();
            }
        }
    }
}