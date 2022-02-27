// Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.

int[,] arr = new int[4, 4];


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

void SelectionSort(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1)-1; j++)
        {
            int minPosition = j;
            for (int k = j+1; k < arr.GetLength(1); k++)
            {
                if (arr[i,k] < arr[i,minPosition]) minPosition = k;
            }
            int temporary = arr[i,j];
            arr[i,j] = arr[i,minPosition];
            arr[i,minPosition] = temporary;

        }
    }
}

FillArray();
PrintArray(arr);
Console.WriteLine();
SelectionSort(arr);
PrintArray(arr);