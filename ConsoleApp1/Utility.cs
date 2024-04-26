using System.Text;

namespace ConsoleApp1;

public class Utility
{
    public static int[] GetRandomArray(int sizeOfArray)
    {
        var random = new Random();
        var randomArray = new int[sizeOfArray];

        for (var i = 0; i < sizeOfArray; i++) randomArray[i] = random.Next(100);

        return randomArray;
    }

    public static void PrintExit()
    {
        Console.WriteLine("Continue operations or press 0 to the exit from the program");
    }


    public static int GetInputFromUser()
    {
        int input;
        while (true)
            try
            {
                input = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Enter only number please!");
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("Enter a valid input");
            }
            catch (OverflowException exception)
            {
                Console.WriteLine("Enter a valid input");
            }

        return input;
    }

    public static void DisplayChoices()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("Choose what operation you want: ");
        Console.WriteLine("1. Get maximum number from array");
        Console.WriteLine("2. Get minimum number from array");
        Console.WriteLine("3. Get second maximum number from array");
        Console.WriteLine("4. Get second minimum number from array");
        Console.WriteLine("5. Get array's numbers average");
        Console.WriteLine("6. Sort to descending numbers");
        Console.WriteLine("7. Sort to ascending numbers");
        Console.WriteLine("8. Sum odd numbers ");
        Console.WriteLine("9. Multiply even numbers");
        Console.WriteLine("0. Choose number of array again");
        Console.WriteLine("===================================");
        Console.Write("Insert operation number: ");
    }

    public static string ArrayToString(int[] array)
    {
        var stringArray = new StringBuilder("[");
        foreach (var arrayNumber in array)
            if (!array.GetValue(array.Length - 1).Equals(arrayNumber))
                stringArray.Append(arrayNumber + ",");
            else
                stringArray.Append(arrayNumber);

        stringArray.Append("]");
        var result = stringArray.ToString();
        return result;
    }
}