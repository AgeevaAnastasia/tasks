// напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// 14 - нет
// 46 - нет
// 161 - да

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = Multiple(num);
if (res == 1) Console.WriteLine($"Число {num} кратно одновременно 7 и 23");
else Console.WriteLine($"Число {num} не кратно одновременно 7 и 23");

int Multiple(int number)
{
    int res = 0;
    if (num % 7 == 0 && num % 23 == 0) res = 1;
    return res;
}