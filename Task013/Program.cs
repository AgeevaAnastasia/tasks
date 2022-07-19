// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int res;

if (a < 99)
{
    Console.WriteLine("Третьей цифры нет");
}

else 
{   while (a > 1000)
    {
        a = a/10;
    }
    res = a % 10;

    Console.WriteLine($"Третья цифра числа это {res}");
}


// int index = 1, a = 0;
//  Console.WriteLine("введите число не менее трехзначного");
        
//         int num = Convert.ToInt32(Console.ReadLine());
//          if (num>=100) // если число 3х значное то...
//          { while (index <= num)        //определяем  из скольки чисел состоит число  и передаем в переменную а
//         {
//             a = a + 1;
//             index = index * 10;
//         }   
               
//         int[] nums = new int[a];         // обьявлем массив размером в количество символов введеннного числа
//         int indexArray = nums.Length-1;
//         while (indexArray>=0)
//         {
//             nums [indexArray] = num %  10;         
//             num = num/10;
//             indexArray=indexArray-1;
           
//         }
//         Console.WriteLine($"третья цифра введенного числа составляет = {nums[2]} ");}
//          else Console.WriteLine("у Введенного числа нет 3 цифры");
         
