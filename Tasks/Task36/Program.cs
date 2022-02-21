// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел.

int[]arr = new int[10];

void FullArray()
{
    Random number = new Random();
    for (int i = 0; i < 10; i++)
    {
        arr[i] = number.Next(100, 1000);
        Console.Write ($"{arr[i]} ");
    }
}

Console.WriteLine("Случайный массив: ");
FullArray();
Console.WriteLine();

int countEven = 0;
int countUneven = 0;

foreach (int item in arr)
{
    if (item % 2 == 0)
    {
        countEven++;
    }
    else
    {
        countUneven++;
    }
}

Console.WriteLine($"Количество четных чисел в массиве: {countEven}.");
Console.WriteLine($"Количество нечетных чисел в массиве: {countUneven}.");