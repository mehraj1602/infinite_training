using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_21stNov_
{
    public class GameCharacter
    {
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public List<string> Skills { get; set; }

        public GameCharacter Clone()
        {
            return new GameCharacter
            {
                Health = this.Health,
                Attack = this.Attack,
                Defence = this.Defence,
                Skills = new List<string>(this.Skills)
            };
        }
    }
}
