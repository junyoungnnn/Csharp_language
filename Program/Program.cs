using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    
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

            ArrayList arrayList = new ArrayList();

            arrayList.Add(10);
            arrayList.Add("String");
            arrayList.Add(57.5f);
            arrayList.Add('A');

            foreach(object element in  arrayList)
            {
                Console.WriteLine(element);
            }


            #endregion

        }
    }
}