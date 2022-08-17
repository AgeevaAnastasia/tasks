// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Введите количество строк матрицы: ");
int mUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int nUser = Int32.Parse(Console.ReadLine());

Console.Clear();

int[,] matrixResult = GetMatrix(mUser, nUser);
PrintMatrix(matrixResult);
PrintAverage(matrixResult, nUser);


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
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3}, ");
            else Console.Write($"{matr[i, j],3}|");
        }
        Console.WriteLine();
    }
}

double ColumnAverage(int[,] matrix1, int col, int row)
{
    double sum = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        sum = sum + matrix1[i, col];
    }
    double res = sum / row;
    return res;
}

void PrintAverage(int[,] matrix1, int n)
{
    double result = 0;
    for (int a = 0; a <= n - 1; a++)
    {
        result = Math.Round((ColumnAverage(matrix1, a, mUser)), 1);
        Console.WriteLine($"Среднее арифметическое столбца №{a + 1} = {result}");
    }
}
