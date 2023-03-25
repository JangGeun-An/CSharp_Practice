using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인터페이스_IComparable_
{
    internal class Test
    {
        public void Run()
        {
            Student[] students = new Student[]
            {
                new Student("안장근 ", 89, 1),
                new Student("안장근2 ", 78, 2),
            };
            Array.Sort(students);
            foreach (Student st in students) Console.WriteLine(st);
        }
    }

    class Student : IComparable
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int ID { get; set; }

        public Student(string name, int score, int id)
        {
            Name = name;
            Score = score;
            ID = id;
        }

        public override string ToString()
        {
            return $"{Name}[{ID}][{Score}]";
        }

        public int CompareTo(object obj)
        {
            Student st = obj as Student;
            return ID - st.ID;
        }
    }
}
