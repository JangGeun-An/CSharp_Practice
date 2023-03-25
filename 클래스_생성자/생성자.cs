using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 클래스_생성자2; // 다른 namespace를 사용할 수 있게 된다.

namespace 클래스_생성자
{
    internal class 생성자
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "안장근";
            student1.Name2 = "안장근2";
            student1.SetAge(27);
            student1.SetAge(1000);
            student1.SetAge(-1);
            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.Name2);
        }
    }
}
