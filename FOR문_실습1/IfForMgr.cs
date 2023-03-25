using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR문_실습1
{
    internal class IfForMgr
    {
        public void Run()
        {
            TimesTable tt = new TimesTable();
            for(int i = 2; i < 10; i++)
            {
                tt.Base = i;
                tt.PrintBase();
                Console.WriteLine("------------------");
            }
        }
    }
}
