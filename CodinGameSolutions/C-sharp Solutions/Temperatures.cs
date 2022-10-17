using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


//prints the temperature closest to 0 among input data
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');

        if (n <= 0)
        {
            Console.WriteLine(0);
            return;
        }

        int closestToZero = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]);

            if (Math.Abs(t) < Math.Abs(closestToZero))
            {
                closestToZero = t;
            }
            else if (Math.Abs(t) == Math.Abs(closestToZero))
            {
                closestToZero = Math.Max(closestToZero, t);
            }

        }
        Console.WriteLine(closestToZero);
    }
}