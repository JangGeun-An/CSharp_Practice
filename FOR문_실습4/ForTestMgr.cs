using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR문_실습4
{
    internal class ForTestMgr
    {
        public void Run()
        {
            for(int i=0; i<5; i++)
            {
                PrintBlank(i);
                PrintStar(i);
                PrintNewLine();
            }
        }

        #region 코드들
        void PrintStar(int i)
        {
            // i는 0부터 4까지 연속된 값이 넘어옴.
            for (int j = 0; j < (i*2+1); j++)
            {
                Console.Write("*");
            }
        }

        void PrintBlank(int i)
        {
            for(int j=0; j<(4-i); j++)
            {
                Console.Write(" ");
            }
        }

        void PrintNewLine()
        {
            Console.WriteLine();
        }
        #endregion
    }
}
