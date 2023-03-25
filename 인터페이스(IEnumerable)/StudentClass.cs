using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인터페이스
{
    internal class StudentClass : IEnumerable
    {
        object[] = new object[];

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        class StudentEnumerator : IEnumerator
        {
            public object Current => throw new NotImplementedException();

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
