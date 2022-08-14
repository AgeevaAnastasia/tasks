// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.WriteLine("Введите размер массива: ");
int userSize = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение члена массива: ");
int userMin = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение члена массива: ");
int userMax = Int32.Parse(Console.ReadLine());

Console.Clear();
int [] array = FillArray(userSize, userMin, userMax);
PrintArray(array);
int[] arrayCopy = CopyArray(userSize);
PrintArray(arrayCopy);


int[] FillArray (int size, int min, int max)
{
    Random rnd = new Random();
    int [] filledArray = new int [size];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = rnd.Next(min,max + 1);
    }
    return filledArray;
}


void PrintArray(int[] printedArray)
{
    Console.Write("[");
    for (int i = 0; i < printedArray.Length; i++)
    {
        Console.Write(printedArray[i]);
        if (i != printedArray.Length - 1) 
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] CopyArray(int size1)
{
    int[] arr = new int[size1];
    for (int i = 0; i < size1; i++)
    {
        arr[i] = array[i];
    }
    return arr;
}