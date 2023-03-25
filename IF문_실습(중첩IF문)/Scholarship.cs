using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace IF문_실습_중첩IF문_
{
    internal class Scholarship
    {
        public Student MyStudent { get; set; }

        public Scholarship(Student st) 
        {
            MyStudent = st;
        }

        public Scholarship():this(null)
        {
        }

        public void EvaluteScholarShip()
        {
            if(MyStudent == null)
            {
                Util.ErrorMessage("평가할 학생이 없습니다");
                return;
            }
            
            else if(MyStudent.Sex == SexEnum.오류)
            {
                Util.ErrorMessage("성 구분이 틀렸습니다");
                return;
            }

            else if (MyStudent.Sex == SexEnum.남성)
            {
                if (IsError(MyStudent.Score)) return;
                if (MyStudent.Score > 90) Util.PrintMessage("우수장학생");
                else if (MyStudent.Score > 80) Util.PrintMessage("장학생");
                else Util.PrintMessage("해당사항 없음");
            }

            else
            {
                if (IsError(MyStudent.Score)) return;
                if (MyStudent.Score > 90) Util.PrintMessage("해외연수장학생");
                else if (MyStudent.Score > 80) Util.PrintMessage("국비장학생");
                else Util.PrintMessage("해당사항 없음");
            }
        }

        bool IsError(int value)
        {
            if (MyStudent.Score == -2)
            {
                Util.ErrorMessage("성적이 범위를 벗어났습니다.");
                return true;
            }
            return false;
        }
    }
}
