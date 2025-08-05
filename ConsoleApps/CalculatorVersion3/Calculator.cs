using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorVersion3
{
    public class Calculator
    {
        public double number1 {  get; set; }
        public double number2 { get; set; }
        public double result {  get; private set; }

        public void Addition()
        {
            result = number1 + number2;
        }

        public void Subtraction()
        {
            result = number1 - number2;
        }

        public void Multiplication()
        {
            result = number1 * number2;
        }

        public void Division()
        {
            if (number2 == 0)
            {
                double newNumber2;
                Console.WriteLine("Cannot divide by zero. Enter second number again:");
                while (!double.TryParse(Console.ReadLine(), out newNumber2) || newNumber2 == 0)
                {
                    Console.WriteLine("Invalid input or zero. Enter second number again:");
                }
                number2 = newNumber2;
            }
            result = number1 / number2;
        }
    }
}
