// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }
    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}


void FindSumNumOdd(int[] tempArray, out int sumN)
{
    sumN = 0;
    for (int i = 1; i < tempArray.Length; i = i + 2)
    {
        sumN += tempArray[i];
    }
}

void FindSumNumEven(int[] tempArray, out int sumP)
{
    sumP = 0;
    for (int i = 0; i < tempArray.Length; i = i + 2)
    {
        sumP += tempArray[i];
    }
}


int[] array = FillArray(10, -10, 10);

FindSumNumEven(array, out int sumPositive);
FindSumNumOdd(array, out int sumNegative);
PrintArray(array);
System.Console.WriteLine($"сумма элементов не четных позиций: {sumNegative}");
System.Console.WriteLine($"сумма элементов четных позиций: {sumPositive}");

