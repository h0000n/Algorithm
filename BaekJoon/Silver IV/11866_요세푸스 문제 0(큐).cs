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
        sb.Append("<");
        int[] input = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
        int N = input[0];
        int K = input[1];
        Queue<int> que = new Queue<int>(); //요세푸스 순열을 위해 큐 선언
        for (int i = 1; i <= N; i++)
        {
            que.Enqueue(i); //N까지 차례대로 큐에 넣어줌
        }
        while (que.Count != 0)
        {
            for (int i = 1; i < K; i++) //K번째까지 앞에있는 숫자를 큐의 뒷부분으로 다시 넣어줌
            {
                que.Enqueue(que.Dequeue());
            }
            sb.Append(que.Dequeue() + ", "); //K번째 숫자를 Dequeue 하여 출력과 동시에 삭제
        }
        sb.Remove(sb.Length - 2, 2);
        sb.Append(">");
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
