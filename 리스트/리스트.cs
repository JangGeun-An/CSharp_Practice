using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 리스트
{
    internal class 리스트
    {
        public void Run()
        {
            ArrayList list= new ArrayList();
            list.Add(1);
            int a = (int)list[0];
            
            List<int> list1 = new List<int>();
            list1.Add(1);
            a = list1[0];
            Console.WriteLine(list1.Count);
            //list1.Remove(1);
            list1.RemoveAt(0);
            Console.WriteLine(list1.Count);

            Dictionary<int, string> dic = new Dictionary<int, string>();
            // <key, value>
            dic.Add(1, "홍길동");
            dic.Add(2, "황진이");
            dic.Add(2, "이교준");
            SortedDictionary<int, string> sdic = new SortedDictionary<int, string>();
        }
    }
}
