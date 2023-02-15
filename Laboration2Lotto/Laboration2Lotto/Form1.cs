namespace Laboration2Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] userNumbers = new int[7];
            int[] lotto = new int[7];

            int counter5Right = 0;
            int counter6Right = 0;
            int counter7Right = 0;

            Random rnd = new Random();

            try
            {
                int amountOfLotto = Int32.Parse(textAmountOfLotto.Text);

                //get user input
                userNumbers[0] = Int32.Parse(textBox1.Text);
                userNumbers[1] = Int32.Parse(textBox2.Text);
                userNumbers[2] = Int32.Parse(textBox3.Text);
                userNumbers[3] = Int32.Parse(textBox4.Text);
                userNumbers[4] = Int32.Parse(textBox5.Text);
                userNumbers[5] = Int32.Parse(textBox6.Text);
                userNumbers[6] = Int32.Parse(textBox7.Text);

                //checks for duplicates in userNumbers
                for (int j = 0; j < 7; j++)
                {
                    for (int k = 0; k < 7; k++)
                    {
                        int temp = userNumbers[j];
                        userNumbers[j] = 0;

                        if (temp == userNumbers[k])
                        {
                            throw new Exception("Nummer " + temp + " finns flera gånger");
                        }
                    }

                }

                for (int i = 0; i < amountOfLotto; i++)
                {
                    int counter = 0;

                    //generate 7 random numbers
                    for (int j = 0; j < 7; j++)
                    {
                        lotto[j] = rnd.Next(1, 36);
                    }

                    //checks for duplicates in lotto
                    for (int j = 0; j < 7; j++)
                    {
                        for (int k = 0; k < 7; k++)
                        {
                            int temp = lotto[j];
                            lotto[j] = 0;

                            while (temp == lotto[k])
                            {
                                temp = rnd.Next(1, 36);
                                // textBox8.Text += "*" + temp + "*";
                            }

                            lotto[j] = temp;
                        }
                    }

                    //compares userNumbers and lotto to find duplicates
                    for (int j = 0; j < 7; j++)
                    {
                        for (int k = 0; k < 7; k++)
                        {
                            if (userNumbers[j] == lotto[k])
                            {
                                counter++;
                            }
                        }
                    }

                    if (counter == 5)
                    {
                        counter5Right++;
                    }

                    if (counter == 6)
                    {
                        counter6Right++;
                    }

                    if (counter == 7)
                    {
                        counter7Right++;
                    }
                }

                textCounter5.Text = counter5Right.ToString();
                textCounter6.Text = counter6Right.ToString();
                textCounter7.Text = counter7Right.ToString();
                
            }

            catch (Exception ex)
            {
                textError.Text = ex.Message;
            }
            

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}