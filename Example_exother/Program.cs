﻿// Масштабирование

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "") // Замена скобки
                .Replace(")", "")
                ;
Console.WriteLine(text);

var data = text.Split(" ") // Разбивка при помощи символа разделителя, н-р, пробел.
                .Select(item => item.Split(',')) // Выборка элементов, для которых сделать разбивку с учетом разделителя "запятая"
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // Выборка из текущего массива, 
                //где первая координата будет взята как первый элемент массива и конвертированна в число и то же самое со второй.
                .Where(e => e.x % 2 == 0) // Проверка условия выборки.(пары, где первая координата четная).
                .Select(point => (point.x * 10, point.y)) // Взять набор, кот. получили на предыдущем этапе
                // и первые координаты увеличить на 10.
                .ToArray(); // Преобразование в явный массив.

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    Console.WriteLine();
}