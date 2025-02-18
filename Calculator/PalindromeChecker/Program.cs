namespace PalindromeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome in Palindrom checker game!");
            while (true) 
            {
                Console.WriteLine("\nWrite a word and I will tell you, if it is Palindrome");
                Console.WriteLine("For exit type 'q'");
                string? userInput = Console.ReadLine();
                if (userInput == "q")
                {
                    break;
                }
                
                while (string.IsNullOrWhiteSpace(userInput) || userInput.Length < 3 || !userInput.All(char.IsAsciiLetter))
                {
                    Console.WriteLine("(Input must be at least 3 characters long and contain only letters)");
                    userInput = Console.ReadLine();
                }

                string reversedInput = string.Empty;
                for (int i = userInput.Length - 1; i >= 0; i--)
                { 
                    reversedInput = reversedInput + userInput[i];
                }

                if (userInput.ToLower() == reversedInput.ToLower())
                {
                    Console.WriteLine($"Yes, word \"{userInput}\" is Palindrome.");
                }
                else
                {
                    Console.WriteLine($"No, word \"{userInput}\" is not Palindrome. \"{userInput}\" and \"{reversedInput}\" are not equal.");
                }
            }
            Console.WriteLine("Game exit.");
        }
    }
}