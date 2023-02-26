using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //save input as string
        string input = "";

        int? nbr1;
        int? nbr2 = null;

        //tells calculate() what type of calculation should be performed 
        int calc;

        //function for calculating, type of calculation based on input
        public int? calculate()
        {
            try
            {
                int? result;

                //throws error if there is an overflow
                checked
                {
                    //determines what operation should be performed
                    switch (calc)
                    {
                        case 1:
                            result = nbr1 + nbr2;
                            break;
                        case 2:
                            result = nbr1 - nbr2;
                            break;
                        case 3:
                            result = nbr1 * nbr2;
                            break;
                        case 4:
                            result = nbr1 / nbr2;
                            break;
                        default:
                            MessageBox.Show("Something went wrong, try again");
                            return 0;
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //saves the result as the first number to allow calculations with more than two numbers
        public void saveResult(int? result)
        {
            nbr1 = result;
            nbr2 = 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            try
            {
                //check if a second number is saved, if not 
                if (nbr2 == null)
                {
                    calc = 1;

                    nbr1 = Int32.Parse(input);
                    //so the if-statement works as intended
                    nbr2 = 0;
                }
                //performes calculation if two numbers are saved 
                else
                {
                    nbr2 = Int32.Parse(input);

                    //saves result
                    int? result = calculate();
                    saveResult(result);

                    calc = 1;
                }

                textBoxOutput.Text += "+";
                input = "";
                textBoxInput.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (nbr2 == null)
                {
                    calc = 2;

                    //for calculating with negative numbers
                    if (input == "")
                    {
                        input = "-";
                        textBoxInput.Text = "-";
                    }
                    else
                    {
                        nbr1 = Int32.Parse(input);
                        nbr2 = 0;
                        input = "";
                        textBoxInput.Text = "";
                    }
                }
                else
                {
                    if (input == "")
                    {
                        input = "-";
                        textBoxInput.Text = "-";
                    }
                    else
                    {
                        nbr2 = Int32.Parse(input);

                        int? result = calculate();
                        saveResult(result);

                        input = "";
                        textBoxInput.Text = "";
                        calc = 2;
                        
                    }
                }
                textBoxOutput.Text += "-";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            try
            {
                if (nbr2 == null)
                {
                    calc = 3;
                    nbr1 = Int32.Parse(input);

                    nbr2 = 0;
                }
                else
                {
                    nbr2 = Int32.Parse(input);

                    int? result = calculate();
                    saveResult(result);

                    calc = 3;
                }
                textBoxOutput.Text += "*";
                input = "";
                textBoxInput.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            try
            {
                if (nbr2 == null)
                {
                    calc = 4;
                    nbr1 = Int32.Parse(input);

                    nbr2 = 0;
                }
                else
                {
                    nbr2 = Int32.Parse(input);

                    int? result = calculate();
                    saveResult(result);

                    calc = 4;
                }

                textBoxOutput.Text += "/";
                input = "";
                textBoxInput.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxEquals.Text = "=";
                nbr2 = Int32.Parse(input);

                //performes last calculation and shows final result
                int? result = calculate();

                textBoxEquals.Text += result.ToString();
                nbr1 = null;
                nbr2 = null;
                input = "";
                textBoxInput.Text = "";
                textBoxOutput.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            input = "";
            nbr1 = null;
            nbr2 = null;
            textBoxInput.Text = "";
            textBoxOutput.Text = "";
            textBoxEquals.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input += 1;
            textBoxInput.Text += "1";
            textBoxOutput.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input += 2;
            textBoxInput.Text += "2";
            textBoxOutput.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input += 3;
            textBoxInput.Text += "3";
            textBoxOutput.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input += 4;
            textBoxInput.Text += "4";
            textBoxOutput.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input += 5;
            textBoxInput.Text += "5";
            textBoxOutput.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input += 6;
            textBoxInput.Text += "6";
            textBoxOutput.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += 7;
            textBoxInput.Text += "7";
            textBoxOutput.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input += 8;
            textBoxInput.Text += "8";
            textBoxOutput.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input += 9;
            textBoxInput.Text += "9";
            textBoxOutput.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            input += 0;
            textBoxInput.Text += "0";
            textBoxOutput.Text += "0";
        }
    }
}
