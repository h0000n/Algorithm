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
        string input;
        while (true)
        {
            input = Console.ReadLine();
            if (input.Equals("0")) break; //입력된 값이 0이면 탈출
            string reverse = new string(input.Reverse().ToArray()); //input 문자열을 뒤집은 문자열
            if (reverse.Equals(input)) sb.Append("yes\n"); //input과 뒤집은 reverse 문자열을 비교
            else sb.Append("no\n");
        }
        Console.WriteLine(sb);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Result.Sol();
    }
}
