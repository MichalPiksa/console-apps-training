namespace FizzBuzzVersion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome in FizzBuzz game!");

            while (true)
            {
                Console.WriteLine("Enter a Fizz replacement:");
                var fizzReplacement = Console.ReadLine();
                Console.WriteLine("Enter a Buzz replacement:");
                var buzzReplacement = Console.ReadLine();

                var divisors = ValidDivisorsInput();
                foreach (var divisor in divisors)
                {
                    Console.WriteLine(divisor);
                }
            }
        }

        public static List<int> ValidDivisorsInput()
        {
            List<int> validListOfDivisors = new List<int>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter at least 3 whole number divisors separated by '_'");
                string inputDivisors = Console.ReadLine();
                var listOfDivisors = inputDivisors.Split("_");
                if (listOfDivisors.Length < 3)
                {
                    Console.WriteLine("Invalid input. Try it again!");
                    continue;
                }
                foreach (var item in listOfDivisors)
                {
                    if (int.TryParse(item, out int numberItem))
                    {
                        validListOfDivisors.Add(numberItem);
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try it again!");
                        flag = true;
                        break;
                    }
                }
            }
            return validListOfDivisors;
        }
    }
}
