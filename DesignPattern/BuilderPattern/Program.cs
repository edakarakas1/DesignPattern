using BuilderPattern.BuilddesignPattern;
using System;
using static BuilderPattern.Pizza;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder pizzaBuilder = new PizzaBuilder(15, "Italiona");
            pizzaBuilder.withoptionalCheese(true);
            pizzaBuilder.withoptionalOlive(true);
            Pizza pizza = pizzaBuilder.buildPizza();

            /////

            ComputerBuilder cmpbuilder = new ComputerBuilder();
            Computer cmp = cmpbuilder.setbrand("Asus").setCpu("2.40 Ghz").setRam("8 Gb").setprice("10.000").builComputer();
            Console.WriteLine(cmp);
            Console.ReadLine();

        }
    }
}
