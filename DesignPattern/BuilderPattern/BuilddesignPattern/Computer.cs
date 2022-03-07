using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BuilddesignPattern
{
   public class Computer
    {
        private string brand { get; set; }
        private string price { get; set; }
        private string cpu { get; set; }
        private string ram { get; set; }
        public Computer(string brand,string price,string cpu,string ram)
        {
            this.brand = brand;
            this.price = price;
            this.cpu = cpu;
            this.ram = ram;
        }
        public override string ToString()
        {
            return "Computer{"+"markası:"+this.brand+"cpu:"+this.cpu+"ram:"+this.ram+"fiyat:"+this.price+"}";
        }
    }
}
