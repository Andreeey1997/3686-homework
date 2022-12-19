int[] GetRandomArray(int length, int LeftRange, int RightRange)
{
int[] array = new int [length];
Random rand = new Random();
for (int i = 0; i<array.Length; i++)
 {
 array[i] = rand.Next(LeftRange, RightRange+1);
 }
return array;
}

const int LENGTH = 123;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 150;

int [] array = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", array)}");

int count = 0;

for (int i = 0; i<array.Length; i++)
{
if (array[i]>=10 && array[i]<=99)
 {
 count+=1;
 }
}
Console.WriteLine($"Количество элементов массива от 10 до 99: {count}");