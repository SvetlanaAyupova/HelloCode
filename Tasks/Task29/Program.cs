// Написать программу вычисления произведения чисел от 1 до N

int InPut(string msg)
{
    Console.Write(msg);
    string? num1 = Console.ReadLine();
    int A = int.Parse(num1);
    return A;
}

int Multiple(int number)
{
    int productOfNumber = 1;
    for (int i = 1; i <= number; i++)
    {
        productOfNumber = productOfNumber*i;
    }
    return productOfNumber;
}

int number = InPut("Введите число N: ");
int result = Multiple(number);
Console.WriteLine($"Произведение всех чисел до N = {result}");