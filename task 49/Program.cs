// задать двумерный массивю найти элементы у которых оба индекса четные и заменить их на квадрат
void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i,j] = new Random().Next(1, 10);
      Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
  }
}

void MatrixElementSqrt(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i%2 == 0 && j%2 == 0)
        matrix[i,j] = matrix[i,j] * matrix[i,j];
        Console.Write($"{matrix[i,j]} \t");
    }
    Console.WriteLine();
  }
}

Console.Clear();
Console.Write("введите размер массива ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] array = new int[size[0], size[1]];
InputMatrix(array);
Console.WriteLine();
MatrixElementSqrt(array);











