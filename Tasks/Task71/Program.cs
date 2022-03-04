// Написать программу вычисления функции Аккермана.

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool checkStatus = true;
    int numberInt = 0;
    while (checkStatus)
    {
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out numberInt))
        {
            checkStatus = false;
            break;
        }
        else
            Console.WriteLine("Ввели не число");
    }
    return numberInt;
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = GetNumber("Введите неотрицательное число m: ");
int n = GetNumber("Введите неотрицательное число n: ");

Console.Write($"Результат функции Аккермана = {Akkerman(m, n)}");