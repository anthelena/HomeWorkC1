﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите номер дня недели:  "); 
int num = int.Parse(Console.ReadLine()); 
if (num >= 1 && num <= 5) 
{ 
    Console.Write("Это не выходной."); 
} 
 else if (num >= 6 && num <= 7) 
{ 
    Console.Write("Это выходной."); 
} 
else Console.Write("Такого дня недели нет."); 
            