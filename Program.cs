﻿Console.Write("Введите число N:");
int number = int.Parse(Console.ReadLine()!);
int index = 1;
while (index <= number){
    Console.WriteLine(Math.Pow(index, 3));
    index ++;
}
