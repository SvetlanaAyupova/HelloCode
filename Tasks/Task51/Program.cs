// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] arr = new int[2, 2];
Random rand = new Random();

void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rand.Next(1, 9);
        }
    }
}

int [,] MethodSum()
{
    int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            newArr[i,j] = i+j;
        }
    }
    return newArr;
}

void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

FillArray();
PrintArray(arr);
Console.WriteLine();
int[,] newArr = MethodSum();
PrintArray(newArr);
