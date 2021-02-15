using System;

namespace OzowAssessment
{
    public static class Program
    {

        static void Main(string[] args)
        {
            ProcessString("Contrary to popular belief, the pink unicorn flies east");
        }

        public static void ProcessString(string input)
        {
            StringProcessor process = new StringProcessor();
            Console.WriteLine($"Output: {process.StringExcludePunctuation(input)}");
        }
    }
}
