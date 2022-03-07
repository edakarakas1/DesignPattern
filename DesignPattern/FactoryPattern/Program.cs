using FactoryPattern.Ayakkabı.Interface;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ArabaMarkası bmvaraba = ArabaFactory.factorymethod(Markalar.Bmv);
            var mercedes = ArabaFactory.factorymethod(Markalar.Mercedes);
            Console.WriteLine(bmvaraba);
            Console.WriteLine(mercedes);


            var shoefactory = new ShoeFactory();
            Ishoe boot = shoefactory.ProduceShoe(ShoeType.bot);
            Ishoe sneakers = shoefactory.ProduceShoe(ShoeType.sneaker);
            Ishoe Cizme = shoefactory.ProduceShoe(ShoeType.çizme);
            Console.WriteLine(boot);
            Console.ReadLine();
        }
    }
}
