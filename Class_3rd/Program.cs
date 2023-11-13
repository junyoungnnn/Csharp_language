namespace Class_3rd
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
            {
                if (value >= 100)
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

    #region 함수의 오버로딩
    public class GameObject
    {
        public void Destory()
        {
            Console.WriteLine("Destory GameObject");
        }

        public void Destory(float timer)
        {
            Console.WriteLine("Destory GameObject " + "Destory Time: " + timer);
        }

        public void GetComponent(string name, int id)
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("id : " + id);
        }

        public void SetActive(bool active = true)
        {
            Console.WriteLine("GameObject state : " + active);
        }

    }



    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 프로퍼티
            // 프로퍼티
            /*
            Transform transform = new Transform();
            transform.X = 100;
            Console.WriteLine(transform.X);
            */
            #endregion

            #region 매소드 숨기기
            // 메소드 숨기기
            /*
            Sword sword = new Sword();
            sword.Information();
            sword.Action();
            */
            #endregion

            #region 가상함수
            // 가상 함수
            /*
            Weapon weapon = new Sword(); // Weapon 타입이라 Weapon만 읽을 수 있음
            weapon.Information(); // => Weapon의 정보
            weapon.Action();      // => Sword의 동작, virtual로 정의, vptr을 사용해서 가상함수 테이블에서 호출
            */
            #endregion

            #region 함수의 오버로딩
            // 함수의 오버로딩
            GameObject gameObject = new GameObject();
            /*
            gameObject.Destory();
            gameObject.Destory(5f);
            */
            #endregion

            #region 명몀된 매개변수
            // 명명된 매개변수
            // gameObject.GetComponent(id: 5, name: "Sphere");
            // gameObject.GetComponent("Box", 10);
            #endregion

            #region 선택적 매개변수
            // 선택적 매개변수 == 디폴트 매개변수
            /*
            gameObject.SetActive();
            gameObject.SetActive(false);
            */
            #endregion
        }
    }
}