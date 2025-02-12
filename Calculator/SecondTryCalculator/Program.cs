namespace SecondTryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inputNumber1;
            double inputNumber2;

            bool flag = true;
            while (flag) 
            { 
                Console.WriteLine("Enter first number:");
                var textNumber1 = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(textNumber1))
                {
                    double.TryParse(textNumber1, out inputNumber1);
                }
            }



            Console.WriteLine("Enter second number:");
            var textNumber2 = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(textNumber2))
            {
                double.TryParse(textNumber2, out inputNumber2);
            }
            else
            {
                inputNumber2 = 0;
            }

            Console.WriteLine("Enter operator '+' or '-' or '*' or '/'");
            var inputOperator = Console.ReadLine();


            switch (inputOperator)
            {
                case "+":
                    Console.WriteLine(CalculatorAddition(inputNumber1, inputNumber2));
                    break;
                case "-":
                    Console.WriteLine(CalculatorAddition(inputNumber1, inputNumber2));
                    break;
                case "*":
                    Console.WriteLine(CalculatorMultiplication(inputNumber1, inputNumber2));
                    break;
                case "/":
                    Console.WriteLine(CalculatorDivision(inputNumber1, inputNumber2));
                    break;
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
