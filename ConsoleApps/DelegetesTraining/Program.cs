namespace DelegetesTraining;

class Program
{
    delegate void PrintText(string text, DateTime dateTime);
    static void Main(string[] args)
    {
        Log log = new Log();
        //PrintText result = new PrintText(PrintTextToScreen);}
        PrintText result = new PrintText(log.PrintTextToFile);
        
        Console.WriteLine("Enter your name: ");
        string userInput = Console.ReadLine();
        
        result(userInput, DateTime.Now);

        Console.ReadKey();
    }
}

public class Log
{
    public void PrintTextToScreen(string text, DateTime dateTime)
    {
        Console.WriteLine($"{dateTime}, {Guid.NewGuid()}: {text}");
    }

    public void PrintTextToFile(string text, DateTime dateTime)
    {
        using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
        {
            sw.WriteLine($"{dateTime}, {Guid.NewGuid()}: {text}");
        }
    }
}