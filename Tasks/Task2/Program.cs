// Даны два числа. Показать большее и меньшее число

int numberA = new Random().Next(1, 100);
Console.WriteLine($"Первое число: {numberA}");
int numberB = new Random().Next(1, 100);
Console.WriteLine($"Второе число: {numberB}");
if (numberA > numberB)
{
    Console.WriteLine($"Большее число: {numberA}");
    Console.WriteLine($"Меньшее число: {numberB}");
}
else
{
    Console.WriteLine($"Большее число: {numberB}");
    Console.WriteLine($"Меньшее число: {numberA}");
}
if (numberA == numberB)
{
    Console.WriteLine("Числа равны");
}