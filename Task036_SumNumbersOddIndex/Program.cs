// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Введите размер массива: ");
int userSize = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение минимально возможного элемента массива: ");
int userMin = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение максимально возможного элемента массива: ");
int userMax = Int32.Parse(Console.ReadLine());

int[] array = FillArrayRnd (userSize, userMin, userMax);
PrintArray(array);
int result = SumOfOddPositions(array);
Console.WriteLine(" -> " + result);



int[] FillArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr1.Length - 1) Console.Write(arr1[i] + ", ");
        else Console.Write(arr1[i] + "]");
    }
}

int SumOfOddPositions(int[] arr3)
{
    int sum = 0;
    for (int i = 0; i < arr3.Length; i++)
    {
        if (i  % 2 == 1) sum = sum + arr3[i];
    }
    return sum;
}