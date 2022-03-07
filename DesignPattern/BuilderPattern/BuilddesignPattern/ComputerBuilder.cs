using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BuilddesignPattern
{
public class ComputerBuilder
    {
        private string brand { get; set; }
        private string price { get; set; }
        private string cpu { get; set; }
        private string ram { get; set; }

        public ComputerBuilder setbrand(string brand)
        {
            this.brand = brand;
            return this;
        }
        public ComputerBuilder setprice(string price)
        {
            this.price = price;
            return this;
        }
        public ComputerBuilder setCpu(string cpu)
        {
            this.cpu = cpu;
            return this;
        }
        public ComputerBuilder setRam(string ram)
        {
            this.ram = ram;
            return this;
        }
        public Computer builComputer()
        {
            return new Computer(this.brand, this.price, this.cpu, this.ram);
        }
    }
}
