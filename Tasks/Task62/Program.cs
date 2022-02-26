// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] arr = new int[5, 5];

void FillArray()
{
    Random randomNumber = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = randomNumber.Next(-10, 10);
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

(int, int) FindMin ()                 //Кортежи
{
    int minString = 0;
    int minColum = 0;
    int minBoss = arr[0,0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j] < minBoss)
            {
                minBoss = arr[i,j];
                minString = i;
                minColum = j;
            }
        }
    }
    return (minString, minColum);
}

void PrintMassiv(int str, int colum)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (str != i && colum != j)
                Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}


FillArray();
PrintArray(arr);
(int minString, int minColum) = FindMin();
Console.WriteLine();
PrintMassiv (minString, minColum);