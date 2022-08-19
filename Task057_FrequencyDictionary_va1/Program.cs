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
int[] array = GetArray(matrixResult);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);
Console.WriteLine();
WriteDigitToConsole(array);




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

int[] GetArray(int[,] matrix1)
{
    int size = matrix1.GetLength(0) * matrix1.GetLength(1);
    int[] arr = new int[size];
    int n = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            arr[n] = matrix1[i, j];
            n++;
        }
    }

    return arr;
}


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i != arr.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

void SortArray(int[] arr)
{
    for (int m = 0; m < arr.Length - 1; m++)
    {
        for (int n = 0; n < arr.Length - 1 - m; n++)
        {
            if (arr[n] > arr[n + 1])
            {
                int temp = arr[n];
                arr[n] = arr[n + 1];
                arr[n + 1] = temp;
            }
        }
    }
}

void WriteDigitToConsole(int[] arr)
{
    int digit = arr[0];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == digit) count++;
        else
        {
            Console.WriteLine($"{digit} -> {count}");
            digit = arr[i];
            count = 1;
        }
        if (i == arr.Length - 1) Console.WriteLine($"{digit} -> {count}");
    }
}
