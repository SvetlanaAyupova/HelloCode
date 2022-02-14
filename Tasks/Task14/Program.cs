// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите целое число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

while (number >= 1000)
{
    number = number/10;
}

if(number > 100)
{
    Console.WriteLine($"Третья цифра числа: {number % 10}");
}
else
{
    Console.WriteLine("В числе нет третьей цифры");
}