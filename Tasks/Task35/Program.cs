// Определить, присутствует ли в заданном массиве, некоторое число

int[]array = new int[10];

int InPut()
{
    Console.Write("Введите число: ");
    string? input = Console.ReadLine();
    int.TryParse(input, out int number);
    return number;
}

void FullArray()
{
    Random number = new Random();
    for (int i = 0; i < 10; i++)
    {
        array[i] = number.Next(1, 10);
        Console.Write ($"{array[i]} ");
    }
}
/*
bool Search (int num)
{
    foreach (int item in array)
    {
        Console.WriteLine($"Число массива {item}, заданное число {num}. {item==num}");
        while (array.Length<10)
        {
            if (item == num) return true;
        }
    }
    return false;
}
*/
void Search (int num)
{
    int i = 0;
    foreach (int item in array)
    {
        if (item == num)
        {
            Console.WriteLine ($"Индекс введенного числа в данном массиве: {i}");
        }
        i++;
    }
}

int number = InPut();
FullArray();
Console.WriteLine();
//bool result = Search(number);
//Console.WriteLine(result);
Search(number);
