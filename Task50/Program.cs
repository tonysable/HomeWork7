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

int[,] table = CreateMatrix(3, 4, -10, 15);
PrintMatrix(table);

Console.WriteLine("Введите номер строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int b = Convert.ToInt32(Console.ReadLine());


    if(a <= table.GetLength(0) - 1 && b <= table.GetLength(1) - 1) Console.WriteLine(table[a, b]);
    else Console.WriteLine("Такого элемента в массиве нет");
