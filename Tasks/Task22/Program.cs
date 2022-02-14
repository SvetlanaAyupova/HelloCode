// Найти расстояние между точками в пространстве 2D.
// Для нахождения расстояния в 3D, добавить в координаты z для этих точек.
// А формула будет "double sum = ((b1 - a1) * (b1 - a1)) + ((b2 - a2) * (b2 - a2)) + ((b3 - a3) * (b3 - a3))".

int InPut(string msg)
{
    Console.Write(msg);
    string? num1 = Console.ReadLine();
    return int.Parse(num1);
}


double Distance(int a1, int a2, int b1, int b2)
{
    double sum = ((b1 - a1) * (b1 - a1)) + ((b2 - a2) * (b2 - a2));
    return Math.Sqrt(sum);
}

int x1 = InPut("Введите координату X1: ");
int y1 = InPut("Введите координату Y1: ");
int x2 = InPut("Введите координату X2: ");
int y2 = InPut("Введите координату Y2: ");

double distance = Distance(x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точками: {distance}");