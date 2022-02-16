// Возведите число А в натуральную степень B используя цикл

int InPut(string msg)
{
    Console.Write(msg);
    string? num1 = Console.ReadLine();
    int A = int.Parse(num1);
    return A;
}

int number = InPut("Введите число A: ");
int pow = InPut("Введите степень В: ");

int result = 1;
for (int i = 0; i < pow; i++)
{
    result = result*number;
}

Console.WriteLine($"Число {number} в {pow} степени = {result}");