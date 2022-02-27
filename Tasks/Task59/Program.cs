// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int [,] arr = new int [3,5];

void FillArray()
{
    Random number = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i,j] = number.Next(1,10);
        }
    }
}

void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write ($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void MinSumRow(int [,] arr)
{
    int minSum = 0;
    int row = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        Console.WriteLine($"Сумма {i+1} строки = {sum}");
        if (i==0 || sum < minSum)
        {
            minSum = sum;
            row = i+1;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {row}");
}

FillArray();
PrintArray(arr);
MinSumRow(arr);
