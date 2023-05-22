
namespace TemperanceBar
{
    class StartUp
    {
        static void Main()
        {
            //TODO: Uncomment the code and run the program when you're done

            Ingredient mint = new Ingredient("Mint");
            Ingredient pineappleJuice = new Ingredient("Pineapple Juice");
            Ingredient peaches = new Ingredient("Peaches");
            Ingredient raspberries = new Ingredient("Raspberries");
            Ingredient lemonade = new Ingredient("Lemonade");
            Ingredient tea = new Ingredient("Tea");
            Ingredient sparklingWater = new Ingredient("Sparkling Water");
            Ingredient strawberries = new Ingredient("Strawberries");

            Mocktail peachMelbaPunch = new Mocktail("Peach Melba Punch", mint, pineappleJuice, peaches, raspberries, lemonade);
            Mocktail peachyMintIcedTea = new Mocktail("Peachy Mint Iced Tea", tea, sparklingWater, strawberries, peaches, mint);

            Barman christopher = new Barman("Christopher", peachMelbaPunch);
            Barman jack = new Barman("Jack", peachyMintIcedTea);

            christopher.Start();
            jack.Start();
        }
    }
}
