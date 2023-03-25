using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Deleg
    {
        delegate void MyDelegate(int val);
        delegate void MyDelegate1(int val);
        public void Run() 
        {
            int a = 3;
            Student st = new Student();
            st.Name = "홍길동";
            Console.WriteLine(st);

            //DelegateTest(3);
            MyDelegate dele = new MyDelegate(DelegateTest);
            MyDelegate dele1 = new MyDelegate1(DelTest1);
            dele(4);
        }

        private void DelegateTest(int myVal)
        {
            Console.WriteLine($"DelegateTest() called {myVal}");
        }

        private int DelTest1(int myVal)
        {
            return myVal + 1;
        }
    }
}
