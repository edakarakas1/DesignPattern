using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Bmv : ArabaMarkası
    {
        public override void MarkaAdi()
        {
            Console.WriteLine("Arabanın Markası Bmv");
        }
        public override string ToString()
        {
            return "Arabanın Markası Bmv";
        }
    }
}
