namespace Class_8th
{
    public class GameObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 콜렉션
            // Collection
            // ArrayList : 모든 타입을 다 받을 수 있습니다.
            // List
            // LinkedList
            // Stack
            // Queue
            // Dictionary - HashTable(Key - Value)

            // ArrayList
            /*
            ArrayList arrayList = new ArrayList();

            arrayList.Add(10);
            arrayList.Add("String");
            arrayList.Add(57.5f);
            arrayList.Add('A');

            Console.WriteLine("arrayList Count : " + arrayList.Count);

            foreach (object element in  arrayList)
            {
                Console.WriteLine(element);
            }

            // [10] [String] [57.5f] [A]

            arrayList.Remove(10);
            Console.WriteLine("");
            Console.WriteLine("arrayList Count : " + arrayList.Count);

            foreach (object element in arrayList)
            {
                Console.WriteLine(element);
            }

            */

            // List
            /*
            List<int> list = new List<int>();
            
            list.Capacity = 10;

            // [10] [20] [30] [40] [50] [] [] [] [] [] 
            list.Add(20);
            list.Add(7);
            list.Add(12);
            list.Add(35);
            list.Add(22);

            list.Remove(45);
            list.RemoveAt(4);

            list.Sort(); // 리스트 안에 있는 원소를 정렬하는 함수
            list.Reverse(); // 리스트 안에 있는 원소를 반전하는 함수

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            List<string> G_name = new List<string>();

            G_name.Capacity = 5;

            G_name.Add("메이플스토리");
            G_name.Add("서든어택");
            G_name.Add("바람의나라");
            G_name.Add("피파온라인");
            G_name.Add("마구마구");

            Random random = new Random();

            int G_count = G_name.Count;

            for (int i = 0; i < G_count; i++)
            {
                int rand = random.Next(0, G_name.Count);
                Console.WriteLine(G_name[rand]);
                G_name.RemoveAt(rand);
            }
            */

            // LinkedList
            /*
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddLast(100);

            foreach(var item in linkedList)
            {
                Console.WriteLine(item);
            }
            */

            // Random 클래스
            /*
            Random random = new Random();

            int rand = random.Next(0, 10);
            Console.WriteLine("random : " + rand);
            */

            // Stack
            /*
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(11);
            stack.Push(12);
            stack.Push(13);

            stack.Pop(); // pop : 가장 위에있는 데이터를 삭제합니다.
            Console.WriteLine("stack Peek : " + stack.Peek()); // peek : 가장 위에 있는 데이터를 반환합니다.

            foreach(var i in stack) 
            {
                Console.WriteLine(i);
            }
            */

            // Queue
            /*
            Queue<GameObject> queue = new Queue<GameObject>();
            
            string[] objectName = new string[4] { "Cube", "Sphere", "Cylinder", "Capsule" };

            queue.Enqueue(new GameObject()); // []
            queue.Enqueue(new GameObject()); // [] [] 
            queue.Enqueue(new GameObject()); // [] [] []
            queue.Enqueue(new GameObject()); // [] [] [] []

            Console.WriteLine("Queue Size : " + queue.Count);

            int queueSize = queue.Count;

            for (int i = 0; i < queueSize; i++)
            {
                GameObject gameObject = queue.Dequeue();
                gameObject.Name = objectName[i];
                Console.WriteLine(gameObject.Name);
            }
            */

            // HashTable
            /*
            Hashtable hashTable = new Hashtable();

            // KEY - VALUE
            hashTable.Add("Sword", 1000);
            hashTable.Add('A', 57.4f);
            hashTable.Add(203, 74.123);

            // 구조체는 값 타입
            // 클래스는 참조 타입

            foreach(DictionaryEntry pair in hashTable)
            {
                Console.WriteLine("Key : " + pair.Key + " " + "Value : " + pair.Value );
            }
            */

            // Dictionary
            /*
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("Maple story", 2003);
            dictionary.Add("League of Legend", 2011);
            dictionary.Add("Mini Fighter", 2006);

            if(dictionary.ContainsKey("Maple story"))
            {
                Console.WriteLine("키가 존재합니다");
            }

            foreach(var element in dictionary)
            {
                Console.WriteLine(element);
            }
            */

            #endregion
        }
    }
}