namespace Program
{

    #region 프로퍼티
    public class Transform
    {
        private int x;
        private int y;
        private int z;

        public int X
        {   
            set 
            {   if(value >= 100)
                {
                    Console.WriteLine("I received an unexpected value");
                    return;
                }

                x = value; 
            }
            get { return x; } // 읽기 전용, X를 반환하면 자기 자신을 여러번 호출하기 때문에
                              // 무한 반복이 된다.
        }
    }
    #endregion

    #region 메소드 숨기기
    public class Weapon
    {
        protected int attack;

        public void Information()
        {
            Console.WriteLine("Weapon 정보");
        }

        public virtual void Action()
        {
            Console.WriteLine("Weapon의 동작");
        }
    }

    public class Sword : Weapon
    {
        public new void Information()
        {
            Console.WriteLine("Sword 정보");
        }

        public override void Action()
        {
            Console.WriteLine("Sword의 동작");
        }
    }



#endregion
internal class Program
    {
        static void Main(string[] args)
        {
            // 프로퍼티
            /*
            Transform transform = new Transform();
            transform.X = 100;
            Console.WriteLine(transform.X);
            */

            // 메소드 숨기기
            /*
            Sword sword = new Sword();
            sword.Information();
            sword.Action();
            */

            // 가상 함수
            Weapon weapon = new Sword(); // Weapon 타입이라 Weapon만 읽을 수 있음
            weapon.Information(); // => Weapon의 정보
            weapon.Action();      // => Seeeeeword의 동작

        }
    }
}