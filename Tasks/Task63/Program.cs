// Сформировать трехмерный массив не повторяющимися двузначными числами
// показать его построчно, на экран выводя индексы соответствующего элемента.

using System.Linq;
int[, ,] arr = new int[4, 4, 4];

void FillArray()
{
    Random rnd = new Random();
    Queue<int> que = new Queue<int>(Enumerable.Range(10, arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)).OrderBy(_ => rnd.Next()));
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = que.Dequeue();
            }
        }
    }
}

void PrintArray(int[, ,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i},{j},{k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

FillArray();
PrintArray(arr);