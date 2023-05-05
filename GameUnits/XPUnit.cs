using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class XPUnit : Unit
    {
        // Add public property XP with int and protected set
        public int XP { get; protected set; }
        public override string ToString()
        {
            return $"{base.ToString()} XP = {XP}";
        }
        public XPUnit(int mov, int health) : base(mov, health)
        {
            XP = 0;
        }

        // Constructor with Health and movement and add them to the constructor of the base class and initialize XP to 0
        public XPUnit(int mov, int health, int xp) : base(mov, health)
        {
            XP = xp;
        }

        // Method ToString() that returns a string with the base class ToString() and the XP
        public override void Move(int mov)
        {
            base.Move(mov);
            XP += mov;
        }
    }
}