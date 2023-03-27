// программа переворачивает одномерный массив

void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  array[i] = new Random().Next(-9,10); //[-9,9]
} 

void ReleaseArray(int[] array)
{
  for (int i = 0; i < array.Length / 2; i++)
  {
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
  }
}

Console.Clear();
Console.Write("количество элементов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ",array)}]");
ReleaseArray(array);
Console.WriteLine($"[{string.Join(", ",array)}]");