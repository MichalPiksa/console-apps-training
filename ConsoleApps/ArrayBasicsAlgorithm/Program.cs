namespace FindMinimalNumber;

class Program
{
    static void Main()
    {
        int[] myNumbers = { 5, 2, 8, -2, 1, 43, 0, -5, 10, 3 };
        Console.WriteLine(myNumbers);
        
        int minimalNumber = FindMinimalNumber(myNumbers);
        Console.WriteLine("Minimal number in the array is: " + minimalNumber);
        
        int maximumNumber = FindMaximumNumber(myNumbers);
        Console.WriteLine("Maximum number in array is: " + maximumNumber);

        int[] reversedArray = ReverseArray(myNumbers);
        Console.WriteLine("Reversed array is: { " + string.Join(", ", reversedArray) + " }");
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
    
    static int FindMaximumNumber(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array must not be null or empty.");
        }
        
        int maximumNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maximumNumber)
            {
                maximumNumber = number;
            }
        }
        return maximumNumber;
    }

    static int[] ReverseArray(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array must not be null or empty.");
        }
        
        int[] reverseArray = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            reverseArray[i] = numbers[numbers.Length - 1 - i];
        }
        return reverseArray;
    }
    // TODO
    /*
    Remove duplicates from a sorted array.
    Check if an array is a palindrome.
    */
    
}