using System.Diagnostics;

namespace Program
{
    public delegate void Calculator(int x, int y);

    internal class Program
    {
        #region 델리게이트
        static void Add(int x, int y)
        {
            Console.WriteLine("x + y = " + (x + y));
        }

        static void Substract(int x, int y)
        {
            Console.WriteLine("x - y = " + (x - y));
        }

        static void Multiply(int x, int y)
        {
            Console.WriteLine("x * y = " + (x * y));
        }

        static void Divide(int x, int y)
        {
            Console.WriteLine("x / y = " + (x / y));
        }

        #endregion
        
        static void Main(string[] args)
        {
            #region 델리게이트

            // 함수포인터: 힘수의 주소를 저장하는 포인터

            //Calculator calculator;

            //calculator = Substract;
            //calculator(10, 20);

            // ex) 아이템을 먹을때마다 함수를 추가하고
            // 시간이 지나거나.. 등등으로 함수를 해제한다.

            #endregion

            #region 델리게이트 체인

            //calculator = Add;
            //calculator += Substract;
            //calculator += Multiply;
            //calculator += Divide;

            //calculator -= Divide;

            //calculator(5, 5);
            #endregion

            // readonly 런타임
            // const 컴파일 상수

            #region base 키워드

            Wizard wizard = new Wizard();

            #endregion

        }
    }
}