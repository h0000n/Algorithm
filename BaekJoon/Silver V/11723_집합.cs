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
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata;
using System.ComponentModel.Design;
using System.ComponentModel.DataAnnotations;

class Result
{
    public static void Sol()
    {
        StringBuilder sb = new StringBuilder();
        string[] input;
        int[] S = new int[20];
        S = Enumerable.Repeat<int>(0, 20).ToArray<int>(); //배열 0으로 초기화
        int M = int.Parse(Console.ReadLine());
        for (int i = 0; i < M; i++)
        {
            input = Console.ReadLine()!.Split(" ").ToArray();
            switch (input[0]) //입력받은 구문을 비교하여 명령 수행
            {
                case "add":
                    if (S[int.Parse(input[1]) - 1] == 0)
                        S[int.Parse(input[1]) - 1] = int.Parse(input[1]);
                    break;
                case "remove":
                    if (S[int.Parse(input[1]) - 1] == int.Parse(input[1]))
                        S[int.Parse(input[1]) - 1] = 0;
                    break;
                case "check":
                    if (S[int.Parse(input[1]) - 1] == int.Parse(input[1]))
                        sb.AppendLine("1");
                    else
                        sb.AppendLine("0");
                    break;
                case "toggle":
                    if (S[int.Parse(input[1]) - 1] == int.Parse(input[1]))
                        S[int.Parse(input[1]) - 1] = 0;
                    else
                        S[int.Parse(input[1]) - 1] = int.Parse(input[1]);
                    break;
                case "all":
                    for (int j = 0; j < 20; j++)
                    {
                        S[j] = j + 1;
                    }
                    break;
                case "empty":
                    S = Enumerable.Repeat<int>(0, 20).ToArray<int>();
                    break;
            }
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
