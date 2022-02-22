// Написать программу преобразования десятичного числа в двоичное.

int InPut()
{
    Console.Write("Введите десятичное число: ");
    string? input = Console.ReadLine();
    int.TryParse(input, out int number);
    return number;
}

int number = InPut();
int numberOst = 0;
int result = 0;
int k = 1; // Разряд числа.


while (number != 0)
{
    numberOst = number % 2;
    number = number / 2;
    result += numberOst * k;
    k = k * 10;
}

Console.WriteLine($"Двоичное число: {result}");





