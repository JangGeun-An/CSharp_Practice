using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR문_실습2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FineValue();
        }

        private static void FineValue()
        {
            for(int i = 1; i < 51; i++)
            {
                if(i % 3 == 0)
                    Console.WriteLine($"i = {i}");
            }
        }
    }
}
