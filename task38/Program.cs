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

int MAX(int [] array)
{
int result = array[0];
for (int i=0; i<array.Length; i++)
{
 if (array[i]>result) result = array[i];
 
}
return result;
}

int MIN (int [] array)
{
int result = array[0];
for (int i=0; i<array.Length; i++)
{
 if (array[i]<result) result = array[i];
}
return result;
}

int minimum = MIN(array);
int maximum = MAX(array);
int NewResult = maximum - minimum;
Console.WriteLine(NewResult);