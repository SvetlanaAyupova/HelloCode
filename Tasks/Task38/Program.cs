// Найти сумму чисел одномерного массива стоящих на нечетной позиции.

int[]arr = new int[10];

void FullArray()
{
    Random number = new Random();
    for (int i = 0; i < 10; i++)
    {
        arr[i] = number.Next(1, 30);
        Console.Write ($"{arr[i]} ");
    }
}

Console.WriteLine("Случайный массив: ");
FullArray();
Console.WriteLine();

int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 != 0) sum = sum + arr[i];
}

Console.WriteLine($"Сумма чисел массива, стоящих на нечетных позициях = {sum}.");