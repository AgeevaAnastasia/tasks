// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите несколько чисел с клавиатуры: ");
string line = Console.ReadLine();
string[] words = line.Split(' ' , '.' , ',' , ':' , ';');

int[] array = new int[words.Length];
for (int i = 0; i < words.Length; i++)
    {
        array[i] = Convert.ToInt32(words[i]);
    }

Console.Clear();
Console.WriteLine();
Console.Write("Среди чисел ");
PrintArray(array);
Console.WriteLine($" положительных чисел {CountPosNums(array)}");



int CountPosNums(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += 1;
    }
    return sum;
}          

void PrintArray(int[] printedArray)
{
    for (int i = 0; i < printedArray.Length; i++)
    {
        Console.Write(printedArray[i]);
        if (i != printedArray.Length - 1) 
        {
            Console.Write(", ");
        }
    }
    
}
