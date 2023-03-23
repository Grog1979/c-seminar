// задача 31 масиив из 12 чисел
// сумма отриц и полож чисел

void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  array[i] = new Random().Next(-9,10); //[-9,9]
}

void Release(int[] array)
{
  int sumPositive = 0, sumNegative = 0;
  for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)
      sumPositive += array[i];
    else
      sumNegative += array[i];
  Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");
  Console.WriteLine($"Сумма положительных элементов = {sumPositive}"); 
}

void PrintArray(int[] array)
{
  Console.WriteLine($"[{string.Join(", ",array)}]");
}

Console.Clear();
Console.Write("количество элементов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
Release(array);

