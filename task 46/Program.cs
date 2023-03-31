// задача 46 создать массив двумерный заполненый случайными целыми числами

void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i,j] = new Random().Next(-10, 10);
      Console.Write($"{matrix[i, j]} \t"); // \t табуляция для более красивого вывода матрицы
      // выравнивает по первому знаку
    }
    Console.WriteLine();
  }
}





Console.Clear();
Console.Write("введите размер матрицы ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] array = new int[size[0], size[1]];
InputMatrix(array);