using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Program
{
    internal class Deque<T>
    {
        private T data;

        public void Set(T data)
        {
            this.data = data;
        }

    }
    
}
