namespace First_Class
{
    // 접근 지정자 class 클래스 이름
    // public, protected, private

    // <자료형>
    // Object 자료형

    // 값타입과 참조 타입
    // 값타입: bool, byte, char, short, int, long, float, double, struct, decimal, long long
    // 참조타입: class, string, delegate, array, dynamic, object, interface (참조타입이 값타임보다 더 큰 개념)

    // Boxing
    // 값타입 -> 참조타입
    // Unboxing
    // 참조타입 -> 값타입

    // 배열 생성
    // int [] buffer = new int[5];
    // 스택에 buffer참조 변수가 생기고
    // 힙에 메모리가 5개가 생김
    // delete 할 필요없이 가비지 컬렉터가 자동으로 삭제함

    // 세대 기반 가비지 컬렉션 (압축 기능) // 자투리 공간 활용
    // 비세대 기반 가비지 컬렉션 (압축 기능 X)\

    // c#에서는 자료형 크기 보는것이 막혀있음

    public class Module
    {
        public void SetData()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 자료형
            /*
            // 초기화를 안하면 자동으로 0값이 들어감
            byte stream = 1;
            bool boolean = false;
            char character = 'A';
            short data = 200;
            int integer = 100;
            long longData = 300;

            float[] buffer = new float[3];
            buffer[0] = 1.15f;
            // c#에서 float를 사용하려면 f접미사를 꼭 붙여야함 3.14f
            double pi = 3.14;
            decimal decimalData = 0.1m; // 16 byte, 접미사 m

            // 출력해주는 함수
            // Console.WriteLine(): 문자열을 출력하는 함수
            Console.WriteLine(boolean);
            Console.Write("steam " + stream);
            // 개행 하기 싫으면 Console.Write()을 사용
            Console.WriteLine("stream " + stream);
            */
            #endregion


            // 박싱과 언박싱은 속도가 엄청 느림
            #region 박싱(Boxing)
            // 값 형식의 데이터를 참조 형식으로 변환하는 과정입니다.

            //int data = 5;

            //object obj = data;
            //Console.WriteLine("data의 값: " + data);
            //Console.WriteLine("obj의 값: " + obj);

            #endregion

            #region 언박싱(UnBoxing)
            /*
            // 참조 타입의 데이터를 값 타입으로 변환하는 과정입니다.

            int count = 10;
            object obj1 = count;

            //참조타입이 더 큰데 작은 값에 넣으려 하니 ERROR
            // int result = obj1; ERROR

            // 명시적으로 값 변환을 해주어야함
            int result = (int)obj1;
            */
            #endregion

        }
    }
}