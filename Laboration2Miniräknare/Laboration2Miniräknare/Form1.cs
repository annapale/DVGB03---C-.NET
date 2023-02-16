namespace Laboration2Miniräknare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string input;
        int? nbr1;
        int? nbr2 = null;
        int calc;

        public int? calculate()
        {
            try
            {
                // determines what operation should be performed
                switch (calc)
                {
                    case 1:
                        return nbr1 + nbr2;
                    case 2:
                        return nbr1 - nbr2;
                    case 3:
                        return nbr1 * nbr2;
                    case 4:
                        return nbr1 / nbr2;
                    default:
                        MessageBox.Show("Something went wrong, try again");
                        return 0;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return null;
            }   
        }
        
        public void saveResult(int? result)
        {
            nbr1 = result;
            nbr2 = 0;
        }

        //ADDITION
        private void buttonP_Click(object sender, EventArgs e)
        {
            if (nbr2 == null)
            {
                calc = 1;
                try
                {
                    nbr1 = Int32.Parse(input);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                textBoxOutput.Text = input + "+";
                nbr2 = 0;
            }
            else
            {
                try
                {
                    nbr2 = Int32.Parse(input);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);    
                }

                int? result = calculate();
                saveResult(result);

                textBoxOutput.Text = result.ToString();
                calc = 1;
            }

            input = "";
            textBoxInput.Text = "";
        }

        //SUBTRACTION
        private void buttonM_Click(object sender, EventArgs e)
        {
            if (nbr2 == null)
            {
                calc = 2;
                try
                {
                    nbr1 = Int32.Parse(input);
                }
                catch
                {
                    textBoxOutput.Text = "-";
                }
                textBoxOutput.Text = "-";
                nbr2 = 0;
            }
            else
            {
                try
                {
                    nbr2 = Int32.Parse(input);
                }
                catch
                {
                    textBoxOutput.Text = "-";
                }

                int? result = calculate();
                saveResult(result);
                    
                //textBoxOutput.Text = result.ToString();
                calc = 2;
            }
            input = "";
            textBoxInput.Text = "";
            

        }

        //MULTIPLICATION
        private void buttonX_Click(object sender, EventArgs e)
        {


            if (nbr2 == null)
            {
                calc = 3;
                try
                {
                    nbr1 = Int32.Parse(input);
                }
                catch
                {
                    MessageBox.Show("Wrong input, try again");
                }
                textBoxOutput.Text = "*";
                nbr2 = 0;
            }
            else
            {
                try
                {
                    nbr2 = Int32.Parse(input);
                }
                catch
                {
                    MessageBox.Show("Wrong input, try again");
                }
                int? result = calculate();
                saveResult(result);

                //textBoxOutput.Text = result.ToString();
                calc = 3;
            }

            input = "";
            textBoxInput.Text = "";
            
        }

        //DIVISION
        private void buttonD_Click(object sender, EventArgs e)
        {
           
            if (nbr2 == null)
            {
                calc = 4;
                try
                {
                    nbr1 = Int32.Parse(input);
                }
                catch
                {
                    MessageBox.Show("Wrong input, try again");
                }
                textBoxOutput.Text = "/";
                nbr2 = 0;
            }
            else
            {
                try
                {
                    nbr2 = Int32.Parse(input);
                }
                catch
                {
                    MessageBox.Show("Wrong input, try again");
                }
                int? result = calculate();
                saveResult(result);
                //textBoxOutput.Text = result.ToString();
                calc = 4;
            }
            input = "";
            textBoxInput.Text = "";
       
        }

        //EQUALS
        private void buttonE_Click(object sender, EventArgs e)
        {
            try
            {
                nbr2 = Int32.Parse(input);
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            int? result = calculate();
            saveResult(result);

            textBoxOutput.Text = result.ToString();
            input = "";
            textBoxInput.Text = "";

        }

        //CLEAR
        private void buttonC_Click(object sender, EventArgs e)
        {
            input = "";
            nbr1 = null;
            nbr2 = null;
            textBoxInput.Text = "";
            textBoxOutput.Text = ""; 
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