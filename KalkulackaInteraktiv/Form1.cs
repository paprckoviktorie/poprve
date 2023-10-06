namespace KalkulackaInteraktiv
{
    public partial class Form1 : Form
    {
        double prvni; //První promìnná je potøebná ve všech možnostech, deklaruji si ji tedy už tady.
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonScitani_Click(object sender, EventArgs e) 
        //Tlaèítko pro sèítání, rozhodla jsem se celou kalkulaèku udìlat na desetinná èísla - double
        {
            prvni = Convert.ToDouble(textBox1.Text);
            double druhe = Convert.ToDouble(textBox2.Text);
            double soucet = prvni + druhe;
            textBoxResult.Text = soucet.ToString();
        }

        private void buttonOdcitani_Click(object sender, EventArgs e)
        //Mezi tlaèítkem sèítání, odèítání, násobení a dìlení je jen jeden rozdíl - ve znaménku ve tøetím kroce.
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
            double mocnina = Math.Pow(prvni, druhe); //Matematická funkce Math.Pow (power) nám umocní první èíslo na druhé.
            textBoxResult.Text = mocnina.ToString();
        }

        private void buttonOdmocnina_Click(object sender, EventArgs e)
        //U druhé odmocniny nám staèí jedno èíslo, a to sice do prvního textBoxu, uživatel to má napsané v instrukcích.
        {
            prvni = Convert.ToDouble(textBox1.Text);
            if (prvni >= 0) //Musíme dát podmínku, že èíslo musí být vìtší nebo rovno 0, protože záporné èíslo nemùžeme odmocnit
            {
                double odmocnina = Math.Sqrt(prvni);
                //Matematická funkce Math.Sqrt (square root) nám vrací kladnou hodnotu odmocniny èísla, proto doplnìna o MessageBox, kde je øeèeno, že musíme poèítat i se zápornou možností.
                textBoxResult.Text = odmocnina.ToString();
                MessageBox.Show($"Nezapomeò, že øešení je i v záporných èíslech, a to sice - {odmocnina}");
            }
            else
            {
                MessageBox.Show($"Nemùžeš odmocòovat záporné èíslo...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int prvni) && prvni >= 0)
                //Zde jsem se nauèila nìco o funkci TryParse díky ChatGPT
                //TryParse nám pøijme øetìzec a snaží se jej pøevést na èíselný datový typ, pokud èíslo splòuje podmínky
                
            {
                string binarniCislo = Convert.ToString(prvni, 2); //Pøevod na binární èíslo - pomoc díky ChatGPT
                textBoxResult.Text = binarniCislo.ToString();
            }
            else
            {
                MessageBox.Show("Špatnì zadané èíslo, zkus to znovu."); //Pokud uživatel zadá špatnì èíslo
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int prvni) && prvni>=0 )
            {
                string hexadecimalniCislo = Convert.ToString(prvni, 16); //Pøevod na hexadecimální èíslo, ostejnì jako u binárního, ale místo 2 píšu 16
                textBoxResult.Text = hexadecimalniCislo;
            }
            else
            {
                MessageBox.Show("Špatnì zadané èíslo, zkus to znovu."); //Pokud uživatel zadá špatnì èíslo
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if (int.TryParse(textBox1.Text, out int prvni) && prvni >= 0)
            {
                string oktalniCislo = Convert.ToString(prvni, 8);//To stejné jako u dvou pøevodù nahoøe, ale pro oktální, píšu tedy 8
                textBoxResult.Text = oktalniCislo;
            }
           else
            {
                MessageBox.Show("Špatnì zadané èíslo, zkus to znovu."); //Pokud uživatel zadá špatnì èíslo
            }
        }
    }
}