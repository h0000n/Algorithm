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
        int[] input = new int[9];
        int max = 0;
        int num = 0;
        for (int i = 0; i < 9; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 9; i++)
        {
            if (max < input[i])
            {
                max = input[i];
                num = i + 1;
            }
        }
        sb.AppendLine(max.ToString());
        sb.AppendLine(num.ToString());
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