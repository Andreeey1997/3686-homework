Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
int min = numberB;
if(numberA==numberB)
{
Console.WriteLine("Числа равны");
}
else
{
 if (numberB>max)
 {
 max=numberB;
 min=numberA;
 }
 else
 {
 max=numberA;
 min=numberB;
 }
}
Console.Write("max:");
Console.WriteLine(max);
Console.Write("min:");
Console.WriteLine(min);