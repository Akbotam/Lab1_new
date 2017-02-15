using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                String s = Console.ReadLine();
                a[i] = int.Parse(s);
            }
            int count=0; // counts the number of divided numbers
            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = 1; j <= a[i]; j++)
                {
                    if (a[i] % j == 0)
                        count++;
                }
                if (count == 2)
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.ReadKey();
        }
    }
}