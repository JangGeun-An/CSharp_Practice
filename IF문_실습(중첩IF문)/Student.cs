using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace IF문_실습_중첩IF문_
{
    internal class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public SexEnum Sex { get; set; }

        public void ReadProperty()
        {
            Name = Util.GetName();
            Score = Util.GetDigit(0, 100);
            Sex = Util.GetSex();
        }
    }
}
