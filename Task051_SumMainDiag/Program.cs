// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


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
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3}, ");
            else Console.Write($"{matr[i, j],3}|");
        }
        Console.WriteLine();
    }
}

int MainDiagSum(int[,] matrix1)
{
    int sum = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + matrix1[i, j];
            }
        }
    }
    return sum;
}

void PrintEvenInd(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (i == j)
            {
                Console.Write(matrix1[i, j]);
            }
        }
        if (i != matrix1.GetLength(0) - 1) Console.Write(" + ");
    }
}

int[,] matrixResult = GetMatrix(userm, usern);
PrintMatrix(matrixResult);
Console.WriteLine();
Console.Write("Сумма элементов главной диагонали: ");
PrintEvenInd(matrixResult);
int res = MainDiagSum(matrixResult);
Console.WriteLine($" = {res}");
Console.WriteLine();



// решение Юрия в одном цикле перебор:
// int GetSumOpt(int[,] arr)
// {
//     int sum = 0;
//     int length = 0;
//     if (arr.GetLength(0) >= arr.GetLength(1)) length = arr.GetLength(1);
//     else length = arr.GetLength(0);
//     for (int j = 0; j < length; j++)
//         sum += arr[j, j];

//     return sum;
// }