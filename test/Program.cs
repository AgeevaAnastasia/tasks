int[,] matrix = new int[,] {{3,5,2,8,1,5},{4,2,2,1,9,4},{1,6,7,2,9,3},{4,6,3,9,2,5},{5,1,6,2,7,1}};
PrintMatrix(matrix);
Console.WriteLine();

RangeMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();






void RangeMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int m = i; m < matr.GetLength(0); m++)
            {
                for (int n = 0; n < matr.GetLength(1) - 1; n++)
                {
                    if (matr[m, n] < matr[m, n + 1])
                    {
                        int temp = matr[m, n];
                        matr[m, n] = matr[m, n + 1];
                        matr[m, n + 1] = temp;
                    }
                }

            }

        }

    }
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