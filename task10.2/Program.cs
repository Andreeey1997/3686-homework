int number = new Random().Next(100,1000);
Console.WriteLine(number);

if (number/100>0)
{
int SecondDigit = (number%100)/10;
Console.WriteLine(SecondDigit);
}
else
{
Console.WriteLine("Введите трехзначное число");
}