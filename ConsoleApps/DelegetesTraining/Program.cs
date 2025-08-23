namespace DelegetesTraining;

class Program
{
    delegate void PrintText(string text, DateTime dateTime);
    static void Main(string[] args)
    {
        PrintText result = new PrintText(PrintTextToScreen);
        
        Console.WriteLine("Enter your name: ");
        string userInput = Console.ReadLine();
        
        result(userInput, DateTime.Now);

        Console.ReadKey();
    }

    static void PrintTextToScreen(string text, DateTime dateTime)
    {
        Console.WriteLine($"{dateTime}, {Guid.NewGuid()}: {text}");
    }
}