// выводит два случайных числа из отрезка [10,99]
//и показывает наибольшую цифру числа

Console.Clear();
int n = new Random().Next(10, 100);
Console.WriteLine($"random = {n}");
int n1 = n / 10;
int n2 = n % 10;
if (n1 > n2)
  Console.WriteLine(n1);
else if (n1 < n2)
  Console.WriteLine(n2);
else
  Console.WriteLine("=");

  // выводит случайное трехзначное число и убирает второе

int n3 = new Random().Next(100, 1000);
Console.WriteLine($"random = {n3}");
int n4 = n3 / 100;
int n5 = n3 % 10;
Console.Write(n4);       //Console.Write($"{n4}{n5}")
Console.WriteLine(n5);   //Console.Write(n4 * 10 + n5)

//принимает на вход два числа и смотрит является ли одно кратное второму
//если не кратное то выводит остаток

Console.Write("write number  ");
int n6 = Convert.ToInt32(Console.ReadLine());
Console.Write("write number  ");
int n7 = Convert.ToInt32(Console.ReadLine());

if (n6 % n7 == 0)
  Console.WriteLine("кратное");
else
  Console.WriteLine(n6 - (n6/n7) * n7);//Console.WriteLine($"не кратное, остаток =  {n6 % n7}");

 // принимает число и проверяет кратноли оно 7 и 23 одновременно

Console.Write("write number  ");
int n8 = Convert.ToInt32(Console.ReadLine());
if (n8 % 7 == 0 && n8 % 23 == 0)
  Console.WriteLine("кратное");
else
  Console.WriteLine("не кратное");

//принимает на вход два числа и проверяет кратноли одно другому

Console.Write("write number  ");
int n9 = Convert.ToInt32(Console.ReadLine());
Console.Write("write number  ");
int n10 = Convert.ToInt32(Console.ReadLine());
if (n9 % n10 == 0 || n10 % n9 == 0) // n9*n9=n10 || n10*n10=n9 если квадрат второго.
  Console.WriteLine("кратное");
else
  Console.WriteLine("не кратное");