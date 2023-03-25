using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace System_String
{
    internal class Prac
    {
        public void Run()
        {
            string str = GetString();
            if (Find해묘미(str)) Console.WriteLine("해묘미 합입니다");
            if (Find인오술(str)) Console.WriteLine("인오술 합입니다");
            if (Find사유축(str)) Console.WriteLine("사유축 합입니다");
            if (Find신자진(str)) Console.WriteLine("신자진 합입니다");
            Console.WriteLine(DateTime.Today.ToShortDateString().Replace("-",""));
            Console.WriteLine(DateTime.Now.ToString("yyyyMMdd"));
        }

        private bool Find신자진(string str)
        {
            if (str.Contains("신"))
                if (str.Contains("자"))
                    if (str.Contains("진"))
                        return true;
            return false;
        }

        private bool Find사유축(string str)
        {
            string[] 사유축 = new string[] { "사", "유", "축" };
            foreach (string s in 사유축)
                if (str.IndexOf(s) < 0) return false;
            return true;
        }

        private bool Find인오술(string str)
        {
            string[] 인오술 = new string[] { "인", "오", "술" };
            foreach(string s in 인오술)
                if (str.IndexOf(s) < 0) return false;
            return true;
        }

        /// <summary>
        /// str은 6자를 가지고 있다.
        /// 여기에 해, 묘, 미 세 글자가 포함되어 있으면 true를 반환, 아니면 false 반환
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool Find해묘미(string str)
        {
            if (str.Contains("해"))
                if (str.Contains("묘"))
                    if (str.Contains("미"))
                        return true;
            return false;
        }

        private string GetString()
        {
            while(true)
            {
                Console.WriteLine("6자 입력 : ");
                string str = Console.ReadLine();
                if (str.Length != 6)
                {
                    continue;
                }
                else
                    return str;
            }
        }
    }
}
