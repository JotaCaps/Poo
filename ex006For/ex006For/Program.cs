﻿// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        Console.WriteLine(i);
    }
}
