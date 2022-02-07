// Вид 1.

void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1();


// Вид 2.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

// Или

void Method21(String msg, int count)
{
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg:"Текст", count:4);


// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);


// Вид 4

string Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;

    while(i<count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "za");
//Console.WriteLine(res);





// Вывод таблицы умножения с помощью for.
/*for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}*/





//========Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить на черточки,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

/*string text = "– Ну что же, – задумчиво отозвался тот, – они – люди как люди. Любят деньги, но ведь это всегда было…"
            + "Человечество любит деньги, из чего бы те ни были Сделаны, из кожи ли, из бумаги ли, из бронзы или золота."
            + "Ну, легкомысленны… ну, что ж… и милосердие иногда Стучится в их Сердца… обыкновенные люди…"
            + "В общем, напоминают прежних… квартирный вопрос только испортил их…";


// string s = "qwerty"
//             012345
// s[3]  // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
string newText1 = Replace(newText, 'к', 'К');
Console.WriteLine(newText1);
Console.WriteLine();
string newText2 = Replace(newText1, 'С', 'с');
Console.WriteLine(newText2);*/


int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);