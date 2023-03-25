using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스_상속
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 동물
            // 나이, 성별, 몸무게, 크기, 종...

            // 사람
            // 성명, 혈액형, 국적, 주소, 전화번호...

            // 학생
            // 학년, 반, 번호, (학번), 

            // Object

            Student a = new Student();
            a.Grade= 1;
            a.StudentClass= 10;
            a.StudentID= 35;
            a.Name = "안장근";
            a.Address = "경기도 이천시";

            Human h = a;
            Console.WriteLine(h);
            Console.WriteLine(a);
        }
    }
}
