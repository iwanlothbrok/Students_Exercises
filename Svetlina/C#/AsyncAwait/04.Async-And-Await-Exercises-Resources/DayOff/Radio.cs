
namespace DayOff
{
    class Radio
    {
        public Radio()
        { }

        public bool IsOn { get; set; }
        public string RadioOn()
        {
            IsOn = true;
            return "Music onn.";
        }
        public string RadioOf()
        {
            IsOn = false;
            return "Music off.";
        }
    }
}
