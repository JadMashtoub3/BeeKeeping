using beekeeping.models;
namespace beekeeping.models

{
    public class bees
    {
        public string name { get; set; }
        public float size { get; set; }
        public bees(string name, float size)
        {
        this.name = name;
        this.size = size;
        }
    }
}


