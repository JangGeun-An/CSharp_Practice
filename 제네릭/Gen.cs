using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 제네릭
{
    internal class Gen
    {
        public void Run()
        {
            PrintAny1 p1 = new PrintAny1();
            p1.Print<int>(1);
            p1.Print(3);
            PrintAny<Student, string> p2 = new PrintAny<Student, string>();
            p2.Print(1, "aaa");
        }
    }

    class PrintAny<T, U> where T : IComparable where U : IComparable
    {
        public void Print(T val1, U val2)
        {
            Console.WriteLine($"val1 = {val1}, val2 = {val2}");
        }
    }

    class PrintAny1
    {
        public void Print<T>(T val)
        {
            Console.WriteLine($"val = {val}");
        }
    }
}
