using System;
using System.Collections.Generic;
using System.Linq;

namespace INVCNT
{
    class Program
    {
        static void Main()
        {
            int testsQuantity = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            for (int i = 0;i < testsQuantity; i++)
            {
                int listQuantity = Convert.ToInt32(Console.ReadLine());
                List<int> list = new List<int>();
                for (int j = 0; j < listQuantity; j++)
                    list.Add(Convert.ToInt32(Console.ReadLine()));
                int result = GetInversionsQuantity(list);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }

        private static int GetInversionsQuantity(List<int> list)
        {
            int InversionQuantity = 0;
            for (int i = 0; i < list.Count(); i++)
                for (int j = i; j < list.Count(); j++)
                {
                    if (i == j)
                        continue;
                    if (list[i] > list[j])
                        InversionQuantity++;
                }
            return InversionQuantity;
        }
    }
}
