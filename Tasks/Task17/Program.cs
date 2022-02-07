// По двум заданным числам проверять является ли одно квадратом другого

int InPut(string msg)
{
    Console.Write(msg);
    string? num1 = Console.ReadLine();
    int A = int.Parse(num1);
    return A;
}

int numOne = InPut("Введите первое число: ");
int numTwo = InPut("Введите второе число: ");

if(numOne == numTwo * numTwo)
{
    Console.WriteLine($"{numOne} является квадратом {numTwo}");
}
else if(numTwo == numOne * numOne)
{
    Console.WriteLine($"{numTwo} является квадратом {numOne}");
}
else
{
    Console.WriteLine($"Ни одно число не является квадратом другого числа");
}