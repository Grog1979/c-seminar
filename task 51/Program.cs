// усть массив найти сумму элементов на главной диагонали

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

int SumElementMatrix(int[,] matrix)
{
  int sum = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i == j)
        sum = sum + matrix[i,j];
    }
  }
  return sum;
}

Console.Clear();
Console.Write("введите размер массива ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] array = new int[size[0], size[1]];
InputMatrix(array);
Console.WriteLine();
Console.Write($"sum = {SumElementMatrix(array)}");