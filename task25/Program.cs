Console.WriteLine("Введите число, которое нужно возвести в степень: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целую положительную степень: ");
int B = Convert.ToInt32(Console.ReadLine());

int AinExtentB = 1;

for (int i = 1; i <= B; i++)
{
AinExtentB = AinExtentB * A;
}

Console.WriteLine ($"{A}^{B} это {AinExtentB}");