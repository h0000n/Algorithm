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
    class User //나이, 이름, 순서를 담기위한 클래스 생성
    {
        public int Age;
        public string? Name;
        public int Order;
        public User(int age, string name, int order)
        {
            this.Age = age;
            this.Name = name;
            this.Order = order;
        }
    }
    public static void Sol()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        string[] input = null;
        var users = new User[N]; //정렬을 위해 User 클래스의 배열 선언
        for (int i = 0; i < N; i++)
        {
            input = Console.ReadLine()!.Split(" ").ToArray();
            users[i] = new User(int.Parse(input[0]), input[1], i);
        }
        var sortedUser = users //OrderBy로 먼저 나이비교 그 다음 나이가 같다면 ThenBy로 순서 비교한 값을 다시 배열로 저장
                        .OrderBy(m => m.Age)
                        .ThenBy(m => m.Order)
                        .ToArray();
        foreach (var user in sortedUser) //나이와 순서로 정렬된 배열을 나이와 이름으로 나열하여 출력
        {
            sb.AppendLine($"{user.Age} {user.Name}");
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
