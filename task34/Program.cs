Random rand = new Random();
void GetRandomArray(int[] array)
{
for (int i = 0; i<array.Length; i++)
 {
 array[i] = rand.Next(100,1000);
 }
}

int[] array = new int[10];
GetRandomArray(array);
Console.WriteLine($"{string.Join(",", array)}");

int count = 0;
for (int i=0; i<array.Length; i++)
{
 if (array[i]%2==0)
 {
 count+=1;
 }
}
Console.WriteLine($"Количество четных элементов массива: {count}");