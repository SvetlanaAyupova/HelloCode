// Показать натуральные числа от 1 до N, N задано.

/*string NumbersFor (int n)
{
    string result = string.Empty;
    for (int i = 1; i <= n; i++)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine ($"Итеративный метод: {NumbersFor(10)}");


string NumbersRec (int a, int n)
{
    if (a<=n) return $"{a} " + NumbersRec (a+1,n);
    else return string.Empty;
}
Console.WriteLine ($"Рекурсивный метод: {NumbersRec(1, 10)}");*/

//Показать натуральные числа от N до 1, N задано.

/*string NumbersFor (int n)
{
    string result = string.Empty;
    for (int i = n; i >= 1; i--)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine ($"Итеративный метод: {NumbersFor(10)}");


string NumbersRec (int a, int n)
{
    if (a<=n) return NumbersRec (a+1,n) + $"{a} ";
    else return string.Empty;
}
Console.WriteLine ($"Рекурсивный метод: {NumbersRec(1, 10)}");*/

//Найти сумму цифр числа

/*int CheckInputIsNumber(string text)
{
    int number;
    Console.WriteLine(text);
    string input = Console.ReadLine();
    bool isNum = int.TryParse(input, out number);

    while (!isNum)
    {
        Console.WriteLine("Вы ввели не целое число! Попробуйте ещё раз: ");
        input = Console.ReadLine();
        isNum = int.TryParse(input, out number);
    }

    return number;
}

int Summ(int num)
{
    if (num < 10) return num;
    else return num % 10 + Summ(num / 10);
}

int num = CheckInputIsNumber("Введите число n: ");
Console.Write($"Сумма цифр числа равна: {Summ(num)} ");
Console.WriteLine();*/

// Найти сумму элементов от 1 до N, N задано

/*int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++)
    {
        result += i;
    }
    return result;
}
Console.WriteLine($"Итеративный метод: {SumFor(5)}");


int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine($"Рекурсивный метод: {SumRec(5)}");*/

//Факториал

/*int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}
Console.WriteLine($"Итеративный метод: {FactorialFor(5)}");


int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
Console.WriteLine($"Рекурсивный метод: {FactorialRec(5)}");*/

//Написать программу возведения числа А в целую степень B.

/*int PowerFor(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}
Console.WriteLine($"Итеративный метод: {PowerFor(2,10)}");


int PowerRec(int a, int b)
{
    if (b == 0) return 1;
    else return PowerRec(a, b - 1)*a;
}
Console.WriteLine($"Рекурсивный метод: {PowerRec(2, 10)}");

int PowerRecMath(int a, int b)
{
    if (b == 0) return 1;
    else if (b%2 == 0) return PowerRecMath (a*a, b/2);
    else return PowerRecMath(a, b - 1)*a;
}
Console.WriteLine($"Рекурсивный метод: {PowerRecMath(2, 10)}");*/

// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.

/*int n = 1;
void FindWords (string alphabet, char[]word, int length = 0)
{
    if (length == word.Length)
    {
        Console.Write ($"{n++} - {new String (word)} ");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords ("аисв", new char[3]);*/

// Обход директория(Просмотр всех папок и файлов в папке).

/*string path = "C:/Users/user/Desktop/Examples/Example007_Magic";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent} {catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent} {files[i].Name}");
    }
}
CatalogInfo(path);*/

// Игра в пирамидки.
           //начальная позиция, конечная позиция, промежуточная,    количество блинов
/*void Towers (string with = "1", string on = "3", string some = "2", int count = 5)
{
    if (count > 1) Towers (with, some, on, count - 1);
    Console.WriteLine ($"{with} >> {on}");
    if (count > 1) Towers (some, on, with, count - 1);
}
Towers();*/

// Обход разных структур (Бинарное дерево ((4-2)*(1+3))/10).

string emp = String.Empty;
string[]tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
void InOrderTraversal (int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2*pos;
        int right = 2*pos+1;
        if (left<tree.Length && !String.IsNullOrEmpty(tree[left]))
        {
            InOrderTraversal (left);
        }
        Console.WriteLine (tree[pos]);
        if (right<tree.Length && !String.IsNullOrEmpty(tree[right]))
        {
            InOrderTraversal (right);
        }
    }
}

InOrderTraversal();