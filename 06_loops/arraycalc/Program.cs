﻿namespace arraycalc;

class Program
{
    static void Main(string[] args)
    {
        double[] saldo = new double[] { 240.99, 1142.23, 789.89, 658.72 };

        for (int i = 0 ; i < saldo.Length; i++)
        {
            double verhogingSaldo = saldo[i] + 100;
            Console.WriteLine($"{i} saldo na verhoging {verhogingSaldo}");
        }
    }
}
