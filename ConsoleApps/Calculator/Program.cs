namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            string inputText1 = Console.ReadLine();

            Console.WriteLine("Enter the second number: ");
            string inputText2 = Console.ReadLine();

            double.TryParse(inputText1, out double inputNumber1);
            double.TryParse(inputText2, out double inputNumber2);



            CalcAddition(inputNumber1, inputNumber2);

            CalcSubtraction(inputNumber1, inputNumber2);

            CalcMultiplication(inputNumber1, inputNumber2);

            CalcDivide(inputNumber1, inputNumber2);

        }
        public static void CalcAddition(double number1, double number2)
        {
            double result = number1 + number2;
            Console.WriteLine($"Result is {result}");
        }

        public static void CalcSubtraction(double number1, double number2)
        {
            double result = number1 - number2;
            Console.WriteLine($"Result is {result}");
        }

        public static void CalcMultiplication(double number1, double number2)
        {
            double result = number1 * number2;
            Console.WriteLine($"Result is {result}");
        }

        public static void CalcDivide(double number1, double number2)
        {
            try
            {
                double result = number1 / number2;
                Console.WriteLine($"Result is {result}");

            }
            catch (Exception)
            {

                throw new DivideByZeroException();
            }
        }

        //public void SwitchOption(string option, double number1, double number2)
        //{
        //    switch (option)
        //    {
        //        case 1
        //            CalcAddition(number1, number2);
        //        default:
        //            break;
        //    }
        //}


    }
}
