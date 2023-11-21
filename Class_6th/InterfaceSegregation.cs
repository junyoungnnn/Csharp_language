using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    #region ISP 5대 원칙
    public interface IMoveable
    {
        public void Move();
    }

    public interface IAttackable
    {
        public void Attack();
    }

    public interface ISkillable
    {
        public void Skill();
    }

    public class Wraith : IMoveable, IAttackable, ISkillable
    {
        public void Move()
        {
            Console.WriteLine("Wraith Move");
        }
        public void Attack()
        {
            Console.WriteLine("Wraith Attack");
        }
        public void Skill()
        {
            Console.WriteLine("Wraith Skill");
        }
    }

    public class BattleCruiser
    {
        public void Move()
        {
            Console.WriteLine("BattleCruiser Move");
        }
        public void Attack()
        {
            Console.WriteLine("BattleCruiser Attack");
        }
        public void Skill()
        {
            Console.WriteLine("BattleCruiser Skill");
        }
    }

    public class Valykrie
    {
        public void Move()
        {
            Console.WriteLine("Valykrie Move");
        }

        public void Attack()
        {
            Console.WriteLine("Valykrie Attack");
        }
    }

    public class Dropship
    {
        public void Move()
        {
            Console.WriteLine("Dropship Move");
        }
        public void Skill()
        {
            Console.WriteLine("Dropship Skill");
        }
    }

    #endregion


    internal class InterfaceSegregation
    {
        #region 인터페이스 분리 원칙
        // 클라이언트가 자신이 사용하지 않는 함수에 의존하지 않아야 하며,
        // 인터페이스를 구체적이고 작은 단위로 분리하여 사용하는 원칙입니다.

        #endregion
    }

}
