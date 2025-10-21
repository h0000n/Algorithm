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
        string[] input = Console.ReadLine()!.Split(" ").ToArray();
        string sInput;
        int count = 0;
        Dictionary<string, int> person = new Dictionary<string, int>(); //듣도 보도 못한 사람들을 체크하기 위한 딕셔너리 선언
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        for (int i = 0; i < N; i++) //듣도 못한 사람들을 입력받은 사람이 있으면 넘어가고 없으면 딕셔너리에 추가
        {
            sInput = Console.ReadLine();
            if (!person.ContainsKey(sInput))
                person.Add(sInput, 1);
        }
        for (int i = 0; i < M; i++) //보도 못한 사람들을 입력받은 사람이 있으면 해당 사람의 밸류값을 +1 해주고 없으면 딕셔너리에 추가
        {
            sInput = Console.ReadLine();
            if (person.ContainsKey(sInput))
                person[sInput]++;
            else
                person.Add(sInput, 1);
        }
        person = person.OrderBy(item => item.Key).ToDictionary(x => x.Key, x => x.Value); //명단을 사전순으로 출력하기 위해 딕셔너리를 키값을 기준으로 정렬
        foreach (KeyValuePair<string, int> value in person) //foreach문으로 딕셔너리를 순차적으로 체크함
        {
            if (value.Value == 2) //듣도 못한 사람, 보도 못한 사람에 모두 포함되는 듣보잡을 체크함
            {
                count++; //듣보잡의 수
                sb.AppendLine(value.Key); //듣보잡 명단 출력
            }
        }
        sb.Insert(0, count + "\n"); //stringbuilder 맨앞쪽에 듣보잡의 수를 Insert
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
