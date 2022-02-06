// Удалить вторую цифру трёхзначного числа

int GetFirstDigit(int number)
{
    return number / 100;
}

int GetThirdDigit(int number)
{
    return number % 10;
}

int GetIntegerFromConsole(int min, int max)
{
    int result = 0;
    bool isError = true;
    while (isError)
    {
        Console.Write($"Введите целое число от {min} по {max}: ");
        string input = Console.ReadLine();
        result = int.Parse(input);
        isError = result<min || result>max;
    }
    return result;
}

int number = GetIntegerFromConsole(100,999);
int firstDigit = GetFirstDigit(number);
int thirdDigit = GetThirdDigit(number);

Console.WriteLine($"Число после удаления второй цифры: {firstDigit}{thirdDigit}");

// Либо Console.WriteLine($"Число после удаления второй цифры: {firstDigit*10+thirdDigit}");