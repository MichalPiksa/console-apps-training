using System.Linq;

namespace CalculatorVersion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            Console.WriteLine("=== Hello, welcome in Calculator app! ===");

            while (true)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Enter first number:");
                calculator.number1 = ValidUserNumer();
                Console.WriteLine("Enter second number:");
                calculator.number2 = ValidUserNumer();

                Console.WriteLine("Type operator: \"+\", \"-\", \"*\" or \"/\"");
                var inputAction = ValidUserOperator();

                if (inputAction == "+")
                {
                    calculator.Addition();
                    Console.WriteLine($"{calculator.number1} + {calculator.number2} = {calculator.result}");
                }
                else if (inputAction == "-")
                {
                    calculator.Subtraction();
                    Console.WriteLine($"{calculator.number1} - {calculator.number2} = {calculator.result}");
                }
                else if (inputAction == "*")
                {
                    calculator.Multiplication();
                    Console.WriteLine($"{calculator.number1} * {calculator.number2} = {calculator.result}");
                }
                else
                {
                    calculator.Division();
                    Console.WriteLine($"{calculator.number1} / {calculator.number2} = {calculator.result}");
                }
                Console.WriteLine("Do you want to run Calculator again? Type 'y' to run again or someting else for exit:");
                string playAgainInput = Console.ReadLine();
                if (playAgainInput != "y")
                {
                    Console.WriteLine("Bye!");
                    break;
                }
            }
        }

        static double ValidUserNumer()
        {
            double userNumber;
            while (!double.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.WriteLine("Invalid input. Try it again:");
            }
            return userNumber;
        }

        static string ValidUserOperator()
        {
            string userOperator = Console.ReadLine();
            List<string> operatorList = new List<string> {"+", "-", "*", "/"};
            while (!operatorList.Contains(userOperator))
            {
                Console.WriteLine("Invalid input. Try it again:");
                userOperator = Console.ReadLine();
            }
            return userOperator;
        }
    }
}
