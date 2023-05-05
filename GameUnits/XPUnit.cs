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
    }
}