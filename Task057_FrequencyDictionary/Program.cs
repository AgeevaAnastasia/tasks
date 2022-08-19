// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.Clear();
Console.Write("Введите количество строк матрицы: ");
int mUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int nUser = Int32.Parse(Console.ReadLine());
Console.Write("Введите максимально возможное значение элемента матрицы: ");
int aUser = Int32.Parse(Console.ReadLine());

int[,] matrixResult = GetMatrix(mUser, nUser, aUser);
PrintMatrix(matrixResult);
Console.WriteLine();
for (int l = 1; l <= aUser; l++)
{
    int res = FindNum(matrixResult, l);
    if (res != 0)
    {
        if (res == 2 || res == 3 || res == 4) 
            Console.WriteLine($"{l} встречается {res} раза");
        else if (res > 20 && res % 10 == 2 || res > 20 && res % 10 == 3 || res > 20 && res % 10 == 4) 
            Console.WriteLine($"{l} встречается {res} раза");
        else Console.WriteLine($"{l} встречается {res} раз");
    }
}
Console.WriteLine();




int[,] GetMatrix(int m, int n, int a)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, a + 1);
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

int FindNum(int[,] matrix1, int num)
{
    int sum = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (matrix1[i, j] == num) sum = sum + 1;
        }
    }
    return sum;
}