var rand = new Random();

int ReadInt(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

double [,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
double [,] matrix = new double [rows, columns];
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
  matrix[i,j] = rand.NextDouble() * (rightRange -leftRange) + leftRange;
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

void BoubleSort(double [,] matrix)
{
for (int i = 0; i<matrix.GetLength(0); i++)
	{
		for (int j = 0; j<matrix.GetLength(1); j++)
		{
			for (int k = 0; k<matrix.GetLength(1)-1-j; k++)
			{
				if (matrix[i,k+1]>matrix[i,k])
				{
				double temp = matrix[i,k+1];
				matrix[i,k+1]=matrix[i,k];
				matrix[i,k]=temp;
				}
			}
		}
	}
}

int rowsCount=ReadInt("Введите число строк:");
int columnsCount=ReadInt("Введите число столбцов:");
double[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);

BoubleSort(matrix);
Console.WriteLine("Отсортированная матрица: ");
PrintMatrix(matrix);


