int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");
    }
}
int rows = 3;
int columns = 4;
int[,] table = CreateMatrix(rows, columns, 1, 15);
PrintMatrix(table);

double[] average = new double[columns];
for(int i = 0; i < columns; i++)
{
    for(int j = 0; j <= table.GetLength(0) - 1; j++)
    {
        average[i] += (double)table[j, i] / table.GetLength(0);
    }
    Console.WriteLine($"Среднее арифметическое {i}-ого столбца - {Math.Round(average[i], 2)}");
}
