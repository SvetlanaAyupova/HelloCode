// Выяснить являются ли три числа сторонами треугольника.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// Получаем три числа.

int GetRandomNumber()
{
    int randomNumber = new Random().Next(1, 10);
    return randomNumber;
}

// Сравниваем число с суммой двух других.

bool SumTwoNumber (int a, int b, int c)
{
    return a < (b+c);
}

int numberOne = GetRandomNumber();
int numberTwo = GetRandomNumber();
int numberThree = GetRandomNumber();
Console.WriteLine($"Первое число - {numberOne}. Второе число - {numberTwo}. Третье число - {numberThree}.");

if (SumTwoNumber(numberOne, numberTwo, numberThree)
&& SumTwoNumber(numberTwo, numberOne, numberThree)
&& SumTwoNumber(numberThree, numberOne, numberTwo))
    Console.WriteLine("Числа являются сторонами треугольника");
else
    Console.WriteLine("Числа не являются сторонами треугольника");