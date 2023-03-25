using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_클래스
{
    class Cir : Figure
    {
        public Double Diameter { get; set; }

        public Cir(Double diameter) 
        {
            Diameter = diameter;
        }
        /// <summary>
        /// 원의 면적을 반환합니다
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override double Area()
        {
            return ((Diameter / 2) * (Diameter / 2)) * 3.14;
        }
    }
}
