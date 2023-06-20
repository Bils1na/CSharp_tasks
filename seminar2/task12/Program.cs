﻿// Напишите программу, которая будет принимать 
// на вход два числа и выводить, является ли 
// второе число кратным первому. Если число 2 
// не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

string Equal(int numberA, int numberB)
{
    if(numberA % numberB == 0)
    {
        return "Yes";
    }
    else
    {
        return $"No, {numberA} % {numberB} = {numberA % numberB}";
    }
}

int numberA = new Random().Next(1, 100);
int numberB = new Random().Next(1, 10);
System.Console.WriteLine($"{numberA}, {numberB} -> {Equal(numberA, numberB)}");
