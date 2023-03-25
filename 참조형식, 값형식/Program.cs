using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 참조형식__값형식
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //int b = 2;

            //Console.WriteLine($"1) a = {a} / b = {b}");
            //int c = ValueTypeTest(a, b);
            //Console.WriteLine($"2) a = {a} / b = {b}");

            Student st = new Student();
            st.Name = "Lee";
            Console.WriteLine(st.Name);
            ReferenceTypeTest(st);
            Console.WriteLine(st.Name);
        }

        static int ValueTypeTest(int a, int b)
        {
            Console.WriteLine($"3) a = {a} / b = {b}");
            a++;
            b++;
            Console.WriteLine($"4) a = {a} / b = {b}");
            return a + b;
        }

        static void ReferenceTypeTest(Student a)
        {
            a.Name = "Kim";
        }
    }

    /// <summary>
    /// 참조 형식으로 학생 클래스입니다.
    /// </summary>
    struct Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
