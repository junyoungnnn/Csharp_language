using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Shield : IItem, IWaitTime
    {
        public void wait(float timer)
        {
            Console.WriteLine("wait Time: " + timer);
        }

        public void Use()
        {
            Console.WriteLine("Use Shield");
        }
    }
}
