namespace FindMinimalNumber;

class Program
{
    static void Main()
    {
        int[] myNumbers = { 5, 2, 8, -2, 1, 43, 0 , -5, 10, 3 };
        int minimalNumber = FindMinimalNumber(myNumbers);
        Console.WriteLine("Minimal number in the array is: " + minimalNumber);
    }
    
    static int FindMinimalNumber(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array must not be null or empty.");
        }

        int minimal = numbers[0];
        for (int number = 1; number < numbers.Length; number++)
        {
            if (numbers[number] < minimal)
            {
                minimal = numbers[number];
            }
        }
        return minimal;
    }
}