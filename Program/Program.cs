using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    
    internal class Program
    {
        

        static void Main(string[] args)
        {
            // HashTable
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

        }
    }
}