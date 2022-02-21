// Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива.

int sumPol = 0;
int sumOtr = 0;
int[] array = new int[12];
Console.WriteLine("Создали массив");

Random randomNum = new Random();
for (int i = 0; i < 12; i++)
{
    array[i] = randomNum.Next(-9, 10);
    Console.Write($"{array[i]} ");
    if (array[i] > 0)
        sumPol = sumPol + array[i];
    else
        sumOtr = sumOtr + array[i];
}

Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {sumPol}");
Console.WriteLine($"Сумма отрицательных чисел = {sumOtr}");