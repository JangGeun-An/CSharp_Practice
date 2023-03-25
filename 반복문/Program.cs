using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 반복문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for문
            int count = 0;
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<3; j++)
                {
                    count++;
                    Console.WriteLine("i = " + i + " j = " + j);
                }
            }
            Console.WriteLine("count = " + count);

            // while문
            int a = 0;
            while(a<5) // 몇바퀴 반복할지 모를 때 사용하기 좋음
            {
                Console.WriteLine("a = " + a);
                a++;
            }

            // do while문
            int b = 6;
            do // 딱히 쓰이는 용도가 없음
            {
                Console.WriteLine("b = " + b);
                b++;
            }
            while (b < 5);
        }
    }
}
