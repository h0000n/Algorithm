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
        int[] inputN = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        int M = int.Parse(Console.ReadLine());
        int[] inputM = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        Dictionary<int, int> dic = new Dictionary<int, int>(); //카드 값과 해당 카드의 갯수의 값을 갖고있는 딕셔너리 선언
        for (int i = 0; i < N; i++)
        {
            dic[inputN[i]] = dic.TryGetValue(inputN[i], out int value) ? value + 1 : 1; //딕셔너리의 TryGetValue를 이용해 Key값이 없으면 새로 추가하고 있으면 해당 value에 +1을 해준다.
        }
        for (int i = 0; i < M; i++)
        {
            int count = dic.TryGetValue(inputM[i], out int value) ? value : 0; //마찬가지로 TryGetValue를 이용해 검색한 결과가 나오면 value를 출력, 없으면 0을 출력한다.
            sb.Append(count + " ");
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
