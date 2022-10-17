using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            int mountainH = 0;
            int tallestMountain = 0;
            int currentMNum = 0;
            int i = 0;
            for (i = 0; i < 8; i++)
            {
                mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                if (mountainH >= tallestMountain)
                {
                    tallestMountain = mountainH;
                    currentMNum = i;
                }
            }

            Console.WriteLine(currentMNum); // The index of the mountain to fire on.

        }
    }
}