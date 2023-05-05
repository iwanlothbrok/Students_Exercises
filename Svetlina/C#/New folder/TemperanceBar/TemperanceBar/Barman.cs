using System;
using System.Threading.Tasks;

namespace TemperanceBar
{
    public class Barman : BarmanThread
    {
        // TODO: 
        private string name;
        Mocktail mocktail;

        public Barman(string name, Mocktail mocktail)
        {
            this.name = name;
            this.mocktail = mocktail;
        }

        public Mocktail Mocktail { get; set; }
        public string Name { get; set; }
        // The Barman class is a subclass of BarmanThread. 
        // Upon initialization, it accepts and stores a string barman name and a Mocktail object.
        // overrid the Work() method 
        public override void Work()
        {
            Console.WriteLine($"{barman name} is preparing {mocktail name}");
        }
    }
}
