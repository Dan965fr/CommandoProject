using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Weapon
    {
        public string Name { get;  set; }
        public string Manufacturer { get;  set; }
        public int BulletCount { get; private set; }

        public Weapon(string name, string manufacturer, int bulletCount)
        {
            Name = name;
            Manufacturer = manufacturer;
            BulletCount = bulletCount;
        }
        public void Shoot()
        {
            if (BulletCount > 0)
            {
                BulletCount--;
                Console.WriteLine($"{Name} fired a shot. Remaining bullets: {BulletCount}");
            }
            else
            {
                Console.WriteLine($"{Name} has no bullets left!");
            }
        }




    }
}
