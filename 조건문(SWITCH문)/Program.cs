using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 조건문_SWITCH문_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요");
            string val = Console.ReadLine();
            int a = int.Parse(val);

            switch(a)
            {
                case 0:
                    Console.WriteLine("0이 입력되었습니다");
                    break;
                case 1:
                    Console.WriteLine("1이 입력되었습니다");
                    break;
                case 2:
                    Console.WriteLine("2이 입력되었습니다");
                    break;
                default:
                    Console.WriteLine("해당사항 없습니다");
                    break;
            }
        }
    }
}
