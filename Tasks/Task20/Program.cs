// Задать номер четверти, показать диапазоны для возможных координат

int InPut(string msg)
{
    Console.Write(msg);
    string? num1 = Console.ReadLine();
    return int.Parse(num1);
}



void Execute(int n)
{
    if (n == 1)
        Console.WriteLine("Координата x > 0 и координата y > 0");
    else if (n == 2)
        Console.WriteLine("Координата x < 0 и координата y > 0");
    else if (n == 3)
        Console.WriteLine("Координата x < 0 и координата y < 0");
    else if (n == 4)
        Console.WriteLine("Координата x > 0 и координата y < 0");
}

int n = InPut("Введите номер четверти координатной плоскости: ");


Execute(n);