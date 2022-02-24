// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

var arr = new int[4, 5];

Random randomNumber = new Random();


void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = randomNumber.Next(1, 101);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void AverageSum()
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            result = result + arr[i, j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {j} = {result / arr.GetLength(0):F2}");

    }
}

FillArray();
PrintArray();
AverageSum();