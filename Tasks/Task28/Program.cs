// Подсчитать сумму цифр в числе

int InPut(string msg)
{
    Console.Write(msg);
    string? num1 = Console.ReadLine();
    int A = int.Parse(num1);
    return A;
}

int number = InPut("Введите число: ");

int sumOfDigit = 0;
while (number > 0)
{
    sumOfDigit = sumOfDigit + number % 10;
    number = number /10 ;
}

Console.WriteLine($"Сумма цифр в числе: {sumOfDigit}");