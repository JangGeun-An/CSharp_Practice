﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Util
    {
        /// <summary>
        /// 콘솔로부터 0 이상의 숫자를 받아들입니다.
        /// 만일 문자가 입력되면 -1이 반환됩니다.
        /// 숫자가 입력된 경우 int 형식으로 반환됩니다.
        /// </summary>
        /// <returns>int 숫자</returns>
        static public int GetDigit()
        {
            Console.WriteLine("숫자를 입력하세요[0~100]");
            string val = Console.ReadLine();
            return ConvertStrToInt(val); // val == -1은 에러
        }

        /// <summary>
        /// <para>콘솔로부터 0 이상의 숫자를 받아들입니다.
        /// 만일 문자가 입력되면 -1이 반환됩니다.
        /// 숫자가 입력된 경우 int 형식으로 반환됩니다.</para>
        /// <para>이 함수는 주어진 min 값과 max값의 범위를 체크합니다.
        /// 만일 범위를 벗어나면 -2를 반환합니다.</para>
        /// </summary>
        /// <returns>int 숫자</returns>
        static public int GetDigit(int min, int max)
        {
            Console.WriteLine("숫자를 입력하세요[0~100]");
            string val = Console.ReadLine();
            int iret =  ConvertStrToInt(val); // val == -1은 에러
            if (iret < 0)
                return iret;
            if(iret > max || iret < min) 
                return -2;
            return iret;
        }

        /// <summary>
        /// 문자값을 숫자로 변환해서 반환합니다.
        /// 만일 숫자가 아닌 문자가 포함된 경우는 -1을 반환합니다.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static public int ConvertStrToInt(string str)
        {
            int result = 0;
            bool ret = int.TryParse(str, out result); // string값을 int로 바꿀수 있을 때만 변환한다

            if (ret)
                return result;
            else
                return -1; // 0~100. -1: error
        }

        static public SexEnum GetSex()
        {
            Console.WriteLine("성별 입력[1: 남성, 2: 여성] : ");
            string sex = Console.ReadLine();
            int isex = ConvertStrToInt(sex);
            if (isex == 1) return SexEnum.남성;
            else if (isex == 2) return SexEnum.여성;
            else return SexEnum.오류;
        }

        static public string GetName()
        {
            START:
            Console.WriteLine("성명 입력 : ");
            string name = Console.ReadLine();
            if(string.IsNullOrEmpty(name)) goto START;
            return name;
        }

        static public void ErrorMessage(string str)
        {
            Console.WriteLine(str);
        }

        static public void PrintMessage(string str)
        {
            Console.WriteLine(str);
        }
    }
}
