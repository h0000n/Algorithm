using System.Text;

namespace sol
{
    class Program
    {
        static void Main(string[] args)
        {
            _Sol();
        }

        static void _Sol()
        {
            int N = int.Parse(Console.ReadLine());

            HashSet<int> A = new HashSet<int>();
            int[] inputArr = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            foreach(int a in inputArr)
            {
                A.Add(a);
            }

            int M = int.Parse(Console.ReadLine());
            inputArr = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < M; i++)
            {
                if (A.Contains(inputArr[i]))
                {
                    sb.AppendLine("1");
                }
                else
                {
                    sb.AppendLine("0");
                }
            }

            Console.WriteLine(sb);
        }
    }
}