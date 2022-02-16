// Найти сумму чисел от 1 до А

int InPut(string msg)
{
    Console.Write(msg);
    string? num1 = Console.ReadLine();
    int A = int.Parse(num1);
    return A;
}

int number = InPut("Введите число до которого хотите найти сумму: ");
int sum = 0;

for (int i = 0; i <= number; i++)
{
    sum += i;
}

Console.WriteLine($"Сумма всех чисел до требуемой = {sum}");