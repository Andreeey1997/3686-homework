Random rand = new Random();

void GetRandomArray(int [] array)
{
for (int i = 0; i<array.Length; i++)
 {
 array[i] = rand.Next(100,1000);
 }
}

int[] array = new int[10];
GetRandomArray(array);
Console.WriteLine($"{string.Join(",", array)}");

int sum = 0;
for (int i=0; i<array.Length; i++)
{
 if (i%2 != 0)
 {
 sum = sum + array[i];
 }
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");