// массив из 123 случайных чисел найти количество чисел лежащих в пределах [10,99]

void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  array[i] = new Random().Next(0, 100); 
}

int Release(int[] array)
{
  int k = 0;
  for (int i = 0; i < array.Length; i++)
    if (array[i] >= 10 && array[i] <= 99)
    k++;
  return k;
}

void PrintArray(int[] array)
{
  Console.WriteLine($"[{string.Join(", ",array)}]");
}
// в одномерном массиве перемножить пары элементов (первый и последний, и на сближение)

void ReleaseArray(int[] array)
{  
  for (int i = 0; i < array.Length / 2 + array.Length % 2; i++) // если массив не четный добавляется еденица и перемножается средний элемент
    Console.WriteLine($"{array[i] * array[array.Length - 1 - i]} ");
}





Console.Clear();
Console.Write("количество элементов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
Console.WriteLine(Release(array));
ReleaseArray(array);