using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace practiceKing
{
    class Program
    {
        static void Main(string[] args)             
        {
            try
            {
                //https://by-man.tistory.com/326 여기서 문제 보자
                //길이(글자수)가 100이하인 문자열을 입력받아 공백을 제거하고 출력하시오. 나는 글자수가 100개 이하인 것으로 하겠다

                Console.WriteLine("문자열을 입력하시오 : ");
                string Munja = Console.ReadLine().Trim().Replace(" ", "");
                if (Munja.Equals(""))
                    Console.WriteLine("조건에 맞지 않습니다");
                else if (Munja.Length < 100)
                { Console.WriteLine(Munja); }
                else
                    throw new Exception();
            }
            catch (Exception err)
            { Console.WriteLine(err.Message);  }

        }


    }
}
