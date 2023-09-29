namespace LotecaTeToca1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;



            int[] randomNumbers = new int[3];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = new Random().Next(1, 11);

            }
            textBox1.Text = randomNumbers[0].ToString();
            textBox2.Text = randomNumbers[1].ToString();
            textBox3.Text = randomNumbers[2].ToString();

            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            int number3 = int.Parse(textBox3.Text);

            bool correct = true;
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                if (randomNumbers[i] != number1 && randomNumbers[i] != number2 && randomNumbers[i] != number3)
                {
                    correct = false;
                    break;
                }
            }
            if (correct)
            {
                textBox4.Text = "SOMO RICOOOO";
            }
            else 
            {
                textBox4.Text = "PERDITE PALOMON";
            }
        }


        private void OnButtonClick_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";


            int[] randomNumbers = new int[3];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = new Random().Next(1, 11);
            }


            textBox1.Text = randomNumbers[0].ToString();
            textBox2.Text = randomNumbers[1].ToString();
            textBox3.Text = randomNumbers[2].ToString();
        }
    }
}



