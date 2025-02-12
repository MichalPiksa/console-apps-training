namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalcAddition(3, 2);

            CalcSubtraction(3, 2);

            CalcMultiplication(3, 2);

            CalcDivide(3, 0);

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


    }
}
