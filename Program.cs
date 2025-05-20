using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // add solider with flexible weapons
            Soldier yishai = new Soldier();
            Cannon M109 = new Cannon();
            yishai.addWeapon(M109);
            yishai.extendableFire();
        }
    }
}
