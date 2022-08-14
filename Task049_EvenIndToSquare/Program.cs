// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


Console.Write("Введите количество строк матрицы: ");
int userm = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int usern = Int32.Parse(Console.ReadLine());

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 3}, ");
            else Console.Write($"{matr[i, j], 3}|");
        }
        Console.WriteLine();
    }
}

int[,] MatrixChange(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0 )
            {
                matrix1[i, j] = matrix1[i, j] * matrix1[i, j];
            }
        }
    }
    return matrix1;
}

int[,] matrixResult = GetMatrix(userm, usern);
PrintMatrix(matrixResult);
Console.WriteLine();
Console.WriteLine();
int[,] matrixChanged = MatrixChange(matrixResult);
PrintMatrix(matrixChanged);