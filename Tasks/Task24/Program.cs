// Найти кубы чисел от 1 до N

int InPut(string msg)
{
    Console.Write(msg);
    string? num1 = Console.ReadLine();
    int A = int.Parse(num1);
    return A;
}

int[] InitArray(int number)
{
    int [] array = new int[number];

    for (int i = 0; i < number; i++)
    {
        array[i] = (i+1) * (i+1) * (i+1);
    }
    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int b = InPut("Введите число > ");

int [] array = InitArray(b);

PrintArray(array);