// Написать программу масштабирования фигуры.
/* Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"*/

string strValue = "(0,0) (2,0) (2,2) (0,2)";
Console.WriteLine("Введите множитель: ");
double k = double.Parse(Console.ReadLine());

//удаляем "(" , ")" a "," заменяем на пробел.
strValue = strValue.Replace("(", "")
                   .Replace(")", "")
                   .Replace(",", " ");

// разбиваем строку на массив, разделитель в данном случае " " - пробел
string[] strArray = strValue.Split(" ");

string result = string.Empty;

for (int i = 0; i < strArray.Length - 1; i = i + 2)
{
    double x = k * double.Parse(strArray[i]);
    double y = k * double.Parse(strArray[i + 1]);
    result = result + $"({x}, {y}) ";
}

Console.WriteLine($"При k = {k} получаем  {result}");