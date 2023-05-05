using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class DiplomatUnit : XPUnit
    {
        {
        // Cost = 7.1, movement = 6, health = 1
        public override float Cost => 7.1f;
        public override int Health => 1;
        public override int Movement => 6;
        }
    }
}