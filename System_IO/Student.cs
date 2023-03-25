using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System_IO.StudentEnum;

namespace System_IO
{
    internal class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Sex StudentSex { get; set; }

        public override string ToString()
        {
            return $"{Name}[{StudentSex}][{Score}]";
        }
    }
}
