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
        Queue<int> cards = new Queue<int>(); //카드를 담고있는 큐 자료형 선언
        for (int i = 1; i <= N; i++) //N까지 1부터 차례대로 큐에 넣는다.
        {
            cards.Enqueue(i);
        }
        while (cards.Count > 1) //마지막 카드가 남을때까지 반복
        {
            cards.Dequeue(); //가장 앞에 있는 카드를 제거한다.
            cards.Enqueue(cards.Dequeue()); //그리고 앞에 있는 카드를 맨 뒤로 옮긴다.
        }
        sb.Append(cards.Dequeue()); //마지막으로 남아있는 카드의 수를 출력
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
