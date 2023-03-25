using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인터페이스_IDisposable_
{
    internal class Test
    {
        public void Run()
        {
            Student[] students = new Student[] 
            { 
                new Student("안장근", 89, 2),
                new Student("장근", 78, 1)
            };
            Array.Sort(students);
            foreach (Student st in students) Console.WriteLine(st);
        }
    }

    class Student : IComparable, IDisposable
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

        StreamReader reader;

        public int CompareTo(object obj)
        {
            Student st = obj as Student;
            return ID - st.ID;
        }

        ~ Student() 
        {
            Dispose(false);
        }

        bool disposed; // false

        private void aaa()
        {
            FileStream stream = new FileStream(@"d:\temp\aa.txt", FileMode.Open);
            reader = new StreamReader(stream);
            string buffer;
            while ((buffer = reader.ReadLine()) != null)
             {
             }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if(disposed) return;
            if(disposing)
            {
                // C#에서 사용하는 IDisposable을 구현한 객체들 정리
                reader.Close();
                reader.Dispose();
            }

            else
            {
                // .NET Framework에서 관리되지 않는 자원들 정리
            }
        }
    }
}
