using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF문_실습_중첩IF문_
{
    internal class IfTestMgr
    {
        public void Run()
        {
            Scholarship scholar = new Scholarship();
            Student st = new Student();
            st.ReadProperty();
            scholar.MyStudent= st;
            scholar.EvaluteScholarShip();
        }
    }
}
