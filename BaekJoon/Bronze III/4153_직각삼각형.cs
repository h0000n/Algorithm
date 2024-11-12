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
        while(true)
        {
            string input = Console.ReadLine();
            if (input[0] == '0')
                break;
            int[] arr = input!.Split(" ").Select(int.Parse).ToArray();
            if ((arr[0] * arr[0]) + (arr[1] * arr[1]) == (arr[2] * arr[2]))
            {
                sb.AppendLine("right");
            }
            else if((arr[0] * arr[0]) + (arr[2] * arr[2]) == (arr[1] * arr[1]))
            {
                sb.AppendLine("right");
            }
            else if ((arr[1] * arr[1]) + (arr[2] * arr[2]) == (arr[0] * arr[0]))
            {
                sb.AppendLine("right");
            }
            else
            {
                sb.AppendLine("wrong");
            }
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