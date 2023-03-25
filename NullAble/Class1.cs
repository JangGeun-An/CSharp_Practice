using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullAble
{
    internal class Class1
    {
        public void Run()
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            Console.WriteLine(list1?.Count);
            int? ret = list2?.Count;
            Console.WriteLine(ret == null ? "null" : ret);
        }
    }

    class Member
    {
        public bool? GetMarried { get; set; } // bool? = Nullable<bool> 같다
    }
}