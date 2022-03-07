using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Oyun
{
    class OyunBulusması : Oyunlar
    {
        public override Oyunlar Clone()
        {
            return (Oyunlar)this.MemberwiseClone();
        }
    }
}
