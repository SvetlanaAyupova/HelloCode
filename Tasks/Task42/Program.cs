// Определить сколько чисел больше 0 введено с клавиатуры.


void Main()
{
    Console.Write("Введите количество числе N: ");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine($"Введите {n} чисел: ");
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = int.Parse(Console.ReadLine());
    int count = 0;
    for(int i=0;i<arr.Length;i++)
        if(arr[i] > 0)
            count++;
    Console.WriteLine($"Количество чисел больше 0 = {count}.");
}

Main();