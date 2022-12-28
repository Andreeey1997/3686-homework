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


//Вводим функцию для формирования третьей матрицы на основе произведения первых двух;

double [,] MultMatrix(double[,] matrix1, double[,] matrix2)
{
    double [,] ProductMatrix = new double [matrix1.GetLength(0), matrix1.GetLength(1)];
	if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
	{
	Console.WriteLine("Ошибка: невозможно вычислить произведение матриц");
	}
	else
	{
		for (int i = 0; i < matrix1.GetLength(0); i++)
		{
			for (int j = 0; j < matrix1.GetLength(1); j++)
			{
				ProductMatrix[i,j] = matrix1[i,j]*matrix2[i,j];
			}
		}
	}
    return ProductMatrix;
}

//Вывод

int rowsCount=ReadInt("Введите число строк для первой матрицы:");
int columnsCount=ReadInt("Введите число столбцов для первой матрицы:");
double [,] matrix1 = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix1);

int NewRowsCount=ReadInt("Введите число строк для второй матрицы:");
int NewColumnsCount=ReadInt("Введите число столбцов для второй матрицы:");
double [,] matrix2 = GetRandomMatrix(NewRowsCount, NewColumnsCount);
PrintMatrix(matrix2);

double [,] MultiplyMatrix = MultMatrix(matrix1, matrix2);
Console.WriteLine("Произведение матриц:");
PrintMatrix(MultiplyMatrix);

