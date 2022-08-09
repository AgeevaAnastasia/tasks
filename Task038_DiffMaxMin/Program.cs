// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
Console.Write("Введите размер массива: ");
int userSize = Int32.Parse(Console.ReadLine());


double[] array = FillArrayRnd (userSize);
PrintArray(array);
double max = FindMax(array);
double min = FindMin(array);
double result = Math.Round(max - min, 1);
Console.WriteLine(" -> " + result);



double[] FillArrayRnd(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 100, 1);
    }
    return arr;
}

void PrintArray(double[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr1.Length - 1) Console.Write(arr1[i] + ", ");
        else Console.Write(arr1[i] + "]");
    }
}

double FindMax(double[] arr3)
{
    double maxNum = arr3[0];
    for (int i = 1; i < arr3.Length; i++)
    {
        if (arr3[i] > maxNum) maxNum = arr3[i];
    }
    return maxNum;
}

double FindMin(double[] arr4)
{
    double minNum = arr4[0];
    for (int i = 1; i < arr4.Length; i++)
    {
        if (arr4[i] < minNum) minNum = arr4[i];
    }
    return minNum;
}
