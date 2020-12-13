// Amber Holcomb-Stone
// Lab 3: Create a Basic Calculator
// Some source code modified from: https://www.instructables.com/Creating-a-Calculator-Visual-Studio-C/
// https://www.dreamincode.net/forums/topic/32968-basic-calculator-in-c%23/
//backspace code: https://soumiaw.wordpress.com/2011/01/03/simple-calculator-in-c/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    public class Calculator
    {
        public string input = "";
        public string operand1 = "0";
        public string operand2 = "0";
        public char op;
        public double result = 0.0;

        public void Calculation()
        {
            double num1;
            double num2;

            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (op == '+')
            {
                result = num1 + num2;
                input = result.ToString();
              
            }

            else if (op == '-')
            {
                result = num1 - num2;
                input = result.ToString();
               
            }

            else if (op == '*')
            {
                result = num1 * num2;
                input = result.ToString();
               
            }

            else if (op == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    input = result.ToString();
                
                }
                else 
                {
                    throw new DivideByZeroException();
                }
            }
        }

        public void Sqrt()
        {
            double num1;
            double.TryParse(input, out num1);
            result = Math.Sqrt(num1);
            input = result.ToString();
        }

        public void Reciprocal()
        {
            double num1;
            double.TryParse(input, out num1);

            if (num1 != 0)
            {
                result = 1 / num1;
                input = result.ToString();
            }
            else
            {
                input = string.Empty;
                throw new DivideByZeroException();
            }
        }

        public void PositiveNegative()
        {
            double num1;
            double.TryParse(input, out num1);

            result = num1 / -1;
            input = result.ToString();
        }
    }
}