using System.Collections.Generic;
using beekeeping.models;


namespace beekeeping
{
    public class hives
    {
        public List<bees> bees { get; set; } 
        public int maxBees { get; set; } 

        public hives(int _maxBees)
        {
            this.bees = new List<bees>();
            this.maxBees = _maxBees;
        }
     
        public float honey(int days){
        
            float count = 0f;
            
            foreach(bees bee in bees)
            {
                count = (days*bee.size)*0.2f;
            }

            return count;
        }
    }
}