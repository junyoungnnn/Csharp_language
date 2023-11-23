namespace Class_10th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 등차 수열
            /*
            int first;

            int commonDifferent;

            int n;

            // Console.ReadLine() : string 타입으로만 값을 반환합니다.

            //string name = Console.ReadLine();
            //Console.WriteLine("name 변수의 값 : " + name);

            // Int32.Parse : int 타입으로 값을 반환합니다.
            
            Console.Write("첫 항의 값 입력 : ");
            first = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("공차의 값 입력 : ");
            commonDifferent = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("n의 값 입력 : ");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("first 변수의 값 : " + first);
            Console.WriteLine("commonDifferent 변수의 값 : " + commonDifferent);
            Console.WriteLine("n 변수의 값 : " + n);
            Console.WriteLine(" ");
           
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(first + commonDifferent * i);
            }
             */

            #endregion

            #region 등비수열
            /*
            int firstNum;
            int r;
            int size;

            Console.Write("firstNum의 값 : ");
            firstNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("공비의 값 : ");
            r = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("size의 값 : ");
            size = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(firstNum);
                firstNum *= r;
            }
            */
            #endregion

            #region 무명 형식
            /*
            // 이름이 존재하지 않는 개체 또는 변수를 의미합니다.

            var data = new { Name = "Data", Value = 10 };

            // 무명 형식의 경우 값을 읽기만 할 수 있습니다.
            // data.Name = 200;  // erorr

            Console.WriteLine("data.Name : " + data.Name + "data.Value : " + data.Value);
            */

            #endregion
        }
    }
}