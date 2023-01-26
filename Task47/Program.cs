// Задача 47. Задайте двумерный массив размером m?n, заполненный случайными вещественными числами.

double [,] CreateMatrixRndDouble(int rows, int columns, int min, int max) 
{
	double[,] matrix = new double[rows, columns];
	Random rnd = new Random();

	for (int i = 0; i < matrix.GetLength(0); i++) 
	{
		for (int j = 0; j < matrix.GetLength(1); j++) 
		{
			double num = rnd.NextDouble() * (max - min) + min;
			matrix[i, j] = Math.Round(num, 1);
		}
	}
	return matrix;
}

void PrintDoubleMatrix(double[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("[");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{	
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
			else Console.Write($"{matrix[i, j], 4} ");
		}	
		Console.WriteLine("]");
    }
}

double [,] newMatrixDouble = CreateMatrixRndDouble(4, 5, 1, 9);
PrintDoubleMatrix(newMatrixDouble);




