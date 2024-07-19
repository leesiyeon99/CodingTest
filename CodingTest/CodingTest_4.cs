using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class CodingTest_4
    {
        //정수 num1, num2가 매개변수로 주어질 때, num1를 num2로 나눈 나머지를 return 하도록 solution 함수를 완성해주세요.
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = 0;
                float divide = (float)num1 / (float)num2;
                answer = (int)(divide * 1000);

                //answer = num1 * 1000 / num2;
                return answer;
            }
        }
    }
}
