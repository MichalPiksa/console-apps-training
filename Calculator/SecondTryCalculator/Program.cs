namespace SecondTryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number1 = InputNumberCheck("first");
            var number2 = InputNumberCheck("second");

            Console.WriteLine("Enter operator '+' or '-' or '*' or '/'");
            var inputOperator = Console.ReadLine();

            switch (inputOperator)
            {
                case "+":
                    Console.WriteLine(CalculatorAddition(number1, number2));
                    break;
                case "-":
                    Console.WriteLine(CalculatorAddition(number1, number2));
                    break;
                case "*":
                    Console.WriteLine(CalculatorMultiplication(number1, number2));
                    break;
                case "/":
                    Console.WriteLine(CalculatorDivision(number1, number2));
                    break;
            }
        }

        public static double InputNumberCheck(string range)
        {
            while (true) 
            { 
                Console.WriteLine($"Enter {range} number:");
                var inputText = Console.ReadLine();
                if (double.TryParse(inputText, out double outputNumber))
                { 
                    return outputNumber; 
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }

        public static double CalculatorAddition(double number1, double number2)
        {
            return number1 + number2;
        }
        public static double CalculatorSubtraction(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double CalculatorMultiplication(double number1, double number2)
        {
            return number1 * number2;
        }
        public static double CalculatorDivision(double number1, double number2)
        {
            if (number2 != 0)
            {
                return number1 / number2;
            }
            else
            {
                throw new DivideByZeroException("Not possible to divide by zero.");
            }
        }
    }
}
