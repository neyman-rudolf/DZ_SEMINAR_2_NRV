﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Вариант 1
// string? number = Console.ReadLine();
// Console.WriteLine( number [1]);

// Вариант 2 
// int number = new Random().Next(100,1000);
// Console.WriteLine(number);
// int firstNumber = number/10;
// int secondNumber = firstNumber%10;
// Console.WriteLine($"Вторая цифра в числе: {secondNumber}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// string? number = Console.ReadLine();

// int size = number.Length;

// if (number.Length < 3 ) Console.WriteLine("Нет третьего числа");

// else Console.WriteLine(number [2]);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number > 5 && number < 8) 

{
    Console.WriteLine("ДА");
}


else Console.WriteLine("НЕТ");