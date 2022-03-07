using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Mercedes : ArabaMarkası
    {
        public override void MarkaAdi()
        {
            Console.WriteLine("Arabanın Markası Mercedes");
        }
        public override string ToString()
        {
            return "Arabanın Markası Mercedes";
        }
    }
}
