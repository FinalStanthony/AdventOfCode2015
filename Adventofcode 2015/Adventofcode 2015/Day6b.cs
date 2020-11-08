using System;

namespace Adventofcode_2015
{
    class Day6b
    {
        public int[,] lights = new int[1000, 1000];
        public void main()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\antho\Documents\Repo\AdventOfCode2015\Inputs\day6.txt");
            foreach(string line in lines)
            {
                string[] split = line.Split(' ');
                int x2 = Int32.Parse(split[split.Length - 1].Split(',')[0]);
                int y2 = Int32.Parse(split[split.Length - 1].Split(',')[1]);
                int x = Int32.Parse(split[split.Length - 3].Split(',')[0]);
                int y = Int32.Parse(split[split.Length - 3].Split(',')[1]);
                string command = split[split.Length - 4];
                for(int i = x; i < x2+0.5; i++)
                {
                    for(int j = y; j < y2+0.5; j++)
                    {
                        Command(i, j, command);
                    }
                }

            }
            int count = 0;
            for(int i = 0; i < lights.GetLength(0); i++)
            {
                for(int j = 0; j < lights.GetLength(1); j++)
                {
                    count += lights[i, j];
                }
            }
            System.Console.WriteLine(count);
        }
        public void Command(int x,int y,string command)
        {
            switch (command)
            {
                case "on":
                    lights[x, y]++;
                    break;
                case "off":
                    if (lights[x, y] > 0)
                    {
                        lights[x, y]--;
                    }
                    break;
                case "toggle":
                    lights[x, y] = lights[x,y]+2;
                    break;

            }
        }
    }
}