﻿Console.WriteLine("Ввелите число m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввелите число n:");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(Akerman(m,n));

int Akerman(int m, int n){
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return Akerman(m-1,1);
    if(m > 0 && n > 0) return Akerman(m - 1, Akerman(m, n - 1));
    else return m = 0;
}
