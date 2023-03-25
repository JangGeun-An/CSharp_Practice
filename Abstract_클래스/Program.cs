using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_클래스
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rec r = new Rec(10, 20);
            Cir c = new Cir(10);
            Console.WriteLine($"사각형의 면적은 : {r.Area()}");
            Console.WriteLine($"원의 면적은 : {c.Area()}");
        }
    }
}
