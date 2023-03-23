// заменить знак числа, и найти число
void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  array[i] = new Random().Next(-9,10); //[-9,9]
}

void Release(int[] array)
{
  for (int i = 0; i < array.Length; i++)
      array[i] = array[i] * (-1);
  Console.WriteLine($"[{string.Join(", ",array)}]");
}

void PrintArray(int[] array)
{
  Console.WriteLine($"[{string.Join(", ",array)}]");
}

string ReleaseNumber(int[] array, int x)
{
  for (int i = 0; i < array.Length; i++)
    if (array[i] == x)
      return "True";
    return "False";
}

Console.Clear();
Console.Write("количество элементов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
Release(array);
Console.Write("искомое значение массива x = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseNumber(array, x));