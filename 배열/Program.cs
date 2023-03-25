using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배열
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[30];
            students[0] = new Student("lee");
            students[1] = new Student("kim");
            students[33] = null;

            Student[] students_1 = new Student[30];
            Student[] students_2 = new Student[30];
            Student[] students_3 = new Student[30];
        }
    }

    class Student
    {
        private int kor;
        private string name;
        public Student(string name) 
        {
            this.name = name;
        }
    }
}
