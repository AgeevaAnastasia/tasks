// Задайте массив из 12 элементов, заполненный случайными числами от -9 до 9. 
// Найдите сумму отрицательных и положительный чисел масива

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

int[] GetSumPosNegElem (int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPos += array[i];
        }
        else
        {
            sumNeg += array[i];
        }
    }
    return new int[] {sumNeg, sumPos};
}

void PrintArray(int[]array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array1.Length -1) Console.Write(array1[i] + ",");
        else Console.Write(array1[i] + "]");
    }
}

int[] array = FillArrayRnd (12, -9, 9);
PrintArray(array);
int[] sumPosNegElem = GetSumPosNegElem (array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел массива {sumPosNegElem[1]}");
Console.WriteLine($"Сумма отрицательных чисел массива {sumPosNegElem[0]}");