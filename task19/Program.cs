Console.WriteLine("Введите число, состоящее из 5 цифр: ");
int Number = Convert.ToInt32(Console.ReadLine());

int NewNumber = 0;

int temp = Number;

while (temp > 0)
{
NewNumber = NewNumber*10 + temp%10;
temp = temp/10;
}

if (NewNumber == Number)
{
Console.WriteLine("Да, палиндром");
}
else
{
Console.WriteLine("Нет, не палиндром");
}