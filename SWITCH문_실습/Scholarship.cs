using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace SWITCH문_실습
{
    internal class Scholarship
    {
        string Name = null;
        SexEnum Sex;
        int Score;

        public Scholarship()
        {
        }

        public void MakeStudent()
        {
            Name = Util.GetName();
            Score = Util.GetDigit();
            Sex = Util.GetSex();
            //TestMe();
            EvaluteScholarShip(Name, Sex, Score);
        }

        private void TestMe()
        {
            Name = null;
        }

        public void EvaluteScholarShip(string name, SexEnum sex, int score)
        {
            if (sex == SexEnum.오류)
            {
                Util.ErrorMessage("성 구분이 틀렸습니다");
                return;
            }

            switch (sex)
            {
                case SexEnum.남성:
                    PrintMan(score);
                    break;
                case SexEnum.여성:
                    PrintWoman(score);
                    break;
                default:
                    break;
            }

            void PrintMan(int score)
            {
                if (IsError(score)) return;
                if (score > 90) Util.PrintMessage(Name + " : 우수장학생");
                else if (score > 80) Util.PrintMessage("장학생");
                else Util.PrintMessage("해당사항 없음");
            }

            void PrintWoman(int score)
            {
                if (IsError(score)) return;
                if (score > 90) Util.PrintMessage("해외연수장학생");
                else if (score > 80) Util.PrintMessage("국비장학생");
                else Util.PrintMessage("해당사항 없음");
            }
        }
        bool IsError(int value)
        {
            if (Score == -2)
            {
                Util.ErrorMessage("성적이 범위를 벗어났습니다.");
                return true;
            }
            return false;
        }
    }
}
