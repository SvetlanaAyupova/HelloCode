// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите число 1 ->");

String? numberStr1 = Console.ReadLine();

int number1 = int.Parse(numberStr1);

Console.Write("Введите число 2 ->");

String? numberStr2 = Console.ReadLine();

int number2 = int.Parse(numberStr2);

if (number1 == number2 * number2)
{
    Console.WriteLine("Первое число квадрат второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}