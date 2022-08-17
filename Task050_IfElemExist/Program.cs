// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет


Console.Clear();
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

int[,] matrixResult = GetMatrix(3, 4);
PrintMatrix(matrixResult);

Console.Write("Введите номер строки: ");
int userRow = Int32.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int userColumn = Int32.Parse(Console.ReadLine());

int FindElem(int[,] matrix1, int row, int column)
{
    int sum = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (i == row - 1 && j == column - 1) sum = sum + 1;
        }
    }
    if (sum == 0) return -1;
    else return matrix1[row - 1, column - 1];
}

Console.Clear();
int res = FindElem(matrixResult, userRow, userColumn);
PrintMatrix(matrixResult);
Console.WriteLine();
if (res == -1) Console.WriteLine($"{userRow}, {userColumn} -> элемента с таким индексом в массиве нет");
else Console.WriteLine($"{userRow}, {userColumn} -> {res}");