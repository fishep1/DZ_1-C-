﻿Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) 
    Console.WriteLine(a + "больше" + b);
if (b > a)
    Console.WriteLine(b + "больше" + a);