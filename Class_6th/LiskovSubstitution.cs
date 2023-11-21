using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    public abstract class Zerg
    {
        protected int attak;
        protected int defense;
        protected int health;

        public abstract void Move();

    }

    public class GroundUnit : Zerg
    {
        public GroundUnit(int attack, int defense, int health)
        { 
            this.attak = attack;
            this.defense = defense;
            this.health = health;
        }

        public void Ground()
        {
            Console.WriteLine("On the Ground");
        }

        public override void Move()
        {
            Ground();
            Console.WriteLine("Move");
        }
    }

    public class Drone : GroundUnit
    {
        public Drone() : base(10, 5, 100)
        {
            base.Move();
        }
    }

    public class FlyUnit : Zerg
    {
        public FlyUnit(int attack, int defense, int health)
        {
            this.attak= attack;
            this.defense= defense;
            this.health = health;
        }

        public void Fly()
        {
            Console.WriteLine("on the sky");
        }

        public override void Move()
        {
            Console.WriteLine("Move");
        }
    }

    public class Mutal : FlyUnit
    {
        public Mutal() : base(15, 7, 50)
        {
            base.Move();
        }
    }



    #region 리스코프 치환 원칙
    // 상위 클래스와 하위 클래스가 있을 때
    // 상위 클래스가 호출하는 동작에서 하위 클래스가
    // 상위 클래스를 완벽하게 대체할 수 있어야 하는 원칙입니다.

    #endregion
}
