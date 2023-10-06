namespace KalkulackaInteraktiv
{
    public partial class Form1 : Form
    {
        double prvni; //Prvn� prom�nn� je pot�ebn� ve v�ech mo�nostech, deklaruji si ji tedy u� tady.
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonScitani_Click(object sender, EventArgs e) 
        //Tla��tko pro s��t�n�, rozhodla jsem se celou kalkula�ku ud�lat na desetinn� ��sla - double
        {
            prvni = Convert.ToDouble(textBox1.Text);
            double druhe = Convert.ToDouble(textBox2.Text);
            double soucet = prvni + druhe;
            textBoxResult.Text = soucet.ToString();
        }

        private void buttonOdcitani_Click(object sender, EventArgs e)
        //Mezi tla��tkem s��t�n�, od��t�n�, n�soben� a d�len� je jen jeden rozd�l - ve znam�nku ve t�et�m kroce.
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
            double mocnina = Math.Pow(prvni, druhe); //Matematick� funkce Math.Pow (power) n�m umocn� prvn� ��slo na druh�.
            textBoxResult.Text = mocnina.ToString();
        }

        private void buttonOdmocnina_Click(object sender, EventArgs e)
        //U druh� odmocniny n�m sta�� jedno ��slo, a to sice do prvn�ho textBoxu, u�ivatel to m� napsan� v instrukc�ch.
        {
            prvni = Convert.ToDouble(textBox1.Text);
            if (prvni >= 0) //Mus�me d�t podm�nku, �e ��slo mus� b�t v�t�� nebo rovno 0, proto�e z�porn� ��slo nem��eme odmocnit
            {
                double odmocnina = Math.Sqrt(prvni);
                //Matematick� funkce Math.Sqrt (square root) n�m vrac� kladnou hodnotu odmocniny ��sla, proto dopln�na o MessageBox, kde je �e�eno, �e mus�me po��tat i se z�pornou mo�nost�.
                textBoxResult.Text = odmocnina.ToString();
                MessageBox.Show($"Nezapome�, �e �e�en� je i v z�porn�ch ��slech, a to sice - {odmocnina}");
            }
            else
            {
                MessageBox.Show($"Nem��e� odmoc�ovat z�porn� ��slo...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int prvni) && prvni >= 0)
                //Zde jsem se nau�ila n�co o funkci TryParse d�ky ChatGPT
                //TryParse n�m p�ijme �et�zec a sna�� se jej p�ev�st na ��seln� datov� typ, pokud ��slo spl�uje podm�nky
                
            {
                string binarniCislo = Convert.ToString(prvni, 2); //P�evod na bin�rn� ��slo - pomoc d�ky ChatGPT
                textBoxResult.Text = binarniCislo.ToString();
            }
            else
            {
                MessageBox.Show("�patn� zadan� ��slo, zkus to znovu."); //Pokud u�ivatel zad� �patn� ��slo
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int prvni) && prvni>=0 )
            {
                string hexadecimalniCislo = Convert.ToString(prvni, 16); //P�evod na hexadecim�ln� ��slo, ostejn� jako u bin�rn�ho, ale m�sto 2 p�u 16
                textBoxResult.Text = hexadecimalniCislo;
            }
            else
            {
                MessageBox.Show("�patn� zadan� ��slo, zkus to znovu."); //Pokud u�ivatel zad� �patn� ��slo
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if (int.TryParse(textBox1.Text, out int prvni) && prvni >= 0)
            {
                string oktalniCislo = Convert.ToString(prvni, 8);//To stejn� jako u dvou p�evod� naho�e, ale pro okt�ln�, p�u tedy 8
                textBoxResult.Text = oktalniCislo;
            }
           else
            {
                MessageBox.Show("�patn� zadan� ��slo, zkus to znovu."); //Pokud u�ivatel zad� �patn� ��slo
            }
        }
    }
}