// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

/*int [] arr = new int [] { 1, 9, 9, 0, 2, 8, 0, 9 };

Dictionary<int, int> Execut()                                  //Словарь Dictionary
{
    Dictionary<int, int> dic = new Dictionary<int, int>();     // Создаем словарь
    for (int i = 0; i < arr.Length; i++)
    {
        if (dic.ContainsKey(arr[i]))                           // Проверяем есть ли такой ключ в словаре (в данном случае элементы массива)
            dic[arr[i]] = dic[arr[i]]+1;                      // Если есть данный ключ, то обращаемся к нему и прибавляем значение
        else
            dic.Add(arr[i], 1);                               // Если нет то создаем ключ и присваиваем ему значение
    }
    return dic;
}

void PrintDic(Dictionary<int, int> dicc)
{
    foreach (var item in dicc)
    {
        Console.WriteLine($"{item.Key} встречается {item.Value} раз.");   //item.Key обращаемся к нашему ключу, item.Value - это значение.
    }
}

PrintDic (Execut());*/


int [,] arr = new int [5,5];

void FillArray()
{
    Random number = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i,j] = number.Next(1,100);
        }
    }
}

void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write ($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

Dictionary<int, int> Execut()                                  //Словарь Dictionary
{
    Dictionary<int, int> dic = new Dictionary<int, int>();     // Создаем словарь
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (dic.ContainsKey(arr[i,j]))                           // Проверяем есть ли такой ключ в словаре (в данном случае элементы массива)
                dic[arr[i,j]] = dic[arr[i,j]]+1;                      // Если есть данный ключ, то обращаемся к нему и прибавляем значение
            else
                dic.Add(arr[i,j], 1);                               // Если нет то создаем ключ и присваиваем ему значение
        }
    }
    return dic;
}

void PrintDic(Dictionary<int, int> dicc)
{
    foreach (var item in dicc)
    {
        Console.WriteLine($"Число {item.Key} встречается {item.Value} раз.");   //item.Key обращаемся к нашему ключу, item.Value - это значение.
    }
}


FillArray();
PrintArray(arr);
Console.WriteLine();
PrintDic (Execut());