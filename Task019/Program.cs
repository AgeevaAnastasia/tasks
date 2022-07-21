// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99999 || num < 10000) Console.WriteLine("Вы ввели не пятизначное число");
else
{
    int a = num;
    int[] array = new int[5];

    FillArray(array);

    void FillArray(int[] arr)
    {
        int index = arr.Length - 1;
        while (index >= 0)
        {
            array[index] = a % 10;
            a = a / 10;
            index--;
        }
    }

    if (array[0] == array[4] && array[1] == array[3]) Console.WriteLine($"{num} -> да");
    else Console.WriteLine($"{num} -> нет");
}