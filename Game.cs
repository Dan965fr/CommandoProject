using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Game
    {
        public EnemyFactory EnemyFactory { get; private set; } = new EnemyFactory();
        public CommandoFactory CommandoFactory { get; private set; } = new CommandoFactory();

        public WeaponFactory WeaponFactory { get; private set; } = new WeaponFactory();

        public void Run()
        {
            Enemy enemy = EnemyFactory.CreateEnemy("Ahmed");
            Enemy enemy2 = EnemyFactory.CreateEnemy("Ali");
            

            Weapon weapon = WeaponFactory.CreatWeapon("AK-47", "Kalashnikov", 30);

            Commando regular = CommandoFactory.CreateCommando("Jhon","regular","wolf");
            Commando sea = CommandoFactory.CreateCommando("Jack", "sea", "shark");
            Commando air = CommandoFactory.CreateCommando("Yoni", "air", "eagle");
            

            regular.Attack();
            sea.Attack();
            air.Attack();
            //Console.WriteLine( $"{enemy.Name} with { enemy.Health}");


            Console.WriteLine(regular.SayName("General"));
            Console.WriteLine(sea.SayName("colonel"));
            Console.WriteLine(air.SayName("private"));  




        }

    }

}
