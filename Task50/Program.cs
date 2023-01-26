// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//            и возвращает значение этого элемента или же указание, что такого элемента нет.

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

bool SearchArrayElement (int [,] array, int rows, int column)
{

	if (rows >= 0 & rows <= array.GetLength(0) & column >= 0 & column <= array.GetLength(1))
	{
		return false;
	}
	else
	{
		return true;
	}
}

Console.WriteLine("Введите строку ");
int rowsUser = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите столбец ");
int columnsUser = Convert.ToInt32(Console.ReadLine());


int [,] newarray = CreateMatrixRndInt(4, 5, 1, 9);
PrintMatrix(newarray);

bool arrayElementSearch = SearchArrayElement(newarray, rowsUser, columnsUser);

if (arrayElementSearch)
{
	Console.WriteLine($"Числа с индексами {rowsUser} и {columnsUser} нет в массиве");
}
else
{
	Console.WriteLine($"Число с индексами {rowsUser} и {columnsUser} есть в массиве. Это число {newarray[rowsUser, columnsUser]}");
}









