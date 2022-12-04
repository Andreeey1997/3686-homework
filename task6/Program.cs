Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = number%2;

if (result==0)
{
Console.WriteLine("Число четное");
}
else
{
Console.WriteLine("Число нечетное");
}