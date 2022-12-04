int MAX (int numberA, int numberB, int numberC)
{
int result = numberA;
if (numberB>result) result = numberB;
if (numberC>result) result = numberC;
return result;
}

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = MAX(numberA, numberB, numberC);
Console.Write("max:");
Console.WriteLine(max);