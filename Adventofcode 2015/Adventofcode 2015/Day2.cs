using System;

namespace Adventofcode_2015
{
    class Day2
    {
        static void main(string[] args)
        {
            int res = 0;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\antho\Downloads\input.txt");
            for(int i = 0; i < lines.Length; i++)
            {
                string[] num = lines[i].Split('x');
                int high = 0;
                for (int j = 0; j < 3; j++) {
                    if (Int32.Parse(num[j]) > high) {
                        high = Int32.Parse(num[j]);
                            }
                }
                int[] nums = new int[3];
                for(int j = 0; j < 3; j++)
                {
                    if (Int32.Parse(num[j]) == high)
                    {
                        if (nums[2] == 0)
                        {
                            nums[2] = Int32.Parse(num[j]);
                        }
                        else
                        {
                            if (nums[0] == 0)
                            {
                                nums[0] = Int32.Parse(num[j]);
                            }
                            else
                            {
                                nums[1] = Int32.Parse(num[j]);
                            }
                        }
                    }
                    else
                    {
                        if (nums[0] == 0)
                        {
                            nums[0] = Int32.Parse(num[j]);
                        }
                        else
                        {
                            nums[1] = Int32.Parse(num[j]);
                        }
                    }
                   
                }
                res += 2*(nums[0] + nums[1]);
                res += nums[0] * nums[1] * nums[2];
            }
            System.Console.WriteLine(res);
        }
    }
}
