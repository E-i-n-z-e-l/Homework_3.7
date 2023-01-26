// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateMatrixRndInt(int rows, int columns, int min, int max) 
{
	int[,] matrix = new int[rows, columns];
	Random rnd = new Random();

	for (int i = 0; i < matrix.GetLength(0); i++) 
	{
		for (int j = 0; j < matrix.GetLength(1); j++) 
		{
			matrix[i, j] = rnd.Next(min, max + 1);
		}
	}
	return matrix;
}

void PrintMatrix(int[,] matrix)
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

double [] NewMatrixMidColumns (int [,] array)
{
	double [] columnsArray = new double[array.GetLength(1)];
	double sum = 0;
	for (int j = 0; j < array.GetLength(1); j++) 
	{
		sum = 0;
        for (int i = 0; i < array.GetLength(0); i++) 
		{
			sum = sum + array[i,j];
		}
		double sumColumns = Math.Round(sum / array.GetLength(0), 1);
		
        columnsArray[j] = sumColumns;
	}
	return columnsArray;
}

void PrintArray(double[] arr)
{
    Console.Write("[   ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",   ");
        else Console.Write(arr[i]);
    }
    Console.Write(" ]");
}

int [,] newarray = CreateMatrixRndInt(4, 5, 1, 9);
PrintMatrix(newarray);
double [] arrayMidColumns = NewMatrixMidColumns(newarray);
Console.WriteLine();
PrintArray(arrayMidColumns);


















