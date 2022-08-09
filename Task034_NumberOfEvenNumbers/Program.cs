// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите размер массива: ");
int userSize = Int32.Parse(Console.ReadLine());
int[] array = FillArrayRnd(userSize, 99, 999);
PrintArray(array);
int count = NumberOfEvenNumbers(array);
Console.WriteLine(" -> " + count);



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

int NumberOfEvenNumbers(int[]arr2)
{
    int sum = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] % 2 == 0) 
        {
            sum += 1;
        }
    }
    return sum;
}
