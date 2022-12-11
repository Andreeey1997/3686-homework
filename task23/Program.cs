Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
for (i = 1; i <= n; i++)
{
Console.WriteLine ($"Куб числа от 1 до {n} где {i}^3 {i * i * i}");
}