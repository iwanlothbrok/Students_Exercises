using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TemperanceBar
{
    public class Barman : BarmanThread
    {
        List<Ingredient> Ingredients = new List<Ingredient>();

        public Barman(string name, Mocktail mocktail)
        {
            this.Name = name;
            this.Mocktail = mocktail;
        }

        public Mocktail Mocktail { get; set; }
        public string Name { get; set; }
        // The Barman class is a subclass of BarmanThread. 
        // Upon initialization, it accepts and stores a string barman name and a Mocktail object.
        // overrid the Work() method 
        public override void Work()
        {
            Console.WriteLine($"{this.Name} is preparing {this.Mocktail}");

            foreach (var item in this.Mocktail.Ingredients)
            {
                this.Ingredients.Add(item);
               // item.UseIngredient();
                Console.WriteLine($"{this.Name} took {item}");
            }


            Console.WriteLine($"{this.Mocktail.MocktailName} is ready to be served.");

            foreach (var ing in Ingredients)
            {
                ing.LoadIngredient();
                //ing.UseIngredient();
            }
        }
    }
}
