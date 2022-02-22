// Показать числа Фибоначчи.

double Fibonachi (int n)
{
    double temp;
    double a = 0;
    double b = 1;

    for (int i = 0; i <= n; i++)
    {
        temp = a;
        a = b;
        b = temp + b;
        Console.WriteLine(a);
    }
    return a;
}

double FibonachiRecurs (int n)
{
    if (n == 0 || n == 1)
        return 1;
    return FibonachiRecurs(n-1) + FibonachiRecurs(n-2);
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"Через цикл - {Fibonachi(a)}");
Console.WriteLine($"Через рекурсию - {FibonachiRecurs(b)}");