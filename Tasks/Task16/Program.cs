// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int GetNumber()
{
    int randomNumber = new Random().Next(1,8);
    return randomNumber;
}

int number = GetNumber();
Console.WriteLine($"День недели: {number}");

if (number < 6)
{
    Console.WriteLine("Будний день");
}
else
{
    Console.WriteLine("Выходной день");
}