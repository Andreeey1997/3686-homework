var rand = new Random();

int ReadInt(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

double [,,] GetRandomMatrix(int rows, int columns, int height, int leftRange = 0, int rightRange = 10)
{
double [,,] matrix = new double [rows, columns, height];
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        matrix[i,j,k] = rand.NextDouble() * (rightRange - leftRange) + leftRange;
    }
  }
 }
 return matrix;
}

void PrintMatrix(double[,,] matrix)
{
 for (int i = 0; i<matrix.GetLength(0); i++)
 {
  for (int j = 0; j<matrix.GetLength(1); j++)
  {
    Console.Write($"Элементы ячейки i = {i}; j = {j} ");
    for (int k = 0; k<matrix.GetLength(2); k++)
    {
        Console.Write(matrix[i,j,k]+ " ");
    }
    Console.WriteLine();
  }
 }
}


int rowsCount=ReadInt("Введите число строк:");
int columnsCount=ReadInt("Введите число столбцов:");
int heightCount=ReadInt("Введите глубину:");
double[,,] matrix = GetRandomMatrix(rowsCount, columnsCount, heightCount);
PrintMatrix(matrix);