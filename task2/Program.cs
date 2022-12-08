// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine ("Введите чиcло");
string num = Console.ReadLine ();
if (num.Length <= 2)
    Console.WriteLine ("Третьей цифры нет");
else
    Console.WriteLine ("Третья цифра: " +num[2]);