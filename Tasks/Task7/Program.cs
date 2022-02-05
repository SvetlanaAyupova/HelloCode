// Показать числа от -N до N
Console.Write("Введите число N: ");
string numN = Console.ReadLine();
int number = int.Parse(numN);
int min = -number;
while (min <= number)
{
    Console.WriteLine(min);
    min++;
}