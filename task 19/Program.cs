// координаты двух точек, растояние между ними в 2d


Console.Write("x1 = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1 = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("x2 = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2 = ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2)+Math.Pow(y1 - y2, 2))); //Math.Sqr квадратный корень Math.Pow квадрат числа
