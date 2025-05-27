using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class SeaCommando:Commando
    {
        public SeaCommando(string name, string codeName) : base(name, codeName) { }

        public void Swim()
        {
            Console.WriteLine($"{CodeName} is swimming ");
        }
        public override void Attack()
        {
            Status = "attacking from the sea";
            Console.WriteLine($"{CodeName} is attacking from the sea!");
        }

    }
}
