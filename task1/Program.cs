// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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


void FindNumEvenAndOdd(int[] tempArray, out int numE, out int numO, out int colE, out int colO)
{
    numE = 0;
    numO = 0;
    colE = 0;
    colO = 0;
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i] % 2 == 0)
        {
            numE = tempArray[i];
            colE = colE + 1;
        }
        else
        {
            numO = tempArray[i];
            colO = colO + 1;
        }

    }


}

int[] array = FillArray(10, 100, 999);

FindNumEvenAndOdd(array, out int numEven, out int numOdd, out int ColEven, out int ColOdd);
PrintArray(array);
System.Console.WriteLine($"Кол-во четных элементов массива: {ColEven}");
System.Console.WriteLine($"Кол-во нечетных элементов массива: {ColOdd}");