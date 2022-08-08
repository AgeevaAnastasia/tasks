// Напишите программу, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите размер массива: ");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение члена массива: ");
int b = Int32.Parse(Console.ReadLine());
int [] array = FillArray(a);
PrintArray(array);

//далее методы, вызов которых выше ^

int[] FillArray (int length)
{
    Random rnd = new Random();
    int [] array1 = new int [length];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = rnd.Next(0,b+1);
    }
    return array1;
}


void PrintArray(int[] array)
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
