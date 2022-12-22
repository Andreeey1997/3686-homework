Console.WriteLine ("Две прямые имеют уравнения: y = k1*x + b1 и y = k2*x + b2");
Console.WriteLine ("Введите значение переменной b1:");
double B1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Введите значение переменной k1:");
double K1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Введите значение переменной b2:");
double B2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Введите значение переменной k2:");
double K2 = Convert.ToDouble(Console.ReadLine());

if (K1 == K2)
{
Console.WriteLine ("Прямые параллельны и не имеют точки пересечения:");
}
else
{
double CoordinateX = (B2-B1)/(K1-K2);
double CoordinateY = K1*((B2-B1)/(K1-K2))+B1;
Console.WriteLine($"Точка пересечения двух прямых: ({CoordinateX}; {CoordinateY})");
}
