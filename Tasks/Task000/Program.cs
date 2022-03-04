// Есть две даты, нужно вывести на экран количество полных лет.
// Количество полных дней. И показать кто из них старше и насколько.

DateTime firstData = new DateTime(1950, 01, 01);
DateTime secondData = new DateTime(1955, 03, 03);

Console.WriteLine ($"Первая дата - {firstData.ToShortDateString()}");
Console.WriteLine ($"Вторая дата - {secondData.ToShortDateString()}");

DateTime today = DateTime.Now;

int oldFirst = today.Year - firstData.Year;
int oldSecond = today.Year - secondData.Year;
double diffFirst = (DateTime.Now - firstData).TotalDays;
double diffSecond = (DateTime.Now - secondData).TotalDays;

Console.WriteLine();
Console.WriteLine ($"Возраст первого {oldFirst} лет или {diffFirst:F0} дней.");
Console.WriteLine ($"Возраст второго {oldSecond} лет или {diffSecond:F0} дней.");
if (oldFirst > oldSecond)
    Console.WriteLine ($"Первый старше второго на {oldFirst - oldSecond} лет.");
else
    Console.WriteLine ($"Второй старше первого на {oldSecond - oldFirst} лет.");

