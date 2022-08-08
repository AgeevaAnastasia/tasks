// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


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
        if (i < arr1.Length -1) Console.Write(arr1[i] + ", ");
        else Console.Write(arr1[i] + "]");
    }
}

int CountTwoDigitsNumbers(int[]arr2)
{
    int sum = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] >= 10 && arr2[i] < 100) 
        {
            sum += 1;
        }
    }
    return sum;
}


int[] array = FillArrayRnd (123, 0, 1000);
PrintArray(array);
int result = CountTwoDigitsNumbers(array);
Console.WriteLine($" -> {result}");