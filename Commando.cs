using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        private string Name;
        public string CodeName { get; set; }
        public string[] Tools  =  { "hammer", "chisel", "rope", "bag", "water bottle" };
        public string Status; 


        public Commando(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
            Status = "stand";
           

        }
        public void Walk()
        {
            Status = "walking";
            Console.WriteLine($"{Name} is walking.");
        }
        public void Hide()
        {
            Status = "hiding";
            Console.WriteLine($"{Name} is hiding.");
        }
        public virtual void Attack()
        {
            Status = "attacking";
            Console.WriteLine($"Commando with {CodeName} is attacking.");
        }
        
        public string SayName(string commanderRank)
        {
            if (commanderRank == "General")
                return Name;
            else if (commanderRank == "colonel")
                return CodeName;
            else
                return "The information is classified – you do not have access permission";
        }



    }
}
