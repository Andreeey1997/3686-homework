int MAX(int numberA, int numberB)
{
int result = numberA;
if (numberB>result) result = numberB;
return result;
}

int MIN(int numberA, int numberB)
{
int result = numberA;
if (numberB < result) result = numberB;
return result;
}

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = MAX(numberA, numberB);
int min = MIN(numberA, numberB);

Console.Write("max:");
Console.WriteLine(max);
Console.Write("min:");
Console.WriteLine(min);