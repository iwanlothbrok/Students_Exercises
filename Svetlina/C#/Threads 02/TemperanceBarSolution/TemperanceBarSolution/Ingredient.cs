using System;
using System.Drawing;
using System.Threading;

namespace TemperanceBar
{
    public class Ingredient
    {
        // TODO:
        // On initialization, it takes and stores a string name and defaults to a quantity of 1.
        private string name;
        int quantity = 1;
        public Ingredient(string name)
        {
            this.Name = name;
        }
        public string  Name { get; set; }
        // public void UseIngredient() 
        public void UseIngredient()
        {
            if(quantity == 0)
            {
                Console.WriteLine($"Waiting for {this.Name}");
                Thread.Sleep(1000);
                return;
            }
            quantity -= 1;
        }
        // public void LoadIngredient() 
        public void LoadIngredient()
        {
            quantity += 1;
            Console.WriteLine($"{this.Name} is loaded");
        }
        // Override the ToString() method 
        public override string ToString()
        {
            return this.Name;
        }
        // Here is important also to be sure that only one barman at a time is taking ingredient.
    }
    
    
}
