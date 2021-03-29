using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Random_Name_Generator___Console
{
    class Program
    {
        static void Main(string[] args)
        {         
            int user = 0;   //Instantiate user selection variable for loop.
            while(user != 2)
            {
                try
                {
                    Console.WriteLine("Would you like to select a random student?\n1: Select a Student\t2: Exit");
                    user = int.Parse(Console.ReadLine());
                    if (user == 1)
                    {
                        //Instantiate generic list that contains the random class names.
                        List<String> names = new List<string>() { "Danny", "Nik", "Jim", "Kelly", "Hanh", "Brian", "Tony", "Cherish", "Christina", "Evan", "Ian", "Jacob", "Yelena" };

                        //Random Number generation for name selection.
                        Random rand = new Random();
                        int IndexName = rand.Next(names.Count);

                        //Display random name choice.
                        Console.WriteLine("{0}\n", names[IndexName]);
                    }
                    else if (user == 2)
                    {
                        Console.WriteLine("Thanks for using our service!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    GC.Collect();
                }
            }
        }
    }
}
