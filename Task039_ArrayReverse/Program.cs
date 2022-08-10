// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


Console.Clear();
Console.Write("Введите размер массива: ");
int userSize = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение минимально возможного элемента массива: ");
int userMin = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение максимально возможного элемента массива: ");
int userMax = Int32.Parse(Console.ReadLine());

int[] array = FillArrayRnd(userSize, userMin, userMax);
PrintArray(array);
Console.WriteLine();
Reverse(array);
PrintArray(array);
Console.WriteLine();


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

void Reverse(int[] arr2)
{
    int size = arr2.Length;
    int index1 = 0;
    int index2 = size - 1;

    while (index1 < index2)
    {
        int obj = arr2[index1];
        arr2[index1] = arr2[index2];
        arr2[index2] = obj;

        index1++;
        index2--;
    }
}


// int[] ArrayReverse(int[] revArr)
// {
//     int temp = 0;
//     for (int i = 0; i < revArr.Length / 2; i++)
//     {
//         temp = revArr[i];
//         revArr[i] = revArr[revArr.Length - 1 - i];
//         revArr[revArr.Length - 1 - i] = temp;
//     }
//     return revArr;
// }
