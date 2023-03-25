using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 구조체
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Student st2 = st;
            st.Name = "Lee";
            st2.Name = "Kim";
            Console.WriteLine(st.Name);
            Console.WriteLine(st2.Name);
            AAA(st);
        }

        static void AAA(Student st)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 참조 형식으로 학생 클래스입니다.
    /// </summary>
    struct Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}