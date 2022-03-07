using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    abstract class Oyunlar
    {//adı,tür ,bilgisayar meteryal puan ,oyuncular
        public string Adı { get; set; }
        public string OyunTur { get; set; }
        public List<string> Oyunkarakterleri { get; set; }
        public List<string> Oyuncular { get; set; }
        public abstract Oyunlar Clone();

    }
}
