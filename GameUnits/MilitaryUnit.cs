using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : XPUnit
    {
        public int AttackPower { get; }
        public override int Health => base.Health + XP;
        public override float Cost => AttackPower + XP;

        public void Attack (Unit u)
        {
            XP++;
            u.Health--;
        }

        // Constructor
        public MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
        {
            AttackPower = attackPower;
        }

        public override string ToString()

        // Return string returned from base class with the AttackPower value
        {
            return base.ToString() + " AP=" + AttackPower;
        }
    }
}