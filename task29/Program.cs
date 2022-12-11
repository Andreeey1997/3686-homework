int[] array = new int[8];

int ReadInt(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < 8; i++)
{
array[i]=ReadInt("Введите элемент массива");
}

Console.WriteLine(string.Join(", ", array));