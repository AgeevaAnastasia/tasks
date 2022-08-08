// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();
Console.Write("Введите размер массива: ");
int userSize = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение минимально возможного элемента массива: ");
int userMin = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение максимально возможного элемента массива: ");
int userMax = Int32.Parse(Console.ReadLine());

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

int[] MultiplyArray(int[] arr2)
{
    if (arr2.Length % 2 == 1)
    {
        int[] arr3 = new int[arr2.Length / 2 + 1];
        for (int i = 0; i < arr2.Length / 2; i++)
        {
            arr3[i] = arr2[i] * arr2[arr2.Length - 1 - i];
        }
        arr3[arr3.Length - 1] = arr2[arr2.Length / 2];
        return arr3;
    }
    else
    {
        ;
        int[] arr3 = new int[arr2.Length / 2];
        for (int i = 0; i < arr2.Length / 2; i++)
        {
            arr3[i] = arr2[i] * arr2[arr2.Length - 1 - i];
        }
        return arr3;
    }

}

int[] array = FillArrayRnd(userSize, userMin, userMax);
PrintArray(array);
int[] multiplyArray = MultiplyArray(array);
Console.Write(" -> ");
PrintArray(multiplyArray);
Console.WriteLine();