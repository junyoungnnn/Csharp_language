using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Resolution
    {
        const int width = 1440;

        // readonly는 런타임 상수라 선언과 동시에 초기화를 하지 않아도 됨
        // 런타임 상수는 생성자에서만 초기화를 할 수 있습니다.
        // 초기화하지 않으면 데이터 영역이 아닌 객체안에 존재한다.

        readonly int height;

        public Resolution()
        {
            height = 3200;
            height = 3201;
        }
     
        
    }
}
