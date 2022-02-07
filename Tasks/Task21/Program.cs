// Программа проверяет пятизначное число на палиндромом.

int InPut(string msg)
{
    Console.Write(msg);
    string? num1 = Console.ReadLine();
    int A = int.Parse(num1);
    return A;
}

int numOne = InPut("Введите пятизначное число");

bool valueOne = numOne % 10 == numOne / 10000;
bool valueTwo = (numOne % 100)/10 == (numOne / 1000) % 10;

if(valueOne && valueTwo)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");