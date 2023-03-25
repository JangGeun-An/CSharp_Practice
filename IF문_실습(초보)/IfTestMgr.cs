using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF문_실습_초보_
{
    internal class IfTestMgr
    {
        public void Run()
        {
            // 여기부터 프로그램 시작
            PrintResult(GetDigit());
        }

        private void PrintResult(int digit)
        {
            // 범위 오류체크
            if(digit < 0 || digit > 100)
            {
                Console.WriteLine("[오류]숫자가 아니거나 또는 범위를 벗어났습니다");
                return;
            }

            if(digit > 90)
            {
                Console.WriteLine("우수");
                Console.WriteLine("수고하셨습니다");
            }
        }

        // 키보드로 string 값을 입력 받음
        private int GetDigit()
        {
            Console.WriteLine("숫자를 입력하세요[0~100]");
            string val = Console.ReadLine();
            return ConvertStrToInt(val); // val == -1은 에러
        }

        // 받아온 string 값을 int 값으로 변환
        private int ConvertStrToInt(string str)
        {
            int result = 0;
            bool ret = int.TryParse(str, out result); // string값을 int로 바꿀수 있을 때만 변환한다
            
            if(ret)
                return result;
            else
                return -1; // 0~100. -1: error
        }
    }
}
