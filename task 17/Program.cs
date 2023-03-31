// принимает координаты, ивыводит в какой четверти оно
Console.Clear();
Console.Write("x = ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double y = Convert.ToDouble(Console.ReadLine());
if (x > 0 && y > 0)
  Console.Write("1 четверть");
else if (x > 0 && y < 0)
  Console.Write("4 четверть");
else if (x < 0 && y > 0)
  Console.Write("2 четверть");
else 
  Console.Write("3 четверть");
