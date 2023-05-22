using System;
using System.Collections.Generic;

namespace TemperanceBar
{
    public class Mocktail
    { 
        public Mocktail(string mocktailName, params Ingredient[] param)
        {
            this.Ingredients = new Ingredient[param.Length];
            this.MocktailName = mocktailName;
            for (int i = 0; i < param.Length; i++)
            {
                this.Ingredients[i] = param[i];
                this.Ingredients[i].LoadIngredient();
            }
        }

        public string MocktailName { get; set; }
        public Ingredient[] Ingredients { get; set; } 
		// TODO:
		// On initialization, it takes and stores a string name and array of Ingredient objects.
		// Override the ToString() method to return the name of the Mocktail.
		public override string ToString()
        {
            return this.MocktailName;
        }
    }
}
