using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 조건문_IF__ELSE_IF__ELSE_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 5;
            Console.WriteLine("숫자를 입력하세요");
            string val = Console.ReadLine();
            int c = int.Parse(val);
            Console.WriteLine("a 값은 " + a);

            // 비교연산자, 논리연산자, bool 값
            if (a == 3) // 3일 때만 실행
                Console.WriteLine("같습니다");
            else if (a == 4) // 4일 때만 실행
                Console.WriteLine("4 입니다");
            else if(a == 5) // 5일 때만 실행
                Console.WriteLine("5 입니다");
            else // 둘다 아닐 때 실행
            {
                if(a == 2)
                    Console.WriteLine("2 입니다");
                else
                    Console.WriteLine("둘다 아닙니다");
            }

            if(c >= a && c<= b)
                Console.WriteLine("입력한 숫자는 범위안에 있습니다");
            else
                Console.WriteLine("입력한 숫자는 범위를 벗어납니다");
        }
    }
}
