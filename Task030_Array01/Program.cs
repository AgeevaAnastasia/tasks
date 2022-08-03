// Напишите программу, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке

// мое решение:
// Console.Clear();
// int[] array = new int[8];
// int length = array.Length;
// void FillArray(int[] collection)
// {
//     for (int index = 0; index < length; index++)
//     {
//         collection[index] = new Random().Next(0, 2);
//     }
// }

// FillArray(array);

// void PrintArray(int[] array1)
// {
//     for (int i = 0; i < length; i++)
//     {
//         if (i == 0)
//         {
//             Console.Write($"[{array1[i]}, ");
//         }
//         else if (i < length - 1)
//         {
//             Console.Write($"{array1[i]}, ");
//         }
//         else
//         {
//             Console.WriteLine($"{array1[i]}]");
//         }
        
//     }
    
// }

// PrintArray(array);





// РЕШЕНИЕ ЮРИЯ

int [] array = GetRandomArray(8);
WriteArrayToConsole(array);

int[] GetRandomArray (int arrayLength)
{
    Random rnd = new Random();
    int [] arr = new int [arrayLength];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,2);
    }
    return arr;
}

void WriteArrayToConsole (int[] array)
{
    Console.Clear();
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
