namespace Class_17th
{
    internal class Class_17th
    {
        public int Fibo(int n, int[] memorization)
        {

            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }

            if (memorization[n] != 0)
            {
                return Fibo(n - 1, memorization) + Fibo(n - 2, memorization);
            }

            return memorization[n] = Fibo(n - 1, memorization) + Fibo(n - 2, memorization);

        }

        public class DynamicFibo
        {
            private int[] arr;
            public DynamicFibo()
            {
                arr = new int[100];
                arr[0] = 0;
                arr[1] = 1;
            }

            public void DyFibo(int n)
            {
                for (int i = 2; i <= n; i++)
                {
                    arr[i] = arr[i - 1] + arr[i - 2];
                }
            }

            public void ShowFibo(int n)
            {
                Console.WriteLine(arr[n]);
            }
        }

        static void Main(string[] args)
        {
            #region 동적 계획법
            // 특정 범위까지의 값을 구하기 위해서 그것과
            // 다른 범위까지의 값을 이용하여 효율적으로 값을
            // 구하는 알고리즘입니다.

            // 메모이제이션
            // 프로그램이 동일한 계산을 반복해야 할때, 이전에
            // 계산한 겂을 메모리에 저장함으로써 동일한 계산을
            // 반복 수행하는 작업을 제거하여 프로그램의 실행 속도를
            // 향상시키는 기술입니다.


            Program program = new Program();

            int count = Convert.ToInt32(Console.ReadLine());
            int[] memoization = new int[count + 1];

            Console.WriteLine(program.Fibo(5, memoization));


            //DynamicFibo dynamicFibo = new DynamicFibo();
            //dynamicFibo.DyFibo(10);
            //dynamicFibo.ShowFibo(10);
            #endregion
        }
    }
}