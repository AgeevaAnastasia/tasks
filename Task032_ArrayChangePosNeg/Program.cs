// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Write("Введите размер массива: ");
int userSize = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение минимально возможного элемента массива: ");
int userMin = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение максимально возможного элемента массива: ");
int userMax = Int32.Parse(Console.ReadLine());

int[] FillArrayRnd (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
}

void PrintArray(int[]arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr1.Length -1) Console.Write(arr1[i] + ",");
        else Console.WriteLine(arr1[i] + "]");
    }
}

int[] ChangePosNegElem (int[] arr2)
{
    for (int i = 0; i < arr2.Length; i++)
    {
        arr2[i] = arr2[i] * -1;
    }
    return arr2;
}

int[] array = FillArrayRnd (userSize, userMin, userMax);
PrintArray(array);
int[] arrayChanged = ChangePosNegElem(array);
Console.WriteLine();
PrintArray(arrayChanged);
Console.WriteLine();