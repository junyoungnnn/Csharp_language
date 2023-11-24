namespace Class_2nd
{
    public class Item
    {
        private int price;
        public string name;

        public void View()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("price: " + price);
        }
    }

    public class Vector3
    {
        // ref: 하나의 변수에 서로 다른 이름으로 사용할 수 있는 키워드 입니다.
        public void Distance(ref int x)
        {
            x = 100;
        }

        // in: const ref라고 생각하면됨
        // 읽기 전용으로 적용되며, 참조로 전달하는 키워드입니다.
        public void Lerp(in int x)
        {
            Console.WriteLine("x의 값: " + x);
        }

        // out : 출력용 매개 변수로 함수 내에서 값을 반드시 초기화해야 합니다.
        public void MoveTowards(out int x)
        {
            x = 999;
        }

        // params : 가변 길이 매개변수
        public void Normalize(params object[] list)
        {
            object sum;

            for (int i = 0; i < list.Length; i++)
            {
                sum = list[i];
                Console.Write(sum + " ");
            }
            Console.WriteLine("");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            #region 가비지 컬렉터
            /*
            // 동적으로 할당된 메모리 영역 가운데 더 이상
            // 사용할 수 없게 된 영역을 탐지하여 자동으로 해제하는 기법입니다.
            {
                // 가비지 컬렉션이 자동으로 해제하기때문에 수동으로 delete 할 필요없음
                Item item = new Item();
                item.View();
            }

            // 참조변수 Item item이 사라져서 사용을 못함
            Item potion = new Item();

            // <세대별 가비지 컬렉션>
            // 0세대 가장 빈번하게 삭제되는 애들이 있는 곳
            // 1세대 0세대 가비지 컬렉션이 실행되고 남은 애들이 옴
            // 2세대 1세대 가비지 컬렉션이 실행되고 남은 애들과 계속 남아있는 애들
            // FULL GC가 잘 안생기게 해주어야함
            */
            #endregion

            #region 매개변수 한정자

            int x = 0;

            Vector3 vector3 = new Vector3();
            // ref
            /*
            vector3.Distance(ref x);

            Console.WriteLine("x의 값: " + x);
            */

            // in 
            /*
            vector3.Lerp(x);
           */

            // out
            /*
            vector3.MoveTowards(out x);
            Console.WriteLine("x의 값: " + x);
            */

            // params
            /*
            vector3.Normalize(1, 2, 3, 4, 5);
            vector3.Normalize('A', 'B', 'C', 'D', 'E');
            */
            #endregion
        }
    }
}