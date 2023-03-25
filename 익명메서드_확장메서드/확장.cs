using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 익명메서드_확장메서드
{
    static class MyClass
    {
        public static int GetWordCount(this string txt)
        {
            return txt.Split(' ').Length;
        }

        public static bool IsDigit(this string txt)
        {
            return int.TryParse(txt, out var digit);
        }

        public static int? ConvertToInt(this string txt)
        {
            if(int.TryParse(txt, out int digit)) return digit;
            else return null;
        }
    }

    internal class 확장
    {
        public void Run()
        {
            string kk = "Hello Hello World!!";
            string aa = "1133";
            string bb = "1234";
            Console.WriteLine(aa.IsDigit());
            Console.WriteLine(kk.GetWordCount());
            Console.WriteLine(bb.ConvertToInt());
        }
    }
}
