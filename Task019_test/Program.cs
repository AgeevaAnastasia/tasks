// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите целое число не более 9 цифр: ");
string number = Console.ReadLine();
int length = number.Length;
if (length > 9)
{
    Console.WriteLine("Вы ввели слишком большое число");
}

else
{
    int num = Convert.ToInt32(number);

    int a = num;
    int i = 1;
    int n = 0;
    while (i <= num)
    {
        n = n + 1;
        i = i * 10;
    }

    int[] array = new int[n];

    FillArray(array);

    void FillArray(int[] arr)
    {
        int length = arr.Length;
        int arrayIndex = arr.Length - 1;
        while (arrayIndex >= 0)
        {
            array[arrayIndex] = num % 10;
            num = num / 10;
            arrayIndex = arrayIndex - 1;
        }
    }



    int[] array1 = new int[n];
    int index = 0;
    int index1 = n - 1;
    int x = 0;
    while (index <= n / 2)
    {
        if (array[index] == array[index1]) x = 1;
        else x = 0;
        if (x == 1)
        {
            index++;
            index1--;
        }
        else break;
    }

    if (x == 1) Console.Write($"Число {a} является палиндромом");
    else Console.Write($"Число {a} не является палиндромом");
}
