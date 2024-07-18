namespace CodingTest
{
    internal class Program
    {
        public class Solution
        {
            //정수 num1과 num2가 주어질 때, num1에서 num2를 뺀 값을 return하도록 soltuion 함수를 완성해주세요.
            public int solution(int num1, int num2)
            {
                int answer = 0;
                answer = num1 - num2;
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int number1, number2;
            Console.Write("첫번째 숫자 입력: ");
            int.TryParse(Console.ReadLine(), out number1);
            Console.Write("두번째 숫자 입력: ");
            int.TryParse(Console.ReadLine(), out number2);
            int answer = solution.solution(number1, number2);
            Console.WriteLine("답은: "+answer);
        }
    }
}
