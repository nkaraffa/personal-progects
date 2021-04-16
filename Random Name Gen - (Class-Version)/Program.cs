using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Name_Gen____Class_Version_
{
    class Program
    {
        static void Main(string[] args)
        {
            int user = 0;                           //Instantiate user selection variable for loop.
            RanGen newRanName = new RanGen();       //Instantiate class for use method use in loop.

            while (user != 3)
            {
                try
                {
                    Console.WriteLine("Would you like to select a random student?\n1: Select a Student (string generic List)\t2: Select a Student (class generic List)\t3: Exit");
                    user = int.Parse(Console.ReadLine());
                    if (user == 1)
                    {
                        newRanName.ListGenerationTwo();
                        string selection = newRanName.RandomNameGenTwo(newRanName.names2);
                        Console.WriteLine("Random Student Selected: {0}\n", selection);
                    }
                    else if (user == 2)
                    {
                        newRanName.ListGeneration();
                        string selection2 = newRanName.RandomNameGenOne(newRanName.names);
                        Console.WriteLine("Random Student Selected: {0}\n", selection2);

                    }
                    else if (user == 3)
                    {
                        Console.WriteLine("Thanks for using our service!");
                    }
                    else
                    {
                        Console.WriteLine("Please select a valid option.");
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
