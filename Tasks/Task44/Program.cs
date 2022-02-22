// Найти точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2,
// b1 k1 и b2 и k2 заданы.

double GetNumber (string msg)
{
    Console.Write(msg);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double k1 = GetNumber("Введите k1 для y = k1 * x + b1: ");
double b1 = GetNumber("Введите b1 для y = k1 * x + b1: ");
double k2 = GetNumber("Введите k2 для y = k2 * x + b2: ");
double b2 = GetNumber("Введите b2 для y = k2 * x + b2: ");

if (k1 == k2)
    Console.WriteLine ("Прямые не пересекаются.");

double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;
Console.WriteLine ($"Прямые пересекаются в точке ({x}; {y}).");
