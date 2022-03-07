using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ArabaFactory
    {
        public static ArabaMarkası factorymethod(Markalar arabamarkasi)
        {
            ArabaMarkası araba = null;
            switch (arabamarkasi)
            {
                case Markalar.Bmv:
                    araba = new Bmv();
                    break;
                case Markalar.Mercedes:
                    araba =new Mercedes();
                    break;
                default:
                    break;
            }
            return araba;
        }
    }
}
