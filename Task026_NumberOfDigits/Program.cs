// Напишите программу, которая принимает на вход число и выдает кол-во цифр в числе

Console.WriteLine("Введите число: ");
int num = Int32.Parse(Console.ReadLine());


int NumberOfDigits(int number)
{
    int a = num;
    int i = 0;
    while (a > 0)
    {
        a = a / 10;
        i++;
    }
    return i;
}

int res = NumberOfDigits(num);
Console.WriteLine($"В числе {num} количество цифр равно {res}");


// Другое решение:

// Console.WriteLine("Введите число: ");
// int num = Int32.Parse(Console.ReadLine());
// int index = 1;
// int x = 0;
// while (index <= num)
// {
//     x = x + 1;
//     index = index * 10;
// }
// Console.WriteLine($"В числе {num} количество цифр равно {x}");