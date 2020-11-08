using System;
using System.Collections.Generic;

namespace Adventofcode_2015
{
    class Day3
    {
        static void main()
        {
            bool robot = false;
            int x = 100;
            int y = 100;
            int x2 = 100;
            int y2 = 100;
            string lines = System.IO.File.ReadAllText(@"C:\Users\antho\Documents\Repo\AdventOfCode2015\Inputs\day3.txt");
            int[,]book = new int[200,200];
            book[x, y]=2;
            for (int i = 0; i < lines.Length; i++)
            {
                if(lines[i]== 'v')
                {
                    if (robot)
                    {
                        y--;
                    }
                    else
                    {
                        y2--;
                    }
                    
                }
                if (lines[i] == '>')
                {
                    if (robot)
                    {
                        x++;
                    }
                    else
                    {
                        x2++;
                    }
                }
                if (lines[i] == '<')
                {
                    if (robot)
                    {
                        x--;
                    }
                    else
                    {
                        x2--;
                    }
                }
                if (lines[i] == '^')
                {
                    if (robot)
                    {
                        y++;
                    }
                    else
                    {
                        y2++;
                    }
                }
                if (robot)
                {
                    book[x, y]++;
                }
                else
                {
                    book[x2, y2]++;
                }
                robot = !robot;
               

            }
            int res = 0;
            for(int i = 0; i < 200; i++)
            {
                for(int j = 0; j < 200; j++)
                {
                    if (book[i, j] > 0)
                    {
                        res++;
                    }
                }
            }
            System.Console.WriteLine(res);
            
        }
    }
}
