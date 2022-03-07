using FactoryPattern.Ayakkabı.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Ayakkabı
{
    public class Products
    {
        public class Boot : Ishoe
        {
            public void type()
            {
                Console.WriteLine("Tip Bot");
            }
        }
        public class Sneakers : Ishoe
        {
            public void type()
            {
                Console.WriteLine("Tip Sneakers");
            }

            public class Cizme : Ishoe
            {
                public void type()
                {
                    Console.WriteLine("Tip Çizme");
                }
            }
        }
    }
}

