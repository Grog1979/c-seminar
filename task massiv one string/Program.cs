// ввод массива одной строкой

Console.Clear();

int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).Select(x => x + 5).ToArray(); // преобразует и выполняет действие х+5
// int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); просто преобразует
Console.WriteLine($"[{string.Join(", ",array)}]");


foreach (int elem in array)
  Console.WriteLine(elem*100);
