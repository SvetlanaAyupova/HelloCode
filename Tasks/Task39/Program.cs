// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] arr = new int[12];

void FullArray()
{
    Random number = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = number.Next(1, 10);
        Console.Write($"{arr[i]} ");
    }
}

FullArray();
Console.WriteLine();

int sum = 0;
for (int i = 0; i < arr.Length / 2; i++)
{
    sum += arr[i] * arr[arr.Length - 1 - i];
}

Console.WriteLine($"Сумма произведений = {sum}.");