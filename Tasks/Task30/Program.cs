// Показать кубы чисел, заканчивающихся на чётную цифру.
// Если число заканчивается на чётную цифру, значит всё число является четным.

int InPut(string msg)
{
    Console.Write(msg);
    string? num1 = Console.ReadLine();
    int A = int.Parse(num1);
    return A;
}

int n = InPut("Введите число: ");

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0) Console.WriteLine($"Куб числа {i} = {i * i * i}");
}







