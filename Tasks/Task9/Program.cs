// Показать последнюю цифру трёхзначного числа

int GetLastDigit(int number)
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
int lastDigit = GetLastDigit(number);
Console.WriteLine(lastDigit);