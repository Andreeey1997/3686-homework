
var rand = new Random();


void FillMas(double [,] matrix, int TotalCells, int row = 0, int column = 0, int dir = 0, int iter = 0, int limit = 4, int counter = 0)
{

    if (dir == 0)
    {
        Console.WriteLine(dir);
        int temp = 0;
        for (int j = 0; j < limit; j++)
        {
            matrix[row, column + j] = rand.Next(0,10);
            temp = j;
            PrintMatrix(matrix);
            counter += 1;
        }
        column = column + temp;
        row += 1;
        Console.WriteLine($"Строка {row}, столбец {column}");
        dir = 1;
    }
    else if (dir == 1)
    {
        Console.WriteLine(dir);
        int temp = 0;
        for (int i = 0; i < limit; i++)
        {
            matrix[row + i, column] = rand.Next(0,10);
            temp = i;
            PrintMatrix(matrix);
            counter += 1;
        }
        row = row + temp;
        column -= 1;
        Console.WriteLine($"Строка {row}, столбец {column}");
        dir = 2;
    }
    else if (dir == 2)
    {
        Console.WriteLine(dir);
        int temp = 0;
        for (int j = 0; j < limit; j++)
        {
            matrix[row, column - j] = rand.Next(0,10);
            temp = j;
            PrintMatrix(matrix);
            counter += 1;
        }

        column = column - temp;
        row -= 1;
        Console.WriteLine($"Строка {row}, столбец {column}");
        dir = 3;
    }
    else if (dir == 3)
    {
        Console.WriteLine(dir);
        int temp = 0;
        for (int i = 0; i < limit; i++)
        {
            matrix[row - i, column] = rand.Next(0,10);
            temp = i;
            PrintMatrix(matrix);
            counter += 1;
        }

        row = row - temp;
        column += 1;
        Console.WriteLine($"Строка {row}, столбец {column}");
        dir = 0;
    }

    iter += 1;
    
    if (iter%2 == 1)
    {
        limit -= 1;
    }
    if(counter < TotalCells)
    {
        FillMas(matrix, TotalCells, row, column, dir, iter, limit, counter);
    }
}

int GetNumberOfCells(double [,] matrix)
{
    int TotalCells = matrix.GetLength(0)*matrix.GetLength(1);
    return TotalCells;
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


double[,] matrix = new double [4,4];
FillMas(matrix, GetNumberOfCells(matrix));

