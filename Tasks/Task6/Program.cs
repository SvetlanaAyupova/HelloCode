// Выяснить является ли число чётным

Console.Write("Введите число ->");
String? numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number%2 == 0)
{
    Console.WriteLine("Чётное число");
}
else
{
    Console.WriteLine("Нечётное число");
}