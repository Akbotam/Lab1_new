using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); //123
            string []arr = s.Split(); // 1 2 3
            int sum = 0; 
            for (int i = 0; i < arr.Length; i++)
            {
                int q = int.Parse(arr[i]);
                sum = sum + q;
 
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
