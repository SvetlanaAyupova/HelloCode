// Дано число. Проверить кратно ли оно 7 и 23

bool CheckIfModed(int number)
{
    return number % 7 ==0 && number % 23 ==0;
}


Console.Write("Введите число -> ");

String? numberStr = Console.ReadLine();

int number = int.Parse(numberStr);

if (CheckIfModed(number))
    Console.WriteLine($"Число {number} кратно 7 и 23");
else
    Console.WriteLine($"Число {number} не кратно 7 и 23");