using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


class Result
{
    public static void Sol()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        int[] size = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        int[] TP = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        int a = 1;
        int tCount = 0;
        for (int i = 0; i < size.Length; i++)
        {
            if (size[i] == 0)
            {
                tCount += 0;
            }
            else if (size[i] < TP[0])
            {
                tCount++;
            }
            else
            {
                while(true)
                {
                    if(size[i] <= TP[0] * a)
                    {
                        tCount += a;
                        break;
                    }
                    a++;
                }
            }
        }

        sb.AppendLine(tCount.ToString());
        sb.AppendLine(N / TP[1] + " " + N % TP[1]);
        Console.Write(sb);
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        Result.Sol();
    }
}