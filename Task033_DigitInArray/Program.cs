// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите размер массива: ");
int userSize = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение минимально возможного элемента массива: ");
int userMin = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение максимально возможного элемента массива: ");
int userMax = Int32.Parse(Console.ReadLine());
Console.WriteLine("Наличие какого числа вы хотите проверить в сгененированном массиве? ");
int userDigit = Int32.Parse(Console.ReadLine());

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
        else Console.Write(arr1[i] + "]");
    }
}

void DigitSearch(int[] arr2, int digit)
{
    int sum = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] == digit) sum += 1;
    }
    if (sum == 0) Console.WriteLine(" такого числа нет");
    else Console.WriteLine(" такое число есть");
}

Console.WriteLine("=====================================================================");
Console.Write($"Ваше число {userDigit}; в сгенерированном массиве ");
int[] array = FillArrayRnd (userSize, userMin, userMax);
PrintArray(array);
DigitSearch(array, userDigit);


Console.WriteLine();
Console.WriteLine();
