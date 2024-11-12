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
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine()!.Split(" ");
            for (int j = 0; j < input[1].Length; j++)
            {
                for (int q = 0; q < int.Parse(input[0]); q++)
                {
                    sb.Append(input[1][j]);
                }
            }
            sb.AppendLine();
        }
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