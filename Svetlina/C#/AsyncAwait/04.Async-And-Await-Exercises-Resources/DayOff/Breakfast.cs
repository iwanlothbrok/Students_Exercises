
namespace DayOff
{
    class Breakfast
    {
        public Breakfast()
        { }

        public bool IsReady { get; set; }
        public bool IsEaten { get; set; }

        public string Cooked()
        {
            IsReady = true;
            return "Breakfast is ready.";
        }
        public string Eaten()
        {
            IsEaten = true;
            return "Breakfast is eaten.";
        }
    }
}
