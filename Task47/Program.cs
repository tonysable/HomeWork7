double[,] NewArray(int rows, int columns, int min, int max)
{
    var matrix = new double[rows, columns];
    var rnd = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            double rndNum = rnd.NextDouble() * (max - min) + min; // Генератор случайных вещественных чисел
            matrix[i, j] = Math.Round(rndNum, 2); // Округление до 2-ого знака после запятой
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

double[,] pomoyka = NewArray(3, 4, 1, 50);
PrintMatrix(pomoyka);