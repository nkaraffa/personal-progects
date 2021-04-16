using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Name_Gen____Class_Version_
{
    class RanGen
    {
        //Auto-Properties
        public string StudNames { get; set; }

        //Default Constructor
        public RanGen()
        {

        }

        //ListGeneration - Instantiate generic list that contains the random class names.
        public List<RanGen> names;
        public void ListGeneration()
        {
            names = new List<RanGen>();
            names.Add( new RanGen() { StudNames = "Danny"} );
            names.Add( new RanGen() { StudNames = "Nik"} );
            names.Add( new RanGen() { StudNames = "Jim" });
            names.Add( new RanGen() { StudNames = "Kelly" });
            names.Add( new RanGen() { StudNames = "Hanh" });
            names.Add( new RanGen() { StudNames = "Brian" });
            names.Add( new RanGen() { StudNames = "Tony" });
            names.Add( new RanGen() { StudNames = "Cherish" });
            names.Add( new RanGen() { StudNames = "Christina" });
            names.Add( new RanGen() { StudNames = "Evan" });
            names.Add( new RanGen() { StudNames = "Ian" });
            names.Add( new RanGen() { StudNames = "Jacob" });
            names.Add( new RanGen() { StudNames = "Yelena" });
        }


        //ListGenerationTwo - Instantiate string list that contains the random class names.
        public List<string> names2;
        public void ListGenerationTwo()
        {
            names2 = new List<string>();
            names2.Add("Danny");
            names2.Add("Nik");
            names2.Add("Jim");
            names2.Add("Kelly");
            names2.Add("Hanh");
            names2.Add("Brian");
            names2.Add("Tony");
            names2.Add("Cherish");
            names2.Add("Christina");
            names2.Add("Evan");
            names2.Add("Ian");
            names2.Add("Jacob");
            names2.Add("Yelena");
        }

        //RandomNameGenTwo - Random Number generation for name selection through class method call
        public string RandomNameGenOne(List<RanGen> names)
        {
            Random rand = new Random();
            int IndexName = rand.Next(names.Count);
            string temp = names.ElementAt(IndexName).StudNames;
            return temp;
        }

        //RandomNameGenTwo - Random Number generation for name selection through class method call
        public string RandomNameGenTwo(List<string> names)
        {
            Random rand = new Random();
            int IndexName = rand.Next(names2.Count);
            string temp = names2[IndexName];
            return temp;
        }    
 
    }
}
