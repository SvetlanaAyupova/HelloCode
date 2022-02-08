// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int InPut(string msg)
{
    Console.Write(msg);
    string? num1 = Console.ReadLine();
    return int.Parse(num1);
}



void Execute (int x, int y)
{
    if(x>0 && y>0)
        Console.WriteLine("Точка в I четверти");
    else if (x<0 && y>0)
        Console.WriteLine("Точка во II четверти");
    else if (x<0 && y<0)
        Console.WriteLine("Точка в III четверти");
    else if (x>0 && y<0)
        Console.WriteLine("Точка во IV четверти");
    else if (x==0 && y==0)
        Console.WriteLine("Точка в начале координат");
    else
        Console.WriteLine("Точка вне четверти, она на оси координат!!!");
}

int x = InPut("Введите координаты точки X: ");

int y = InPut("Введите координаты точки Y: ");

Execute(x,y);