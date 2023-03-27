// принимает на вход три числа и проверяет
// может ли существовать треугольник  со сторонами такой длинны
// сумма двух сторон не должна быть меньше третьей



void ReleaseArray(int[] array)
{
  if (array[0] + array[1] > array[2] && array[2] + array[1] > array[0] && array[0] + array[2] > array[1])
    Console.WriteLine("true");
  else
    Console.WriteLine("false");
}

Console.Clear();
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"[{string.Join(", ",array)}]");
ReleaseArray(array);
