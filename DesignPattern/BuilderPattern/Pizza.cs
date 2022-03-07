using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Pizza
    {
        private int size;
        private string name;
        private bool cheese;
        private bool olive;
        private bool mozeralla;

        //public Pizza()
        //{

        //}
        //public Pizza(int size)
        //{

        //}

        //public Pizza(int size,string name)
        //{

        //}

        //public Pizza(int size, string name,........)
        //{

        //}
        private Pizza(PizzaBuilder pizzaBuilder)
        {
            this.size = pizzaBuilder.size;
            this.name = pizzaBuilder.name;
            this.cheese = pizzaBuilder.cheese;
            this.mozeralla = pizzaBuilder.mozerella;
        }
        public class PizzaBuilder

        {
            public int size;
            public string name;
            public bool cheese;
            public bool olive;
            public bool mozerella;
            public PizzaBuilder(int size, string name)
            {
                this.size = size;
                this.name = name;
            }
            public PizzaBuilder withoptionalCheese(bool cheese)
            {
                this.cheese = cheese;
                return this;
            }
            public PizzaBuilder withoptionalOlive(bool olive)
            {
                this.olive = olive;
                return this;
            }
            public PizzaBuilder withoptionalMozeralla(bool mozarella)
            {
                this.mozerella = mozarella;
                return this;
            }
            public Pizza buildPizza()
            {
                return new Pizza(this);
            }

        }
    }


}