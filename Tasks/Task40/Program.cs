// В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

double[] arr = new double[10];

void FullArray()
{
    Random number = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(number.NextDouble()*100, 2);
        Console.Write($"{arr[i]} ");
    }
}

FullArray();
Console.WriteLine();


double max = arr[0];
double min = arr[0];


for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
}

double difference = max - min;

Console.WriteLine($"Максимальный элемент массива: {max}");
Console.WriteLine($"Минимальный элемент массива: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {difference:F2}");