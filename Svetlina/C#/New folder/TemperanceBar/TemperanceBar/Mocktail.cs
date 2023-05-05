using System.Collections.Generic;

namespace TemperanceBar
{
    public class Mocktail
    { 
        public Mocktail(string mocktailName, Ingredient[] ingrediants)
        {
            this.mocktailName = mocktailName;
            this.ingrediants = ingrediants;
        }

        public string MocktailName { get; set; }
        public Ingredient[] Ingredients { get; set; }
        // TODO:
        // On initialization, it takes and stores a string name and array of Ingredient objects.
        // Override the ToString() method to return the name of the Mocktail.
        public override string ToString()
        {
            return this.mocktailName;
        }
    }
}
