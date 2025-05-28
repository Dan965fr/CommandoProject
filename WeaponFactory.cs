using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class WeaponFactory
    {
        public List<Weapon> Weapons { get; private set; } = new List<Weapon>();

        public Weapon CreatWeapon(string name, string manufacturer, int bulletCount)
        {
            Weapon weapon = new Weapon(name, manufacturer, bulletCount);
            Weapons.Add(weapon);
            return weapon;
        }
    }
}

