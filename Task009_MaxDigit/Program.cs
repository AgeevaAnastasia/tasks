// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2
// 85 -> 8

// int num = new Random().Next(10,100);
// int firstDigit = num / 10;
// int secondDigit = num % 10;
// if (firstDigit == secondDigit) Console.WriteLine($"В числе {num} обе цифры одинаковы и равны {firstDigit}");

// else if (firstDigit > secondDigit) Console.WriteLine($"наибольшая цифра числа {num} - это {firstDigit}");

// else Console.WriteLine($"наибольшая цифра числа {num} - это {secondDigit}");
// решение верное, но можно через метод ниже

int num = new Random().Next(10,100);
int MaxDigit (int number)
{    
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0;
    if (firstDigit > secondDigit) return firstDigit;
    else return secondDigit;
}

int maxDigit = MaxDigit(num);
if (maxDigit == 0) Console.WriteLine($"В числе {num} обе цифры одинаковы и равны {maxDigit}");
else Console.WriteLine($"наибольшая цифра числа {num} - это {maxDigit}");