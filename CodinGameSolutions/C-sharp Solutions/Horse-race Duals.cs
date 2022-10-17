using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

// identifies the two closest strengths and shows their difference with an integer (≥ 0).
class Solution
{
    static void Main(string[] args)
    {
        //Reads the inputs
        int N = int.Parse(Console.ReadLine());

        int[] P = new int[N];

        for (int i = 0; i < N; i++)
        {
            P[i] = int.Parse(Console.ReadLine());
        }

        //Sorts horse strengths
        Array.Sort(P);

        int D = int.MaxValue;

        for (int i = 1; i < N; i++)
        {
            D = Math.Min(D, P[i] - P[i - 1]);
        }

        Console.WriteLine(D);
    }
}