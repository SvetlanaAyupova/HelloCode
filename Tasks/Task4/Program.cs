// Найти максимальное из трех чисел

int numberA = new Random().Next(1, 100);
Console.WriteLine($"Первое число: {numberA}");

int numberB = new Random().Next(1, 100);
Console.WriteLine($"Второе число: {numberB}");

int numberC = new Random().Next(1, 100);
Console.WriteLine($"Третье число: {numberC}");

int max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine($"Максимальное число: {max}");