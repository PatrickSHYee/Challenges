using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPick
{
    class Program
    {
        // Global variables
        static Random randGen = new Random();

        static void Main(string[] args)
        {
            //List<string> studentList = new List<string> {"Eugene Filipovich", "Patrick Yee", "Linda Kha", "Sergio Alifano", 
            //    "Nate Stephens", "Michael Granberg", "Andrii Pelekh", "Nicole Fleit", "Juli Burnett", "Andrew Meas", "Brandon Evans",
            //    "Maria Miller", "Daniel Escalante", "Brandon Settje", "Mike Sinnes", "Laura Boyd", "Tim Burke"};
            string[] list = {"Eugene Filipovich", "Patrick Yee", "Linda Kha", "Sergio Alifano", 
                "Nate Stephens", "Michael Granberg", "Andrii Pelekh", "Nicole Fleit", "Juli Burnett", "Andrew Meas", "Brandon Evans",
                "Maria Miller", "Daniel Escalante", "Brandon Settje", "Mike Sinnes", "Laura Boyd", "Tim Burke"}; 

            PickGroup(list.ToList<string>(), 2);
            PickGroup(list.ToList<string>(), 3);
            PickGroup(list.ToList<string>(), 4);
            // debugger stopper
            Console.WriteLine("Any key to continue...");
            Console.ReadKey();
            
        }

        /// <summary>
        /// Grab names from a list of students to fill a group wtih a set size for the groups.
        /// </summary>
        /// <param name="listOfStudents">list of strings of students</param>
        /// <param name="classSize">group size</param>
        static void PickGroup(List<string> listOfStudents, int classSize)
        {
            List<string> currentGroupList = new List<string>();
            int groupNumber = 1;

            while (listOfStudents.Count != 0)
            {
                string student = listOfStudents[randGen.Next(0, listOfStudents.Count)];
                currentGroupList.Add(student);
                listOfStudents.Remove(student);

                if (currentGroupList.Count == classSize || listOfStudents.Count == 0)
                {
                    Console.WriteLine("__Group {0}___", groupNumber);

                    // we could have done this with string.Join("\n", currentGroupList);
                    Console.WriteLine(string.Join("\n", currentGroupList));
                        
                    // looping through the List
                    //for (int i = 0; i < currentGroupList.Count; i++)
                    //{
                    //    Console.WriteLine(currentGroupList[i]);
                    //}

                    currentGroupList.Clear();
                    groupNumber++;
                }
            }

            Console.WriteLine("_______________________________");
        }
    }
}
