using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class CodingTest_8
    {
        //정수가 담긴 배열 array와 정수 n이 매개변수로 주어질 때, array에 n이 몇 개 있는 지를
        //return 하도록 solution 함수를 완성해보세요.
        public class Solution
        {
            public int solution(int[] array, int n)
            {
                int answer = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == n)
                    {
                        answer++;
                    }
                }
                return answer;
            }
        }
    }
}
