//Blake Marais
//=========================[Start of file]=========================
using System;
using System.Collections.Generic;

namespace OutcomeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] outcomes = { 123456, 234567, 123347, 456789, 567890, 678901, 789012, 890123, 901234, 112233, 223344, 334455, 789012, 222234, 123347 };
            try
            {
                int[] duplicates = FindDuplicates(outcomes);
                Console.WriteLine($"[{duplicates[0]}, {duplicates[1]}]");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Press Any Key to exit...");
            Console.ReadKey();
        }

        static int[] FindDuplicates(int[] outcomes)
        {
            if (outcomes == null || outcomes.Length == 0)
            {
                throw new ArgumentException("The outcomes array cannot be null or empty.");
            }

            int n = outcomes.Length - 2;
            if (outcomes.Length != n + 2)
            {
                throw new ArgumentException("The length of the outcomes array is not valid.");
            }

            HashSet<int> seen = new HashSet<int>();
            List<int> duplicates = new List<int>();

            foreach (int outcome in outcomes)
            {
                if (seen.Contains(outcome))
                {
                    duplicates.Add(outcome);
                }
                else
                {
                    seen.Add(outcome);
                }
            }

            if (duplicates.Count != 2)
            {
                throw new ArgumentException("The outcomes array does not contain exactly two duplicates.");
            }

            return duplicates.ToArray();
        }
    }
}
//=========================[End of file]=========================