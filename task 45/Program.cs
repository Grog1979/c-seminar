// напишите программу. которая будет создавать копию
// заданного массива с помощью поэлементного копиравания

void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  array[i] = new Random().Next(-9,10); //[-9,9]
}

void Release(int[] array, int[] array1)
{
  for (int i = 0; i < array.Length; i++)
  {
    array1[i] = array[i];
  }
  Console.WriteLine($"[{string.Join(", ",array)}]");  
}



void PrintArray(int[] array)
{
  Console.WriteLine($"[{string.Join(", ",array)}]");
}


Console.Clear();
Console.Write("количество элементов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] array1 = new int[n];
InputArray(array);
PrintArray(array);
// InputArray(array1);
PrintArray(array1);
Release(array, array1);
array1[1] = 88;
PrintArray(array1);


// Array.Copy(array, array1, array.Length) можно просто сделать копию
// если сделать array1[] = array[] то это будет не копирование а ссылка на массив.