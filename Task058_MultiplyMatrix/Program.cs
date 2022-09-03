// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
Console.Write("Введите количество строк первой матрицы: ");
int mUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int nUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int hUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int kUser = Int32.Parse(Console.ReadLine());

Console.Clear();
if (nUser != hUser) Console.WriteLine("Перемножить данные матрицы невозможно");

else
{
    int[,] matrix1 = GetMatrix(mUser, nUser);
    PrintMatrix(matrix1);
    Console.WriteLine();
    int[,] matrix2 = GetMatrix(hUser, kUser);
    PrintMatrix(matrix2);
    Console.WriteLine();
    int[,] matrixResult = MultiplyMatrix(matrix1, matrix2);
    PrintMatrix(matrixResult);

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

    int[,] MultiplyMatrix(int[,] matr1, int[,] matr2)
    {
        int[,] matrixNew = new int[matr1.GetLength(0), matr2.GetLength(1)];
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int j = 0; j < matr2.GetLength(1); j++)
            {
                for (int k = 0; k < matr2.GetLength(0); k++)
                {
                    matrixNew[i, j] += matr1[i, k] * matr2[k, j];
                }

            }

        }
        return matrixNew;
    }
}
