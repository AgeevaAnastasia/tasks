// // Заполните спирально массив 4 на 4.


// Console.Clear();
// Console.Write("Введите количество строк матрицы: ");
// int mUser = Int32.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов матрицы: ");
// int nUser = Int32.Parse(Console.ReadLine());
// Console.Write("Введите число, с которого начнётся спиральное заполнение матрицы: ");
// int numUser = Int32.Parse(Console.ReadLine());
// Console.Write("Введите шаг заполнения матрицы: ");
// int stepUser = Int32.Parse(Console.ReadLine());

// Console.Clear();
// int[,] matrix = FillSpiralMatrix2DInt(mUser, nUser, numUser, stepUser);
// // SpiralMatrix(mUser, nUser, numUser, stepUser);
// PrintMatrix(matrix);

// // int[,] SpiralMatrix(int row, int col, int num, int step)
// // {
// //     int[,] matrixSpiral = new int[row, col];
// //     int rowNew = row - 1;
// //     int colNew = col - 1;
// //     int size;
// //     if (rowNew < colNew) size = rowNew;
// //     else size = colNew;
// //     while (size > 0)
// //     {
// //         int current = 0;
// //         for (int j = current; j < colNew; j++)
// //         {
// //             matrixSpiral[current, j] = num;
// //             num = num + step;
// //         }
// //         for (int i = rowNew; i < colNew; i++)
// //         {
// //             matrixSpiral[i, colNew] = num;
// //             num = num + step;
// //         }
// //         for (int j = colNew; j > current; j--)
// //         {
// //             matrixSpiral[rowNew, j] = num;
// //             num = num + step;
// //         }
// //         for (int i = rowNew; i > current; i--)
// //         {
// //             matrixSpiral[i, current] = num;
// //             num = num + step;
// //         }

// //         rowNew--;
// //         colNew--;
// //         current++;

// //         if (size % 2 == 0) matrixSpiral[rowNew / 2 + 1, colNew / 2 + 1] = num;
// //     }

// //     return matrixSpiral;
// // }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (j == 0) Console.Write("|");
//             if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3}, ");
//             else Console.Write($"{matr[i, j],3}|");
//         }
//         Console.WriteLine();
//     }
// }



// int[,] FillSpiralMatrix2DInt(int row, int col, int number, int summand)
// {
//     int[,] matrix2D = new int[row, col];
//     int nRows = matrix2D.GetLength(0) - 1;
//     int nColumns = matrix2D.GetLength(1) - 1;
//     int length = 0;
//     if (nRows < nColumns) length = nRows;
//     length = nColumns;
//     for (int i = 0; i < length; i++)
//     {
//         for (int j = i; j < nColumns; j++)
//         {
//             matrix2D[i, j] = number;
//             number += summand;
//         }
//         for (int k = i; k < nRows; k++)
//         {
//             matrix2D[k, nColumns] = number;
//             number += summand;
//         }
//         for (int l = nColumns; l > i; l--)
//         {
//             matrix2D[nRows, l] = number;
//             number += summand;
//         }
//         for (int m = nRows; m > i; m--)
//         {
//             matrix2D[m, i] = number;
//             number += summand;
//         }
//         nRows--;
//         nColumns--;
//         if (length % 2 == 0)
//             matrix2D[nRows / 2 + 1, nColumns / 2 + 1] = number;
//     }
//     return matrix2D;
// }



string[] GetUserInputNumbersString(string userInputTextString)
{
    Console.WriteLine(userInputTextString);
    string[] userInputString = Console.ReadLine().Split(",");
    return userInputString;
}

string[] CheckUserInputToInt(string[] userInputString)
{
    for (int i = 0; i < userInputString.Length; i++)
    {
        if (userInputString[i] == string.Empty || userInputString[i] == " "
            || Convert.ToInt32(userInputString[i]) == null
            || userInputString.Length < 2)
        {
            Console.WriteLine("Ошибка ввода данных. Попробуйте еще раз запустить программу и ввести данные корректно.");
            Environment.Exit(0);
        }
    }
    return userInputString;
}

int[] ConvertUserInputNumbersInt(string[] userNumberString)
{
    int[] userNumberInt = new int[userNumberString.Length];
    for (int i = 0; i < userNumberString.Length; i++)
    {
        userNumberInt[i] = Convert.ToInt32(userNumberString[i]);
    }
    return userNumberInt;
}

void FillSpiralMatrix2DInt(int[,] matrix2D, int number, int summand)
{
    int nRows = matrix2D.GetLength(0) - 1;
    int nColumns = matrix2D.GetLength(1) - 1;
    int length = 0;
    if (nRows < nColumns) length = nRows;
    length = nColumns;
    for (int i = 0; i < length; i++)
    {
        for (int j = i; j < nColumns; j++)
        {
            matrix2D[i, j] = number;
            number += summand;
        }
        for (int k = i; k < nRows; k++)
        {
            matrix2D[k, nColumns] = number;
            number += summand;
        }
        for (int l = nColumns; l > i; l--)
        {
            matrix2D[nRows, l] = number;
            number += summand;
        }
        for (int m = nRows; m > i; m--)
        {
            matrix2D[m, i] = number;
            number += summand;
        }
        nRows--;
        nColumns--;
        if (length % 2 == 0)
            matrix2D[nRows / 2 + 1, nColumns / 2 + 1] = number;
    }
}

void PrintMatrix2DInt(int[,] matrixTwoDimensional, string userOutputString)
{
    Console.WriteLine(userOutputString);
    for (int i = 0; i < matrixTwoDimensional.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrixTwoDimensional.GetLength(1); j++)
        {
            if (matrixTwoDimensional[i, j] >= 0)
                Console.Write($" {matrixTwoDimensional[i, j]} ");
            else Console.Write($"{matrixTwoDimensional[i, j]} ");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
}

//Console.Clear();
string[] matrixSizeString = GetUserInputNumbersString("Введите количество строк и столбцов массива через запятую: ");
matrixSizeString = CheckUserInputToInt(matrixSizeString);
int[] matrixSizeInt = ConvertUserInputNumbersInt(matrixSizeString);
string[] minNumberNSummandString = GetUserInputNumbersString("Введите минимальное значение числа первого элемента массива и значение числа, на которое будет увеличиваться первое (числа вводить через запятую): ");
minNumberNSummandString = CheckUserInputToInt(minNumberNSummandString);
int[] minNumberNSummandInt = ConvertUserInputNumbersInt(minNumberNSummandString);
int[,] matrixSpiral = new int[matrixSizeInt[0], matrixSizeInt[1]];
FillSpiralMatrix2DInt(matrixSpiral, minNumberNSummandInt[0], minNumberNSummandInt[1]);
PrintMatrix2DInt(matrixSpiral, string.Empty);