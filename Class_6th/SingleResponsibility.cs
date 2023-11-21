﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{

    #region 단일 책임 원칙
    // 하나의 객체는 반드시 하나의 동작만의 책임을 수행해야 합니다.

    public class Monster
    {
        private string name;
        private int attack;
        private int health;

        public Monster(string name, int attack, int health)
        {
            this.name = name;
            this.attack = attack;
            this.health = health;
        }

        public void Patrol() // 순찰
        {
            Console.WriteLine("순찰하는 중...");
        }

        // Monster의 정보를 출력하는 함수
        public string Representation()
        {
            return "name : " + name + " attack : " + attack + " health : " + health;
        }

    }
    public class Information
    {
        private string Representation;

        public void MonsterInfo(Monster monster)
        {
            Console.WriteLine(monster.Representation());
        }
    }

    #endregion
}



