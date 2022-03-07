using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryPattern.Ayakkabı.Products;
using static FactoryPattern.Ayakkabı.Products.Sneakers;

namespace FactoryPattern.Ayakkabı.Interface
{
    public enum ShoeType
    {
        bot = 0,
        sneaker = 1,
        çizme = 2
    }
    public interface Ishoefactory
    {
        Ishoe ProduceShoe(ShoeType type);
    }
    public class ShoeFactory : Ishoefactory
    {
        public Ishoe ProduceShoe(ShoeType type)
        {
            switch (type)
            {
                case ShoeType.bot:
                    return new Boot();

                case ShoeType.sneaker:
                    return new Sneakers();

                case ShoeType.çizme:
                    return new Cizme();

                default: return new Boot();
            }
        }
    }
}
