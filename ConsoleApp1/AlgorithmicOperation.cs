namespace ConsoleApp1;

public class AlgorithmicOperation
{
    public static int GetMinNumberFromArray(int[] arr)
    {
        if (arr.Length < 3) throw new ArrayLengthException();
        var minNumber = arr[0];
        for (var i = 1; i < arr.Length; i++)
            if (arr[i] < minNumber)
                minNumber = arr[i];
        return minNumber;
    }

    public static int GetMaxNumberFromArray(int[] array)
    {
        var maxNumber = array[0];
        for (var i = 1; i < array.Length; i++)
            if (array[i] > maxNumber)
                maxNumber = array[i];
        return maxNumber;
    }


    public static int FindSecondMax(int[] arr)
    {
        if (arr.Length < 3) throw new ArrayLengthException();

        var max = arr[0];
        var secondMax = arr[1];

        foreach (var num in arr)
            if (num > max)
            {
                secondMax = max;
                max = num;
            }
            else if (num > secondMax)
            {
                secondMax = num;
            }

        return secondMax;
    }

    public static int FindSecondMin(int[] arr)
    {
        if (arr.Length < 3) throw new ArrayLengthException();

        var min = arr[0];
        var secondMin = arr[1];

        foreach (var num in arr)
            if (num < min)
            {
                secondMin = min;
                min = num;
            }
            else if (num < secondMin && num != min)
            {
                secondMin = num;
            }

        return secondMin;
    }

    public static int GetAverage(int[] array)
    {
        var sum = 0;
        foreach (var arrayNumber in array)
            sum += arrayNumber;

        int result = sum / array.Length;
        return result;
    }

    public static int[] SortAscending(int[] array)
    {
        int[] sortedArray = new int[array.Length];
        Array.Copy(array, sortedArray, array.Length);

        for (int i=0; i<sortedArray.Length-1; i++)
        {
            for (int j = i+1; j<sortedArray.Length; j++)
            {
                if (sortedArray[i] > sortedArray[j])
                {
                    int x = sortedArray[i];
                    sortedArray[i] = sortedArray[j];
                    sortedArray[j] = x;
                }
            }
        }
        return sortedArray;
    }

    public static int[] SortDescending(int[] array)
    {
        int[] sortedArray = new int[array.Length];
        Array.Copy(array, sortedArray, array.Length);
        for (int i=0; i<sortedArray.Length-1; i++)
        {
            for (int j=i+1; j<sortedArray.Length; j++)
            {
                if (sortedArray[i] < sortedArray[j])
                {
                    int y = sortedArray[i];
                    sortedArray[i] = sortedArray[j];
                    sortedArray[j] = y;
                }
            }
        }
        return sortedArray;
    }

    public static decimal SumOddNumbers(int[] array)
    {
        decimal sum = Decimal.One;
        for (int i = 0; i < array.Length; i+=2)
        {
            sum += array[i];
        }
        return sum;
    }

    public static decimal MultiplyEvenNumbers(int[] array)
    {
        decimal result = decimal.One;
        for (int i = 1; i < array.Length; i+=2)
        {
            result *= array[i];
        }
        return result;
    }

    public static int[] GetEvenNumbersFromArray(int[] array)
    {
        List<int> evenNumbers = new List<int>();
        foreach (var number in array)
        {
            if (number%2==0 && number!=0)
            {
                evenNumbers.Add(number);
            }
        }
        return evenNumbers.ToArray();
    }

    public static int[] GetOddNumbersFromArray(int[] array)
    {
        List<int> oddNumbers = new List<int>();
        foreach (var number in array)
        {
            if (number%2==1 && number!=0)
            {
                oddNumbers.Add(number);
            }
        }
        return oddNumbers.ToArray();
    }
    }