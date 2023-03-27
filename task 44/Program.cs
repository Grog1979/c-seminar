// не используя рекурсию вывести первые n чисел фибоначи
// fn=fn-1 + fn-2


Console.Clear();
Console.Write("enter number: ");
int n = Convert.ToInt32(Console.ReadLine());

int a0 = 0, a1 = 1, x;

for (int i = 0; i < n; i++)
{
  Console.Write($"{a0} ");
  x = a0 + a1;
  a0 = a1;
  a1 = x;
}