using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PikachuClass
{
    internal class Pokemon
    {
        public string Name;
        public int Hp;
        public int Level;

        public Pokemon(string name, int hp, int level)
        {
            Name = name;
            Hp = hp;
            Level = level;
        }
    }
}
