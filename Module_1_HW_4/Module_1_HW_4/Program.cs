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
            Console.WriteLine(numbers[i]);
        }

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
            if (numbers[i]%2==0)
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
    }
}