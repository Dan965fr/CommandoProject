using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class CommandoFactory
    {
        public List<Commando> Commandos { get; private set; } = new List<Commando>();

        public Commando CreateCommando(string name, string type, string codename)
        {
            Commando commando;
            switch (type)
            {
                case "regular":
                    commando = new Commando(name, codename);
                    break;

                case "sea":
                    commando = new SeaCommando(name, codename);
                    break;

                case "air":
                    commando = new AirCommando(name, codename);
                    break;
                default:
                    throw new ArgumentException("Invalid commando type specified");



            }
            Commandos.Add(commando);
            return commando;
        } 
        




    }
}
