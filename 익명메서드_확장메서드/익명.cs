using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 익명메서드_확장메서드
{
    internal class 익명
    {
        delegate int? MyDivide(int a, int b);
        public void Run()
        {
            //MyDivide myDivide = delegate (int a, int b)
            //{
            //    return a / b;
            //};

            MyDivide myDivide = (a, b) => a / b;

            Console.WriteLine(myDivide(6,3));
        }
    }
}
