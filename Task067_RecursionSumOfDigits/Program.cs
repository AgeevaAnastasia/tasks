// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
int numUser = InputNumbers("Введите число: ")

Console.Write($"{numUser} -> ");
int res = GetSumOfDigits(numUser);
Console.Write(res);
Console.WriteLine();

int GetSumOfDigits(int num)
{
    int sum = 0;
    if (num == 0) return sum;
    GetSumOfDigits(num / 10);
    sum = sum + numUser % 10;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
