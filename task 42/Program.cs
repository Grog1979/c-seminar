// переводит десятичное число в двоичное

Console.Clear();
Console.Write("enter number: ");
int n = Convert.ToInt32(Console.ReadLine());

string res = string.Empty;
while (n > 0)
{
  res = Convert.ToString(n % 2) + res; // не res + n%2, а наоборот что бы вывести в обратном порядке
  n /= 2;
}
Console.WriteLine(res);

