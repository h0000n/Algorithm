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

class Result
{
    public static void Sol()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        var points = new Tuple<int, int>[N]; //INT값 2개를 갖기 위해 Tuple 자료형으로 배열 선언
        for (int i = 0; i < N; i++)
        {
            var input = Console.ReadLine()!.Split(" ").ToArray();
            points[i] = Tuple.Create(int.Parse(input[0]), int.Parse(input[1])); //좌표 값을 Tuple의 형태로 배열에 초기화
        }
        Array.Sort(points); //좌표 값이 담긴 배열을 정렬 (Tuple은 두개의 인자값을 모두 비교하여 정렬하는듯)
        foreach (var arr in points)
        {
            sb.AppendLine($"{arr.Item1} {arr.Item2}"); //Tuple의 첫번째와 두번째 인자 값을 차례대로 출력
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
