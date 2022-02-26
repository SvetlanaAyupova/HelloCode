// Написать программу, которая в двумерном массиве заменяет строки на столбцы
// или сообщить, что это невозможно (в случае, если матрица не квадратная).

int [,] arr = new int [7,7];
int [,] matrix = new int [7,7];

void FillArray()
{
    Random number = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i,j] = number.Next(1,100);
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

void SwapMatrix()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            matrix[i,j] = arr[j, i];
        }
    }
}


if (arr.GetLength(0) != arr.GetLength(1))
{
    Console.WriteLine("Матрица не квадратная.");
}
else
{
    FillArray();
    PrintArray(arr);
    Console.WriteLine();
    SwapMatrix();
    PrintArray(matrix);
}
