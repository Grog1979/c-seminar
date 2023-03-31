// принимает на вход число и выдает произведение от 1 до n


int factorial(int n)
{
  if (n == 0)
    return 0;
  int fact = 1;
  for (int i = 2; i <= n; i++)
  {
    fact = fact * i; // fact *=i
  }
  return fact;
}
Console.Clear();
Console.Write("Введите число а = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(factorial(a));