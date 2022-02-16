// Задать массив из N элементов и вывести их на экран

int GetIntFromConsole()
{
    Console.Write("Вветите число от 1 до 10: ");
    string? num1 = Console.ReadLine();
    int A = int.Parse(num1);
    return A;
}

int[] ArrayInit(int num)
{
    int[] array = new int[num];
    Random randomNum = new Random();
    for (int i = 0; i < num; i++)
    {
        array[i] = randomNum.Next(1,10);
    }
    return array;
}

void ArrayPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int getInt = GetIntFromConsole();
int[] array = ArrayInit(getInt);

ArrayPrint(array);