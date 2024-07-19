using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    internal class CodingTest_5
    {
        //정수 배열 numbers가 매개변수로 주어집니다. numbers의 원소의 평균값을 return하도록 solution 함수를 완성해주세요.
        public double solution(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double answer = (float)sum / numbers.Length;
            return answer;
        }

        //public double solution(int[] numbers)
        //{
        //    return numbers.Average();
        //}
    }
}
