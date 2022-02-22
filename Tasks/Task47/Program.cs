// Написать программу копирования массива.

int[] arr = new int[10];
int[] copyArray = new int[arr.Length];

void FullArray()
{
    Random number = new Random();
    for (int i = 0; i < 10; i++)
    {
        arr[i] = number.Next(1, 50);
        Console.Write($"{arr[i]} ");
    }
}

void CopyArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
        Console.Write($"{copyArray[i]} ");
    }
}

Console.WriteLine("Исходный массив");
FullArray();
Console.WriteLine();
Console.WriteLine("Скопированный массив");
CopyArray(arr);

// Через функцию Array.Copy.

/*int [] array = new int[5] {1,2,3,4,5};
int [] copiedArray = new int[5];

Array.Copy(array, copiedArray, array.Length);

foreach(var item in array)
{
    Console.Write($"{item} ");
}

Console.WriteLine();

foreach(var item in copiedArray)
{
    Console.Write($"{item} ");
}*/