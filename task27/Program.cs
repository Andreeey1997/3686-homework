int ReadInt(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

int GetSumOfDigits(int number)
{
 number = Math.Abs(number);
 int sum = 0;
 while (number > 0)
 {
 sum = sum + number%10;
 number /=10;
 }
 return sum;
}

int number = ReadInt("Введите число");
int result = GetSumOfDigits(number);
Console.WriteLine(result);