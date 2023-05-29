// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 = num%100;
// int num2 = num1/10;

// Console.WriteLine(num2);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число до 99999");
// int num=Convert.ToInt32(Console.ReadLine());

// if ((100 <= num ) && (999 >= num))
// {
//     int num1=num%100;
//     int num2=num1%10;
//     Console.WriteLine(num2);
// }
// else if ((1000 <= num ) && (9999 >= num))
// {
//     int num1=num%1000;
//     int num2=num1%100;
//     int num3=num2/10;
//     Console.WriteLine(num2);
// }
// else if ((10000 <= num ) && (99999 >= num))
// {
//     int num1=num%10000;
//     int num2=num1%1000;
//     int num3=num2/100;
//     Console.WriteLine(num3);
// }
// else if (100000 <= num)
// {
//     Console.WriteLine("условия не соблюдены");
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// Console.WriteLine("Введиде число от 1 до 7");
// int num = Convert.ToInt32(Console.ReadLine());

// if ((num == 6) || (num == 7))
// {
//     Console.WriteLine("Выходной");
// }
// else
// {
//     Console.WriteLine("Рабочий день");
// }