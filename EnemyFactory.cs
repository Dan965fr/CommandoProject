using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class EnemyFactory
    {
        public List<Enemy> Enemies { get; private set; } = new List<Enemy>();
        public Enemy CreateEnemy(string name)
        {
            Enemy enemy = new Enemy(name);
            Enemies.Add(enemy);
            return enemy;
        }


    }
}
