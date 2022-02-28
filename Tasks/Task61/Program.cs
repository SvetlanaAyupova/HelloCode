// Найти произведение двух матриц.

int[,] arr = new int[3, 3];
int[,] massiv = new int[3, 3];

void FillArray(int[,] arr)
{
    Random number = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = number.Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
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

void MultipleMatrix(int[,] arr, int[,] massiv)
{
    int[,] multipleMatrix = new int[arr.GetLength(0), massiv.GetLength(1)];
    if (arr.GetLength(1) != massiv.GetLength(0))
        Console.WriteLine("Матрицы не согласованны. Невозможно выполнить произведение.");
    else
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < massiv.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    multipleMatrix[i, j] += arr[i, k] * massiv[k, j];
                }
                Console.Write($"{multipleMatrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

}

FillArray(arr);
Console.WriteLine("Первая матрица:");
PrintArray(arr);

FillArray(massiv);
Console.WriteLine("Вторая матрица:");
PrintArray(massiv);

Console.WriteLine("Произведение двух матриц:");
MultipleMatrix(arr, massiv);

