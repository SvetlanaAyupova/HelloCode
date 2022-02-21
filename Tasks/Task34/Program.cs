// Написать программу замены элементов массива на противоположные.

int[]arr = new int[10];

void FullArray()
{
    Random number = new Random();
    for (int i = 0; i < 10; i++)
    {
        arr[i] = number.Next(-9, 10);
        Console.Write ($"{arr[i]} ");
    }
}

void Change(int[]arr)
{
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] = arr[i]*-1;
    }
}

void ArrayPrint(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Исходный массив:");
FullArray();
Change(arr);
Console.WriteLine();
Console.WriteLine("Измененный массив:");
ArrayPrint(arr);