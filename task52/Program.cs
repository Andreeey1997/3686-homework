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
double [,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);

Console.WriteLine("Среднее арифметическое по каждому столбцу :");
for (int j = 0 ; j < matrix.GetLength(1); j++)
 {
  int count = 0;
  double sum = 0;
  double AverageNumbers = 0;
  for (int i = 0 ; i < matrix.GetLength(0); i++)
  { 
  count += 1; 
  sum += matrix[i,j];
  }
  AverageNumbers = sum/count;
  Console.Write(AverageNumbers + " ");
 }