namespace Class_6th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SRP 5대 원칙
            //Monster spider = new Monster("독거미", 10, 100);

            //spider.Patrol();

            //Information information = new Information();

            //information.MonsterInfo(spider);

            #endregion

            #region OCP 5대원칙
            //Marine marine = new Marine();
            //Firebet firebet = new Firebet();
            //Ghost ghost = new Ghost();

            //UnitManager unitManager = new UnitManager();
            //unitManager.Commend(marine);
            //unitManager.Commend(firebet);
            //unitManager.Commend(ghost);

            #endregion

            #region ISP 5대 원칙

            //Wraith wraith = new Wraith();  

            //wraith.Attack();
            //wraith.Move();
            //wraith.Skill();

            //BattleCruiser battleCruiser = new BattleCruiser();

            //battleCruiser.Attack();
            //battleCruiser.Move();
            //battleCruiser.Skill();

            //Valykrie valykrie = new Valykrie();

            //valykrie.Attack();
            //valykrie.Move();

            //Dropship dropship = new Dropship();

            //dropship.Move();
            //dropship.Skill();

            #endregion

            #region DIP 5대 원칙
            //Charactor charactor = new Charactor(100, new Knife());
            //charactor.WeaponInfo();
            //charactor.ChangeWeapon(new Axe());
            //charactor.WeaponInfo();
            //charactor.ChangeWeapon(new Rifle());
            //charactor.WeaponInfo();

            #endregion

            #region LSP 5대 원칙



            #endregion
        }
    }
}