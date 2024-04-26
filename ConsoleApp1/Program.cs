using ConsoleApp1;

while (true)
{
    Console.WriteLine("Select the number of arrays on which you want to perform operations: ");
    Console.WriteLine("1.Operations for 1 array");
    Console.WriteLine("2.Operations for 2 arrays");
    Console.WriteLine("0.Exit from the program");
    Console.Write("Choice: ");
    int arrayCountChoice = Utility.GetInputFromUser();

    if (arrayCountChoice == 1)
    {
        Console.Write("Insert size of array and generate random array: ");
        var size = Utility.GetInputFromUser();
        while (true)
            if (size < 2)
            {
                Console.WriteLine("Array length must be grater than 1");
                size = Utility.GetInputFromUser();
            }
            else
            {
                break;
            }

        var array = Utility.GetRandomArray(size);
        Console.WriteLine("Generated array: " + Utility.ArrayToString(array));

        while (true)
        {
            Utility.DisplayChoices();
            var choice = Utility.GetInputFromUser();

            if (choice == 1)
            {
                Console.WriteLine("Maximum number: " + AlgorithmicOperation.GetMaxNumberFromArray(array));
            }

            else if (choice == 2)
            {
                Console.WriteLine("Minimum number: " + AlgorithmicOperation.GetMinNumberFromArray(array));
            }

            else if (choice == 3)
            {
                try
                {
                    Console.WriteLine("2nd Maximum number: " + AlgorithmicOperation.FindSecondMax(array));
                }
                catch (ArrayLengthException e)
                {
                    Console.WriteLine("Array length should be 3 at least");
                }
            }

            else if (choice == 4)
            {
                try
                {
                    Console.WriteLine("2nd Minimum number: " + AlgorithmicOperation.FindSecondMin(array));
                }
                catch (ArrayLengthException e)
                {
                    Console.WriteLine("Array length should be 3 at least");
                }
            }

            else if (choice == 5)
            {
                int average = AlgorithmicOperation.GetAverage(array);
                Console.WriteLine("Average: " + average);
            }

            else if (choice == 6)
            {
                int[] sortedArray = AlgorithmicOperation.SortDescending(array);
                Console.WriteLine("Sorted array: " + Utility.ArrayToString(sortedArray));
            }

            else if (choice == 7)
            {
                int[] sortedArray = AlgorithmicOperation.SortAscending(array);
                Console.WriteLine("Sorted array: " + Utility.ArrayToString(sortedArray));
            }

            else if (choice == 8)
            {
                decimal sum = AlgorithmicOperation.SumOddNumbers(array);
                Console.WriteLine("Odd numbers sum: " + sum);
            }

            else if (choice == 9)
            {
                decimal result = AlgorithmicOperation.MultiplyEvenNumbers(array);
                Console.WriteLine("Multiplied result: " + result);
            }

            else if (choice == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter 0-8 interval!");
            }
        }
    }
    else if (arrayCountChoice == 2)
    {
        
        Console.Write("Insert first arraysize: ");
        int firstArraySize = Utility.GetInputFromUser();

        Console.Write("Insert second array size: ");
        int secondArraySize = Utility.GetInputFromUser();

        int[] firstArray = Utility.GetRandomArray(firstArraySize);
        int[] secondArray = Utility.GetRandomArray(secondArraySize);
        Console.WriteLine("===============================================");
        Console.WriteLine("First array: " + Utility.ArrayToString(firstArray));
        Console.WriteLine("Second array: " + Utility.ArrayToString(secondArray));



        int[] resultOfFirstArray = AlgorithmicOperation.GetEvenNumbersFromArray(firstArray);
        int[] resultOfSecondArray = AlgorithmicOperation.GetOddNumbersFromArray(secondArray);

        Console.WriteLine("Even numbers of first array: " + Utility.ArrayToString(resultOfFirstArray));
        Console.WriteLine("Odd numbers of second array: " + Utility.ArrayToString(resultOfSecondArray));
        Console.WriteLine("===============================================");
    }
    else if (arrayCountChoice==0)   
    {
        break;
    }
    else
    {
        Console.WriteLine("Insert valid choice number please! 1 or 2");
    }
}