using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System_IO.StudentEnum;

namespace System_IO
{
    internal class Stream
    {
        Student[] students = new Student[3];
        public void Run() 
        {
            ReadStudent();
            PrintStudent();
            //WriteStudent();
        }

        private void WriteStudent()
        {
            FileStream stream = new FileStream(@"D:\tmp\student.bak", FileMode.Create);
            StreamWriter writer = new StreamWriter(stream, Encoding.Default);
            foreach(Student st in students)
                writer.WriteLine($"{st.Name}#{st.StudentSex}#{st.Score}");
            writer.Close();
        }

        private void PrintStudent()
        {
            for (int i = 0; i < 3; i++) Console.WriteLine(students[i]);
        }

        private void ReadStudent()
        {
            FileStream stream = new FileStream(@"D:\tmp\student.txt", FileMode.Open);
            StreamReader reader= new StreamReader(stream, Encoding.Default);
            string buffer = null;
            int index = 0;
            while((buffer = reader.ReadLine()) != null)
                InsertStudent(buffer, index);
            reader.Close();
        }

        private void InsertStudent(string buffer, int index)
        {
            Student st = new Student();
            string[] tmp = buffer.Split('#'); //tmp[0], tmp[1], tmp[2]
            if(tmp.Length != 3 )
                throw new Exception("텍스트 내용에 오류가 있습니다: " + buffer);
            st.Name = tmp[0];
            st.Score = Convert.ToInt32(tmp[2]);
            int isex = int.Parse(tmp[1]);
            st.StudentSex = (Sex)Enum.ToObject(typeof(Sex), isex);
        }
    }
}
