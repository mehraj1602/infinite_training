using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment3_21stNov_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameCharacter warriorPrototype = new GameCharacter
            {
                Health = 150,
                Attack = 40,
                Defence = 30,
                Skills = new List<string> { "Slash", "Shield Block" }
            };

            GameCharacter warrior1 = warriorPrototype.Clone();
            GameCharacter warrior2 = warriorPrototype.Clone();

            warrior1.Health = 160;
            warrior2.Skills.Add("Rage Mode");

            WriteLine("warrior1 Health: " + warrior2.Health);
            WriteLine("warrior2 Skills:" + string.Join(",", warrior2.Skills));


        }
    }
}
