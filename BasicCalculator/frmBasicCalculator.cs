// Amber Holcomb-Stone
// Lab 3: Create a Basic Calculator
// Some source code adapted and modified from: https://www.instructables.com/Creating-a-Calculator-Visual-Studio-C/
// https://www.dreamincode.net/forums/topic/32968-basic-calculator-in-c%23/
// https://github.com/jameswillhoite/CITC2311/blob/master/Lab3/Calculator/Calculator/Form1.cs
// https://soumiaw.wordpress.com/2011/01/03/simple-calculator-in-c/
// Form Load Turn Hightlight Off - TabStop to false: https://stackoverflow.com/questions/3421453/why-is-text-in-textbox-highlighted-selected-when-form-is-displayed





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class frmBasicCalculator : Form
    {

        protected Calculator calculator = new Calculator();

        protected bool clear = false;

        private string input = string.Empty;
        private string operand1 = string.Empty;
        private string operand2 = string.Empty;
       
        
 
        public frmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //If a calculation has been performed and user presses another digit, 
            //then clear the form
            if (clear)
            {
                this.ClearForm();
            }

            //Prevents leading zero
           if ((this.calculator.input + "0").IndexOf("0") > 0)
            {

                //Make sure text box is clear
                textBox1.Text = "";

                //Add to input
                this.calculator.input += "0";

                //Display the current input
                textBox1.Text += this.calculator.input;
           }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //If a calculation has been performed and user presses another digit, 
            //then clear the form
            if (clear)
            {
                this.ClearForm();
            }

            //Make sure text box is clear
            textBox1.Text = "";

            //Add to input
            this.calculator.input += "1";

            //Display the current input
            textBox1.Text += this.calculator.input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //If a calculation has been performed and user presses another digit, 
            //then clear the form
            if (clear)
            {
                this.ClearForm();
            }

            //Make sure text box is clear
            textBox1.Text = "";

            //Add to input
            this.calculator.input += "2";

            //Display the current input
            textBox1.Text += this.calculator.input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //If a calculation has been performed and user presses another digit, 
            //then clear the form
            if (clear)
            {
                this.ClearForm();
            }

            //Make sure text box is clear
            textBox1.Text = "";

            //Add to input
            this.calculator.input += "3";

            //Display the current input
            textBox1.Text += this.calculator.input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //If a calculation has been performed and user presses another digit, 
            //then clear the form
            if (clear)
            {
                this.ClearForm();
            }

            //Make sure text box is clear
            textBox1.Text = "";

            //Add to input
            this.calculator.input += "4";

            //Display the current input
            textBox1.Text += this.calculator.input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //If a calculation has been performed and user presses another digit, 
            //then clear the form
            if (clear)
            {
                this.ClearForm();
            }

            //Make sure text box is clear
            textBox1.Text = "";

            //Add to input
            this.calculator.input += "5";

            //Display the current input
            textBox1.Text += this.calculator.input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //If a calculation has been performed and user presses another digit, 
            //then clear the form
            if (clear)
            {
                this.ClearForm();
            }

            //Make sure text box is clear
            textBox1.Text = "";

            //Add to input
            this.calculator.input += "6";

            //Display the current input
            textBox1.Text += this.calculator.input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //If a calculation has been performed and user presses another digit, 
            //then clear the form
            if (clear)
            {
                this.ClearForm();
            }

            //Make sure text box is clear
            textBox1.Text = "";

            //Add to input
            this.calculator.input += "7";

            //Display the current input
            textBox1.Text += this.calculator.input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //If a calculation has been performed and user presses another digit, 
            //then clear the form
            if (clear)
            {
                this.ClearForm();
            }

            //Make sure text box is clear
            textBox1.Text = "";

            //Add to input
            this.calculator.input += "8";

            //Display the current input
            textBox1.Text += this.calculator.input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //If a calculation has been performed and user presses another digit, 
            //then clear the form
            if (clear)
            {
                this.ClearForm();
            }

            //Make sure text box is clear
            textBox1.Text = "";

            //Add to input
            this.calculator.input += "9";

            //Display the current input
            textBox1.Text += this.calculator.input;
        }
    

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            //Clears text box
            textBox1.Text = "";
            
            this.calculator.Sqrt();
            textBox1.Text = this.calculator.input;
            //Clear the decimal flag
            //hasDecimal = false;
            

            
        }
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            try
            {
                this.calculator.Reciprocal();
                textBox1.Text = this.calculator.input;
            }
            catch (DivideByZeroException)
            {
                textBox1.Text = "DIV/0!";
            }
            catch (Exception)
            {
                textBox1.Text = "ERROR!";
            }
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            this.calculator.operand2 = this.calculator.input;

            try
            {
                this.calculator.Calculation();
                textBox1.Text = this.calculator.result.ToString();
                
            }
            catch (DivideByZeroException)
            {
                textBox1.Text = "DIV/0!";
            }
            catch (OverflowException)
            {
                textBox1.Text = "Overflow!";
            }
            catch (Exception)
            {
                textBox1.Text = "ERROR!!";
            }
            
            clear = true; //Clear the form on the next number press
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //backspace
            if (textBox1.Text != string.Empty)
            {
                int txtlength = textBox1.Text.Length;
                if (txtlength != 1)
                {
                    textBox1.Text = textBox1.Text.Remove(txtlength - 1);
                }
                else
                {
                    textBox1.Text = 0.ToString();
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();

        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
          
            if (clear)
            {
                this.ClearForm();
            }

            if (this.calculator.input.Length == 0)
            {
                this.calculator.input = "0";
            }

            //Clear text box
            textBox1.Text = "";

            //Checks to see if there is a decimal already and prevents adding more
            if (this.calculator.input.IndexOf(".") == -1)
                this.calculator.input += ".";

            //Display value to text box
            textBox1.Text = this.calculator.input;
        }


        private void btnPositiveNegative_Click(object sender, EventArgs e)
        {
            //Clear text box
            textBox1.Text = "";

            //Change sign of number in text box
            this.calculator.PositiveNegative();

            //Display value to text box
            textBox1.Text = this.calculator.input;
        }

        private void ClearForm()
        {
            textBox1.Text = "0";
            this.calculator.input = string.Empty;
            this.calculator.operand1 = string.Empty;
            this.calculator.operand2 = string.Empty;
            this.calculator.op = ' ';
            this.clear = false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.calculator.operand1 = this.calculator.input;
            this.calculator.op = '+';
            this.calculator.input = string.Empty;


            //Don't clear the form on the next number press
            clear = false;

            

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            this.calculator.operand1 = this.calculator.input;
            this.calculator.op = '-';
            this.calculator.input = string.Empty;

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            this.calculator.operand1 = this.calculator.input;
            this.calculator.op = '*';
            this.calculator.input = string.Empty;

            
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            this.calculator.operand1 = this.calculator.input;
            this.calculator.op = '/';
            this.calculator.input = string.Empty;

            
        }

        private void frmBasicCalculator_Load(object sender, EventArgs e)
        {
            //Display zero on form load
            textBox1.Text = "0";
        }
    }
}
