using MyLibrary;

namespace IF문_실습_ELSE_
{
    internal class IfTestMgr
    {
        public void Run()
        {
            // 여기부터 프로그램 시작
            PrintResult(Util.GetDigit());
        }

        private void PrintResult(int digit)
        {
            // 범위 오류체크
            if (digit < 0 || digit > 100)
            {
                Console.WriteLine("[오류]숫자가 아니거나 또는 범위를 벗어났습니다");
                return;
            }

            if (digit >= 90)
            {
                Console.WriteLine("우수");
                Console.WriteLine("수고 하셨습니다");
            }

            else
            {
                Console.WriteLine("보통");
                Console.WriteLine("좀더 노력하세요");
            }
        }
    }
}
