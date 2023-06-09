﻿// задача 48 задать двумерный массив, размером  m на n
// каждый элемент в массиве находится А[i,j] = i+j

void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i,j] = i + j;
      Console.Write($"{matrix[i,j]} \t");
    }
    Console.WriteLine();
  }
}

Console.Clear();
Console.Write("введите размер матрицы ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] array = new int[size[0], size[1]];
InputMatrix(array);