// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

System.Console.WriteLine("Введите количество элементов массива:  ");
int tempArray = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[tempArray];

void mas(int tempArray)
{
    Random rand = new Random();
    for (int i = 0; i < tempArray; i++)
    {
        double number = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 3);
        System.Console.WriteLine(number);
    }

}
int min = 0;
int max = 0;
for(int i = 0; i < tempArray; i++)
{
    if (min > i) min = tempArray;
    if (max < i) max = tempArray;
}
 mas(tempArray);
Console.WriteLine($"Максимальный элемент: {max} Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");



 
