namespace Laboration2Miniräknare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string input;
        int nbr1;
        int nbr2;
        int counter;
        int result;
        int calc;

        public int calculate()
        {
            if (calc == 1)
            {
                result = nbr1 + nbr2;
            }

            else if (calc == 2)
            {
                result = nbr1 - nbr2;
            }

            else if (calc == 3)
            {
                result = nbr1 * nbr2;
            }

            else if (calc == 4)
            {
                result = nbr1 / nbr2;
            }

            nbr1 = result;
            nbr2 = 0;

            //calc = 0;

            return result;
        }

        //ADDITION
        private void buttonP_Click(object sender, EventArgs e)
        {
            //calc = 1;

            counter++;

            if (counter == 1)
            {
                calc = 1;
                nbr1 = Int32.Parse(input);
                textBoxOutput.Text = input + "+";
            }
            else
            {
                nbr2 = Int32.Parse(input);
                result = calculate();
                textBoxOutput.Text = result.ToString();
                calc = 1;
            }

            input = "";
            textBoxInput.Text = "";


        }

        //SUBTRACTION
        private void buttonM_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                input = "-";
            }
            counter++;

            if (counter == 1)
            {
                calc = 2;
                nbr1 = Int32.Parse(input);
                textBoxOutput.Text = input + "-";
            }
            else
            {
                nbr2 = Int32.Parse(input);
                result = calculate();
                textBoxOutput.Text = result.ToString();
                calc = 2;
            }

            input = "";
            textBoxInput.Text = "";

        }

        //MULTIPLICATION
        private void buttonX_Click(object sender, EventArgs e)
        {
            //calc = 3;

            counter++;

            if (counter == 1)
            {
                calc = 3;
                nbr1 = Int32.Parse(input);
                textBoxOutput.Text = input + "*";
            }
            else
            {
                nbr2 = Int32.Parse(input);
                result = calculate();
                textBoxOutput.Text = result.ToString();
                calc = 3;
            }

            input = "";
            textBoxInput.Text = "";
        }

        //DIVISION
        private void buttonD_Click(object sender, EventArgs e)
        {
            //calc = 4;

            counter++;

            if (counter == 1)
            {
                calc = 4;
                nbr1 = Int32.Parse(input);
                textBoxOutput.Text = input + "/";
            }
            else
            {
                nbr2 = Int32.Parse(input);
                result = calculate();
                textBoxOutput.Text = result.ToString();
                calc = 4;
            }
            input = "";
            textBoxInput.Text = "";
        }

        //EQUALS
        private void buttonE_Click(object sender, EventArgs e)
        {
            nbr2 = Int32.Parse(input);
            result = calculate();
            textBoxOutput.Text = result.ToString();

            nbr1 = 0;
            nbr2 = 0;

            counter = 0;

            input = "";
            textBoxInput.Text = "";
        }

        //CLEAR
        private void buttonC_Click(object sender, EventArgs e)
        {
            input = "";
            nbr1 = 0;
            nbr2 = 0;
            textBoxInput.Text = "";
            textBoxOutput.Text = "";
            counter = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input += 1;
            textBoxInput.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input += 2;
            textBoxInput.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input += 3;
            textBoxInput.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input += 4;
            textBoxInput.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input += 5;
            textBoxInput.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input += 6;
            textBoxInput.Text = input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += 7;
            textBoxInput.Text = input;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            input += 8;
            textBoxInput.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input += 9;
            textBoxInput.Text = input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            input += 0;
            textBoxInput.Text = input;
        }

       
    }
}