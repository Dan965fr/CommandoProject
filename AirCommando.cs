using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name, string codeName) : base(name, codeName)
        {

        }
        public void Parachute()
        {
            Console.WriteLine($"{ CodeName} Parachuting from the sky");
        }
        public override void Attack()
        {
            Status = "attacking from the air";
            Console.WriteLine($"{CodeName} is attacking from the air!");
        }
    }
    
}
