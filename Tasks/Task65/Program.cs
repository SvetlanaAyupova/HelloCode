// 65. Спирально заполнить двумерный массив:
/*Например:
  1  2  3  4
 12 13 14  5
 11 16 15  6
 10  9  8  7 
*/


int[,] arr = new int[4, 4];


void SpiralFill(int[,] arr)
{
  int startNumber = 1;
  int RowIndex = 0;
  int ColIndex = 0;
  int RowLength = arr.GetLength(0);
  int ColLength = arr.GetLength(1);

  while (RowIndex < RowLength && ColIndex < ColLength)
  {
    for (int j = ColIndex; j < ColLength; j++)
    {
      arr[RowIndex, j] = startNumber;
      startNumber++;
    }
    RowIndex++;

    for (int i = RowIndex; i < RowLength; i++)
    {
      arr[i, ColLength - 1] = startNumber;
      startNumber++;
    }
    ColLength--;

    if (RowIndex < RowLength)
    {
      for (int j = ColLength - 1; j >= ColIndex; j--)
      {
        arr[RowLength - 1, j] = startNumber;
        startNumber++;
      }
    }
    RowLength--;

    if (ColIndex < ColLength)
    {
      for (int i = RowLength - 1; i >= RowIndex; --i)
      {
        arr[i, ColIndex] = startNumber;
        startNumber++;
      }
    }
    ColIndex++;
  }
}

void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (arr[i, j] < 10)
      {
        Console.Write($"  {arr[i, j]} ");
      }
      else
      {
        Console.Write($" {arr[i, j]} ");
      }
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

SpiralFill(arr);
PrintArray(arr);