class Program
{
    static void Main(string[] args)
    {
        _Sol();
    }

    static void _Sol()
    {
        string input;
        int Length = int.Parse(Console.ReadLine());
        string[] inputVar = new string[Length];
        for (int i = 0; i < Length; i++)
        {
            input = Console.ReadLine();
            inputVar[i] = input;
        }
        inputVar = inputVar.Distinct().ToArray();
        Array.Sort(inputVar);
        inputVar = inputVar.OrderBy(x => x.Length).ToArray();

        foreach (string result in inputVar)
        {
            Console.WriteLine(result);
        }
    }
}
