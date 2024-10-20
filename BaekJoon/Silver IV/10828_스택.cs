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
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            string[] input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                switch(input[0])
                {
                    case "push":
                        stack.Push(int.Parse(input[1]));
                        break;
                    case "pop":
                        if (stack.Count == 0)
                            sb.AppendLine("-1");
                        else
                            sb.AppendLine(stack.Pop().ToString());
                        break;
                    case "size":
                        sb.AppendLine(stack.Count.ToString());
                        break;
                    case "empty":
                        if (stack.Count == 0)
                            sb.AppendLine("1");
                        else
                            sb.AppendLine("0");
                        break;
                    case "top":
                        if (stack.Count == 0)
                            sb.AppendLine("-1");
                        else
                            sb.AppendLine(stack.Peek().ToString());
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sb);
        }
    }
}