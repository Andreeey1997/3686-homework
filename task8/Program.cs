Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
int result = i%2;
if (result == 0)
 {
 Console.WriteLine(i);
 }
}
