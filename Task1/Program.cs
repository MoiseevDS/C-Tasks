﻿//Задача 2 Находим большее число из 2х введенных
Console.Clear();
Console.Write("Введдите 1-ю цифру: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введдите 2-ю цифру: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
    Console.WriteLine(n);
else if (n < m)
    Console.WriteLine(m);
