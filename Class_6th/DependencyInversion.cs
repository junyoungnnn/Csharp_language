using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    

    public abstract class Weapon
    {
        protected int attack;
        protected string name;

        public int Attack
        {
            get { return attack; }
        }

        public string Name
        {
            get { return name; }
        }

        public Weapon(int attack, string name)
        {
            this.attack = attack;
            this.name = name;
        }

        public abstract void Action();

        
    }

    public class Axe : Weapon
    {
        public Axe() : base(10, "Axe")
        {

        }
        public override void Action()
        {
            Console.WriteLine("Axe Attack");
        }
    }

    public class Rifle : Weapon
    {

        public Rifle() : base(25, "Rifle")
        {

        }
        public override void Action()
        {
            Console.WriteLine("Rifle Attack");
        }
    }

    public class Knife : Weapon
    {

        public Knife() : base(5, "Knife")
        {

        }
        public override void Action()
        {
            Console.WriteLine("Knife Attack");
        }
    }

    public class Charactor
    {
        private int health;
        private Weapon weapon;

        public Charactor(int health, Weapon weapon)
        {
            this.health = health;
            this.weapon = weapon;
        }


        public void ChangeWeapon(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public void WeaponInfo()
        {
            Console.WriteLine("name: " + weapon.Name);
            Console.WriteLine("attack: " + weapon.Attack);
        }
    }

    internal class DependencyInversion
    {

        #region 의존관계 역전 원칙

        // 상위 계층이 하위 계층에 의존하는 전통적인 관계를
        // 반전시킴으로써 상위 계층이 하위 게층의 구현으로부터
        // 독립될 수 있도록 설계하는 원칙입니다.

        // 변화하지 않는 것
        // 추상적인 개념 -> 추상 클래스, 인터페이스

        // 변화하기 쉬운것
        // 세부사항, 사물 -> 오브젝트(class)
        #endregion
    }
}
