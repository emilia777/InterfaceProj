namespace InterfaceProj
{
    using InterfaceProj;
    using System.Windows.Input;

    public class Interface
    {



        Fighter fighter = new Fighter();
        List<IFighter> fighters = new List<IFighter>();
        List<IKiller> killers = new List<IKiller>();
    Commander commander = new Commander();
     List<IManage> manages = new List<IManage>();
       
}
         public class Fighter : IFighter, IKiller
    {

        public void canAttack()
        {
            Console.WriteLine("Fighter can attack");
        }

        public void canFire()
        {
            Console.WriteLine("Fighter can attack");
        }

        public void canKill()
        {
            Console.WriteLine("Killer can attack");
        }

        public void canShot()
        {
            Console.WriteLine("Fighter can attack");
        }
    }
    public class Commander : IFighter, IKiller, IManage
    {
        void IFighter.canAttack()
        {
            Console.WriteLine("Fighter can attack");
        }

        void IFighter.canFire()
        {
            Console.WriteLine("Fighter can attack");
        }

        void IKiller.canKill()
        {
            Console.WriteLine("Fighter can attack");
        }

        void IFighter.canShot()
        {
            Console.WriteLine("Fighter can attack");
        }

        void IManage.completeMission()
        {
            Console.WriteLine("Manage can attack");
        }

        void IManage.control()
        {
            Console.WriteLine("Manage can attack");
        }

        void IManage.gatherPeople()
        {
            Console.WriteLine("Manage can attack");
        }
    }
}
        