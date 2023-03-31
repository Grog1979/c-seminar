// принимает на вход число и выдает количество цифр в числе

int f(int n)
{
  if (n == 0)
    return 1;
  int i = 0;
  while (n != 0)
    {
      n /= 10; // n = n/10
      i++;
    }
  return i;  
}
Console.Clear();
Console.Write("Введите число а = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a));