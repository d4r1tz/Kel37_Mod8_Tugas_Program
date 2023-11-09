using TempConvComp;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        TempConvComp.Class1 conv = new TempConvComp.Class1();

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = true;
            textBox4.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                double celcius = double.Parse(textBox1.Text);
                List<double> res = conv.CelciusToAll(celcius);
                textBox2.Text = res[0].ToString();
                textBox3.Text = res[1].ToString();
                textBox4.Text = res[2].ToString();

            }
            else if (radioButton2.Checked == true)
            {
                double reamur = double.Parse(textBox2.Text);
                List<double> res = conv.ReamurToAll(reamur);
                textBox1.Text = res[0].ToString();
                textBox3.Text = res[1].ToString();
                textBox4.Text = res[2].ToString();
            }
            else if (radioButton3.Checked == true)
            {
                double fahrenheit = double.Parse(textBox3.Text);
                List<double> res = conv.FahrenheitToAll(fahrenheit);
                textBox1.Text = res[0].ToString();
                textBox2.Text = res[1].ToString();
                textBox4.Text = res[2].ToString();
            }
            else if (radioButton4.Checked == true)
            {
                double kelvin = double.Parse(textBox4.Text);
                List<double> res = conv.KelvinToAll(kelvin);
                textBox1.Text = res[0].ToString();
                textBox2.Text = res[1].ToString();
                textBox3.Text = res[2].ToString();
            }
        }
    }
}