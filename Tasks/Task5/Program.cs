// Написать программу вычисления значения функции y = f(a)

Console.WriteLine("y = 7*x*x + 3*x + 6");

Console.Write("Введите значение x: ");

String? numberStr = Console.ReadLine();

int x = int.Parse(numberStr);

Console.WriteLine($"y = { 7 * x * x + 3 * x + 6 } ");