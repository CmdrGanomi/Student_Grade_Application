namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameInput = nameBox.Text;
            double englishInput = double.Parse(englishBox.Text);
            double mathInput = double.Parse(mathBox.Text);
            double scienceInput = double.Parse(scienceBox.Text);
            double filipinoInput = double.Parse(filipinoBox.Text);
            double historyInput = double.Parse(historyBox.Text);

            double averageOutput = (englishInput + mathInput + scienceInput + filipinoInput + historyInput) / 5;

            if (averageOutput >= 75)
            {

                labelShow.Text = "The student passed." + "\n" + nameInput + "'s average is " + averageOutput.ToString(".00") + ".";

            }
            else
            {
                labelShow.Text = "The student failed." + "\n" + nameInput + "'s average is " + averageOutput.ToString(".00") + "."; 
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}