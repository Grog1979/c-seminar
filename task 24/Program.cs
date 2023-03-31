// принимает число n и выдаут сумму чисел от 1 до а

double sum(double n)
{
  return((1+n)/2*n);
}
Console.Clear();
Console.Write("Введите число а = ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(a));