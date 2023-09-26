namespace KalkulackaInteraktiv
{
    public partial class Form1 : Form
    {
        int prvni;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonScitani_Click(object sender, EventArgs e)
        {
            prvni = Convert.ToInt32(textBox1.Text);
            int druhe = Convert.ToInt32(textBox2.Text);
            int soucet = prvni + druhe;
            textBoxResult.Text = soucet.ToString();
        }

        private void buttonOdcitani_Click(object sender, EventArgs e)
        {
            prvni = Convert.ToInt32(textBox1.Text);
           int druhe = Convert.ToInt32(textBox2.Text);
            int rozdil = prvni - druhe;
            textBoxResult.Text = rozdil.ToString();
        }

        private void buttonNasobeni_Click(object sender, EventArgs e)
        {
            prvni = Convert.ToInt32(textBox1.Text);
            int druhe = Convert.ToInt32(textBox2.Text);
            int soucin = prvni * druhe;
            textBoxResult.Text = soucin.ToString();
        }

        private void buttonDeleni_Click(object sender, EventArgs e)
        {
            prvni = Convert.ToInt32(textBox1.Text);
            int druhe = Convert.ToInt32(textBox2.Text);
            int podil = prvni / druhe;
            textBoxResult.Text = podil.ToString();
        }

        private void buttonMocnina_Click(object sender, EventArgs e)
        {
            prvni = Convert.ToInt32(textBox1.Text);
            double druhe = Convert.ToDouble(textBox2.Text);
            double mocnina = (Math.Pow(prvni, druhe);
                }
    }
}