// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

Console.Clear();
Console.Write("Введите количество строк матрицы: ");
int mUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int nUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите минимально возможное значение элемента матрицы: ");
int minUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите максимально возможное значение элемента матрицы: ");
int maxUser = Int32.Parse(Console.ReadLine());

Console.Clear();
int[,] matrixResult = GetMatrix(mUser, nUser, minUser, maxUser);
PrintMatrix(matrixResult);
Console.WriteLine();
int[] indexMin = FindMinElem(matrixResult);
// int[,] matrixNew = DelRow(indexMin, matrixResult, mUser, nUser);
// matrixNew = DelCol(indexMin, matrixNew, mUser, nUser);
int[,] matrixNew = RemoveCross(matrixResult, indexMin);
PrintMatrix(matrixNew);
Console.WriteLine();


int[,] GetMatrix(int m, int n, int a, int b)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(a, b + 1);
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

int[] FindMinElem(int[,] matrix1)
{
    int minElem = matrix1[0, 0];
    int[] min = new int[2];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (matrix1[i, j] < minElem)
            {
                minElem = matrix1[i, j];
                min[0] = i;
                min[1] = j;
            }
        }
    }
    return min;
}

int[,] DelRow(int[] min, int[,] matr, int m, int n)
{
    int[,] matrNew = new int[m - 1, n];
    int a = min[0];
    for (int i = 0; i < matr.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i < a) matrNew[i, j] = matr[i, j];
            else if (i >= a) matrNew[i, j] = matr[i + 1, j];
        }
    }
    return matrNew;
}

int[,] DelCol(int[] min, int[,] matr, int m, int n)
{
    int[,] matrNew = new int[m - 1, n - 1];
    int b = min[1];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            if (j < b) matrNew[i, j] = matr[i, j];
            else if (j >= b) matrNew[i, j] = matr[i, j + 1];
        }
    }
    return matrNew;
}


// решение Юрия (проще) но у меня не работает
int[,] RemoveCross(int[,] matr, int[] min)
{
    int[,] matrNew = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < matrNew.GetLength(0); i++)
    {
        if (m == min[0]) m++;
        for (int j = 0; j < matrNew.GetLength(1); j++)
        {
            if (n == min[1]) n++;
            matrNew[i, j] = matr[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return matrNew;
}
