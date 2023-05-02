
namespace DayOff
{
    class Newspaper
    {
        public Newspaper()
        { }

        public bool IsReaded { get; set; }
        public string Reading()
        {
            IsReaded = true;
            return "Reading a newspaper.";
        }

    }
}
