using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void buttonSonra_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonSonra.Enabled = true;

            soruno++;
            labelSoruno.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "cumhuriyet ka� y�l�nda ilan edilmi�tir?";
                buttonA.Text = "1920";
                buttonB.Text = "1921";
                buttonC.Text = "1922";
                buttonD.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno == 2)

            {
                richTextBox1.Text = "hangisi egede yoktur.?  ";
                buttonA.Text = "ankara";
                buttonB.Text = "BURSA";
                buttonC.Text = "KAYSER�";
                buttonD.Text = "�ZM�R";
                label4.Text = "KAYSER�";

            }
            if (soruno == 3)

            {
                richTextBox1.Text = "son ku�lar�n yazar� kimdir?";
                buttonA.Text = "sait faik";
                buttonB.Text = "SIRRIII";
                buttonC.Text = "POLAT";
                buttonD.Text = "s�leyman ";
                label4.Text = "POLAT";
                buttonSonra.Text = "sonu�lar";

            }
            if (soruno == 4)

            {
                richTextBox1.Text = "hangisi renktir?";
                buttonA.Text = "A";
                buttonB.Text = "B";
                buttonC.Text = "C";
                buttonD.Text = "YE��L";
                label4.Text = "YE��L";
                buttonSonra.Text = "sonu�lar";
            }
            if (soruno == 5)
            {
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonSonra.Enabled = false;
                MessageBox.Show("do�ru : " + dogru + "\n" + "yanl��:" + yanlis);
            }




        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            label5.Text = buttonA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanl�s.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            label5.Text = buttonB.Text;

            if (label4.Text == label5.Text)

            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanl�s.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            label5.Text = buttonC.Text;

            if (label4.Text == label5.Text)

            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanl�s.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            label5.Text = buttonD.Text;

            if (label4.Text == label5.Text)

            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanl�s.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
