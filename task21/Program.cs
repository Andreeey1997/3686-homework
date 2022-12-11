Console.WriteLine("Введите координаты X(1)");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y(1)");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z(1)");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты X(2)");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y(2)");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z(2)");
int z2 = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine($"Итог:{res}");