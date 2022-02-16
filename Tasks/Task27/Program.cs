// Определить количество цифр в числе

int InPut(string msg)
{
    Console.Write(msg);
    string? num1 = Console.ReadLine();
    int A = int.Parse(num1);
    return A;
}

int number = InPut("Введите число: ");

int countOfDigit = 0;
while (number != 0)
{
    number = number/10;
    countOfDigit++;
} 
    

Console.WriteLine(countOfDigit);