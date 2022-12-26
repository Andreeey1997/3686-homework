var rand = new Random();

int ReadInt(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

double [,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
double [,] matrix = new double [rows, columns];
 for (int i = 0; i<matrix.GetLength(0); i++)
 {
  for (int j = 0; j<matrix.GetLength(1); j++)
  {
  matrix[i,j]=rand.Next(leftRange, rightRange+1);
  }
 }
 return matrix;
}

void PrintMatrix(double[,] matrix)
{
 for (int i = 0; i<matrix.GetLength(0); i++)
 {
  for (int j = 0; j<matrix.GetLength(1); j++)
  {
  Console.Write(matrix[i,j]+ " ");
  }
  Console.WriteLine();
 }
}



int rowsCount=ReadInt("Введите число строк:");
int columnsCount=ReadInt("Введите число столбцов:");
double[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);


Console.WriteLine("Введите номер строки (нумерация начинается с нуля):");
int newi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца (нумерация начинается с нуля):");
int newJ = Convert.ToInt32(Console.ReadLine());

if (newi < matrix.GetLength(0) && newJ < matrix.GetLength(1))
 {
 Console.WriteLine($"Значение элемента массива под этими индексами: {matrix[newi,newJ]}");
 }
 else
 {
 Console.WriteLine("Такого числа в массиве нет");
 }