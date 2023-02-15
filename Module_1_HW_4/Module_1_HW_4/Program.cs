namespace Module_1_HW_4;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter array's size: ");

        int[] numbers = new int[int.Parse(Console.ReadLine())];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1, 26);
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();

        int even = 0;
        int odd = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }

        int[] evenArray = new int[even];
        int[] oddArray = new int[odd];

        int evenArrayIndex = 0;
        int oddArrayIndex = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenArray[evenArrayIndex] = numbers[i];
                evenArrayIndex++;
            }
            else
            {
                oddArray[oddArrayIndex] = numbers[i];
                oddArrayIndex++;
            }
        }

        char[] evenCharArray = new char[evenArray.Length];
        char[] oddCharArray = new char[oddArray.Length];

        char[] letters =
        {
            'A', 'b', 'c', 'D', 'E', 'f', 'g', 'H',
            'I', 'J', 'k', 'l', 'm', 'n', 'o', 'p',
            'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
            'y', 'z',
        };

        for (int i = 0; i < evenArray.Length; i++)
        {
            evenCharArray[i] = letters[evenArray[i] - 1];
        }

        for (int i = 0; i < oddArray.Length; i++)
        {
            oddCharArray[i] = letters[oddArray[i] - 1];
        }

        Console.WriteLine("Even char array: ");
        PrintArray(evenCharArray);

        Console.WriteLine("Odd char array: ");
        PrintArray(oddCharArray);
    }

    private static void PrintArray(char[] array)
    {
        foreach (char c in array)
        {
            Console.Write(c + " ");
        }

        Console.WriteLine();
    }
}