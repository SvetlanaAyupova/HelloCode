// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int GetNumber()
{
    int randomNumber = new Random().Next(20,100);
    return randomNumber;
}

int number = GetNumber();
Console.WriteLine($"Первое случайное число: {number}");

int secondNumber = GetNumber();
Console.WriteLine($"Второе случайное число: {secondNumber}");

IsMultiple(number, secondNumber);

void IsMultiple(int firstNumber, int secondNumber)
{
    if(firstNumber>secondNumber)
    {
        int result = firstNumber % secondNumber;
        if(result==0)
            Console.WriteLine($"{firstNumber} кратно {secondNumber}");
        else
            Console.WriteLine($"Остаток от деления: {result}");
    }
    else
    {
        int result = secondNumber % firstNumber;
        if(result==0)
            Console.WriteLine($"{secondNumber} кратно {firstNumber}");
        else
            Console.WriteLine($"Остаток от деления: {result}");
    }
}