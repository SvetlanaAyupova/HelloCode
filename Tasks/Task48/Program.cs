﻿// Показать двумерный массив размером m×n заполненный целыми числами.

int[,] arr = new int[6, 5];
Random rand = new Random();

void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rand.Next(1,100);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

FillArray();
PrintArray();
