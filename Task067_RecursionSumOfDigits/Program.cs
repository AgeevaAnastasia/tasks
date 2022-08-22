// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
int numUser = InputNumbers("Введите число: ");

int sum = 0;
Console.Write($"{numUser} -> "); 
Console.Write(GetSumOfDigits(numUser, sum));
Console.WriteLine();


int GetSumOfDigits(int num, int sum)
{
    if (num == 0) return sum;
    sum = sum + num % 10;
    return GetSumOfDigits(num / 10, sum);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
