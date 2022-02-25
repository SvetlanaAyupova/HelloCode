// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

int[,] arr = new int[5, 5];
Random rand = new Random();

void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(1, 10);
        }
    }
}

int[,] SquareElements()
{
    int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                newArr[i, j] = arr[i, j] * arr[i, j];
            }
            else
                newArr[i, j] = arr[i, j];
        }
    }
    return newArr;
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

FillArray();
PrintArray(arr);
Console.WriteLine();
int[,] newArr = SquareElements();
PrintArray(newArr);
