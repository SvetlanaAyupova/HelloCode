// В двумерном массиве n×k заменить четные элементы на противоположные.

int[,] arr = new int[5, 8];
Random rand = new Random();

void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rand.Next(1, 100);
        }
    }
}

int [,] ReplacementSign()
{
    int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            if (arr[i,j] % 2 == 0)
            {
                newArr[i,j] = -1* arr[i,j];
            }
            else
                newArr[i,j] = arr[i,j];
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
int[,] newArr = ReplacementSign();
PrintArray(newArr);
