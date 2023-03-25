using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스_상속
{
    internal class Student : Human
    {
        public int Grade { get; set; }
        public int StudentClass { get; set; }
        public int StudentID { get; set; }

        public void Exam()
        {
            Console.WriteLine("I do Exam");
        }

        public override string ToString()
        {
            return $" {base.ToString()} : [저는 ] {Grade}학년 {StudentClass}반 {StudentID}번인 {Name}입니다";
        }
    }
}
