// Найти сумму элементов от M до N, N и M заданы.

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

int Sum(int m, int n)
{
    int sum = 0;
    if (m < n)
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
    else
        for (int i = m; i >= n; i--)
        {
            sum += i;
        }
    return sum;
}

int m = GetNumber("Введите число m: ");
int n = GetNumber("Введите число n: ");
Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} = {Sum(m, n)}");