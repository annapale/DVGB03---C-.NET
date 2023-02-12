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
        int calc;
        int result;

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

        private void buttonP_Click(object sender, EventArgs e)
        {
            nbr1 = Int32.Parse(input);
            input = "";
            textBoxInput.Text = "";
            textBoxOutput.Text = nbr1.ToString() + "+";
            calc = 1;
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            nbr1 = Int32.Parse(input);
            input = "";
            textBoxInput.Text = "";
            textBoxOutput.Text = nbr1.ToString() + "-";
            calc = 2;
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            nbr1 = Int32.Parse(input);
            input = "";
            textBoxInput.Text = "";
            textBoxOutput.Text = nbr1.ToString() + "*";
            calc = 3;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            nbr1 = Int32.Parse(input);
            input = "";
            textBoxInput.Text = "";
            textBoxOutput.Text = nbr1.ToString() + "/";
            calc = 4;
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            nbr2 = Int32.Parse(input);

            if(calc == 1)
            {
                result = nbr1 + nbr2; 
            }

            else if(calc == 2)
            {
                result = nbr1 - nbr2;
            }

            else if(calc == 3)
            {
                result = nbr1 * nbr2;
            }

            else if(calc == 4)
            {
                result = nbr1 / nbr2;
            }

            input = "";
            textBoxInput.Text = "";
            textBoxOutput.Text = result.ToString();
        }

        
    }
}