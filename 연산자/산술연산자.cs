using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연산자
{
    internal class 산술연산자
    {
        static void Main(string[] args)
        {
            int a = 3;
            System.Console.WriteLine("a = " + ++a); // a에 ++ 계산 후에 결과값 대입, 결과 = 4
            System.Console.WriteLine("a = " + --a); // a에 -- 계산 후에 결과값 대입, 결과 = 3
            System.Console.WriteLine("a = " + a++); // a를 먼저 대입한 후에 ++ 계산, 결과 = 3
            System.Console.WriteLine("a = " + a--); // a를 먼저 대입한 후에 -- 계산, 결과 = 4
        }
    }
}
