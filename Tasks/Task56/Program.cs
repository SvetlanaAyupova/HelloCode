// Написать программу, которая обменивает элементы первой строки и последней строки

int[,] arr = new int[4, 5];


void FillArray()
{
    Random randomNumber = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = randomNumber.Next(1, 10);
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

void SwapArray()
{
    int lastStr = arr.GetLength(0) - 1;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int saveNum = arr[0, i];
        arr[0, i] = arr[lastStr, i];
        arr[lastStr, i] = saveNum;
    }
}






FillArray();
PrintArray(arr);
Console.WriteLine();
SwapArray();
PrintArray(arr);