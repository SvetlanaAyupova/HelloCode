// В матрице чисел найти сумму элементов главной диагонали.

int[,] arr = new int[5, 5];

Random randomNumber = new Random();


void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = randomNumber.Next(1, 50);
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

void DiagonalSum()
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            if (i == j)
            sum = sum + arr[i, j];
        }
    }
    Console.WriteLine($"Сумма элементов главной диагонали = {sum}.");
}

FillArray();
PrintArray();
DiagonalSum();