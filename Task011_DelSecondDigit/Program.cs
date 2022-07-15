//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
//456 -> 46
//782 - > 72
//918 -> 98

int num = new Random().Next(100,1000);

// int a = num / 100;
// int b = num % 10;
// int c = a * 10 + b;
// Console.WriteLine($"{num} -> {c}");

// тоже самое через метод

int RemoveSecond (int number)
{    
    int first = num / 100;
    int third = num % 10;
    int res = first * 10 + third;
    return res;
}

int res = RemoveSecond(num);
Console.WriteLine($"{num} -> {res}");