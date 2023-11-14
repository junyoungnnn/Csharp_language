namespace Class_4th
{
    public interface IItem
    {
        void Use();
    }

    public interface IWaitTime
    {
        void wait(float timer);
    }

    public class Player
    {
        public void OnTrigegerEnter(IItem item)
        {
            item.Use();
        }

        //public void OnTrigegerEnter(IWaitTime timer)
        //{
        //    timer.wait(50.0f);
        //}

    }

    public class GameObject
    {
        private int guID;
        public int GUID
        {
            set { guID = value; }
            get { return guID; }
        }

        public GameObject Clone()
        {
            // 1.class를 생성합니다.
            GameObject cloneObject = new GameObject();

            // 2. class 안에 있는 데이터를 넣어줍니다.
            cloneObject.guID = guID;

            // 3. class를 반환합니다.
            return cloneObject;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 얕은 복사
            /*
            GameObject gameObject1 = new GameObject();

            GameObject gameObject2 = gameObject1;

            gameObject2.GUID = 99;

            Console.WriteLine("gameObject1의 guid: " +  gameObject1.GUID);
            Console.WriteLine("gameObject2의 guid: " +  gameObject2.GUID);
            */
            #endregion

            #region 깊은 복사

            //GameObject clone1 = new GameObject();

            //GameObject clone2 = clone1.Clone();

            //clone1.GUID = 456;
            //clone2.GUID = 111;

            //Console.WriteLine("clone1의 guid: " + clone1.GUID);
            //Console.WriteLine("clone2의 guid: " + clone2.GUID);

            #endregion

            // C#은 다중상속을 지원하지 않습니다.
            // 인터페이스는 다중상속을 지원합니다.
            // public interface를 만들어서 상속시키면 된다.
            // interface 뒤에 'I'를 꼭 붙여주어야한다.
            // interface 안에 있는 함수는 상속한 클래스에서 재정의를 해주어야한다.

            #region 인터페이스
            Player player = new Player();

            // 인터페이스 참조 변수를 선언할 수 있지만,
            // 인스턴스를 생성할 수 없습니다.
            // IItem item = new IItem();

            //player.OnTrigegerEnter(new Magnet());
            //player.OnTrigegerEnter(new Missile());
            //player.OnTrigegerEnter(new Shield());

            #endregion

            #region 추상클래스

            //Juggling juggling = new Juggling();
            //juggling.Information();
            //juggling.Skill();

            #endregion
        }
    }
}