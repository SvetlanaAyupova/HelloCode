// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

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

string Numbers(int m, int n)
{
    string numbers = string.Empty;
    if (m < n)
        for (int i = m; i <= n; i++)
        {
            numbers += $"{i} ";
        }
    else
        for (int i = m; i >= n; i--)
        {
            numbers += $"{i} ";
        }
    return numbers;
}


int m = GetNumber("Введите число m: ");
int n = GetNumber("Введите число n: ");
Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}: {Numbers(m, n)}");