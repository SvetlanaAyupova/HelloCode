// Показать числа Фибоначчи.

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Числа Фибоначчи через цикл:");

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
        Console.Write($"{a} ");
    }
    return a;
}
double result = Fibonachi (a);

Console.WriteLine();

Console.WriteLine("Числа Фибоначчи через рекурсию:");

double FibonachiRecurs (int n)
{
    if (n == 0 || n == 1)
        return 1;
    return FibonachiRecurs(n-1) + FibonachiRecurs(n-2);
}

for (int i = 0; i <= b; i++)
{
    Console.Write($"{FibonachiRecurs(i)} ");
}