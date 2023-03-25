using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스_생성자2
{

        /// <summary>
        /// <para>클래스_생성자2.Student 클래스 정의</para>
        /// <para>이것은 테스트 입니다2.</para>
        /// </summary>
        public class Student
        {
        private string name;
        private string address;
        private int age;

        // method_name(type) <- 시그니쳐(메서드의 풀네임), type까지 같아야 동일
        // 이름은 같은데 시그니쳐가 달라서 서로 다른것 으로 인식하는 것을 오버로딩(오버로드) 라고 한다

        #region 생성자
        public Student(string name, string address)
        {
            this.name = name; //this.을 붙이면 내 클래스에 라는 의미
            this.address = address;
        }

        public Student(string name) : this(name, null) // this(name, null)로 상위 것을 불러온다
        {
        }

        public Student():this(null) // this(null)로 상위 것을 불러온다
        {
            //Console.WriteLine("클래스_생성자2.Student() 생성자 호출됨");
        }
        #endregion 생성자

        /// <summary>
        /// getter of name
        /// </summary>
        /// <returns></returns>
        public string GetName() 
        {
            return name;
        }

        /// <summary>
        /// setter of name
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            this.name = name;
        }

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public string Name2 { get; set; }

        public int GetAge(int age)
        {
            return age;
        }

        public void SetAge(int age)
        {
            if(age<0||age>121)
            {
                Console.WriteLine("나이는 음수나 120세를 넘을 수 없습니다");
                return;
            }
            this.age = age;
        }

        public void printName() 
        {
            Console.WriteLine("name = " + name);
        }

        public void printAddress()
        {
            Console.WriteLine("address = " + address);
        }

    }
}