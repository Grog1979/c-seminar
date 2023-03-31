// array
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10,11); //[-10,10]

Console.WriteLine($"[{string.Join(",  ", array)}]");

string[] array_s = new string[8];// массив из строк