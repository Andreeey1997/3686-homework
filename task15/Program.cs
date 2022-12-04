Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <=7)
{
 if (number == 6 || number == 7)
 {
 Console.WriteLine("Да, это выходной");
 }
 else
 {
 Console.WriteLine("Нет, это не выходной");
 }
}
else
{
Console.WriteLine("Такого дня недели не существует");
}